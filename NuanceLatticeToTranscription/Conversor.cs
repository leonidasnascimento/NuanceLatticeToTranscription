using CCA.Transcription.Lattice.Model;
using CCA.Transcription.Lattice.Model.Auxiliar;
using CCA.Transcription.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CCA.Transcription.Lattice
{
    public static class Conversor
    {
        public static NuanceTrancodeModel ConverterParaOficial(NuanceLatticeTranscription entrada)
        {
            //Validações
            if (entrada is null) return default(NuanceTrancodeModel);

            var retorno = new NuanceTrancodeModel
            {
                OperatingMode = entrada.OperatingMode,
                Reference = entrada.Reference,
                Status = entrada.Status
            };

            if (!(entrada.Statistics is null))
            {
                retorno.Statistics = new StatisticsModel()
                {
                    AudioAnalysisTime = (int)entrada.Statistics.AudioAnalysisTime,
                    ContentFetchTime = entrada.Statistics.ContentFetchTime,
                    DiarizationTime = (int)entrada.Statistics.DiarizationTime,
                    FormattingTime = (int)entrada.Statistics.FormattingTime,
                    JobPreparationTime = (int)entrada.Statistics.JobPreparationTime,
                    MergeTime = (int)entrada.Statistics.MergeTime,
                    RequestProcessingTime = (int)entrada.Statistics.RequestProcessingTime,
                    SegmentationTime = (int)entrada.Statistics.SegmentationTime,
                    TranscriptionTime = (int)entrada.Statistics.TranscriptionTime
                };
            }

            if (!(entrada.Channels is null) && !(entrada.Channels.FirstChannelLabel is null))
            {
                retorno.Channels = new ChannelsModel
                {
                    FirstChannelLabel = new FirstChannelLabelModel
                    {
                        Errors = entrada.Channels.FirstChannelLabel.Errors,
                        Statistics = new StatisticsModel
                        {
                            AudioAnalysisTime = (entrada.Channels.FirstChannelLabel.Statistics is null) ? 0 : (int)entrada.Channels.FirstChannelLabel.Statistics.AudioAnalysisTime,
                            ContentFetchTime = (entrada.Channels.FirstChannelLabel.Statistics is null) ? 0 : (int)entrada.Channels.FirstChannelLabel.Statistics.ContentFetchTime,
                            DiarizationTime = (entrada.Channels.FirstChannelLabel.Statistics is null) ? 0 : (int)entrada.Channels.FirstChannelLabel.Statistics.DiarizationTime,
                            FormattingTime = (entrada.Channels.FirstChannelLabel.Statistics is null) ? 0 : (int)entrada.Channels.FirstChannelLabel.Statistics.FormattingTime,
                            MergeTime = (entrada.Channels.FirstChannelLabel.Statistics is null) ? 0 : (int)entrada.Channels.FirstChannelLabel.Statistics.MergeTime,
                            SegmentationTime = (entrada.Channels.FirstChannelLabel.Statistics is null) ? 0 : (int)entrada.Channels.FirstChannelLabel.Statistics.SegmentationTime,
                            TranscriptionTime = (entrada.Channels.FirstChannelLabel.Statistics is null) ? 0 : (int)entrada.Channels.FirstChannelLabel.Statistics.TranscriptionTime
                        },
                        //Lógica para conversão de lattice para 'transcription'
                        Transcript = GetTranscriptionFromLattice(entrada.Channels.FirstChannelLabel.Lattice)
                    }
                };
            }

            return retorno;
        }

        private static IList<TranscriptModel> GetTranscriptionFromLattice(Model.Lattice lattice)
        {
            //Validações
            if (lattice is null) return null;
            if (lattice.Conversation is null) return null;
            if (lattice.Conversation.Links is null) return null;
            if (lattice.Conversation.Links.Count == 0) return null;

            var retorno = new List<TranscriptModel>();
            var lstItensRemover = new List<Model.Word>();
            var lstPalavrasIndesejadas = new List<string>() { "!ENTER", "!NULL", ".", "!EXIT" };

            //Remove palavras não desejadas
            for (int i = 0; i < lattice.Conversation.Links.First().Words.Count; i++)
            {
                if (lstPalavrasIndesejadas.Any(p => p.ToLowerInvariant().Equals(lattice.Conversation.Links.First().Words[i].Text.ToLowerInvariant())))
                    lstItensRemover.Add(lattice.Conversation.Links.First().Words[i]);
            }

            foreach (var item in lstItensRemover)
                lattice.Conversation.Links.First().Words.Remove(item);

            //Ordena pelo "fim"
            var latticeReordenado = lattice
                .Conversation
                .Links
                .First()
                .Words
                .OrderBy(t => t.End);

            var speakerAtual = latticeReordenado.First().Speaker;
            var textoObtido = string.Empty;

            for (int i = 0; i < latticeReordenado.Count(); i++)
            {
                textoObtido = string.Concat(textoObtido, " ", latticeReordenado.ToList()[i].Text);
                
                if(i < latticeReordenado.Count() - 1)
                {
                    if(latticeReordenado.ToList()[i + 1].Speaker != speakerAtual)
                    {
                        retorno.Add(new TranscriptModel
                        {
                            Speaker = (speakerAtual == 1) ? "Atendente" : "Cliente",
                            Text = textoObtido.Trim(),
                            End = latticeReordenado.ToList()[i].End,
                            Start = latticeReordenado.ToList()[i].Start
                        });

                        speakerAtual = latticeReordenado.ToList()[i + 1].Speaker;
                        textoObtido = string.Empty;
                    }
                }
            }

            return retorno;
        }

        public static NuanceLatticeTranscription FromLatticeAuxiliar(LatticeAuxiliar entrada)
        {
            //Validações
            if (entrada is null) return default(NuanceLatticeTranscription);

            var retorno = new NuanceLatticeTranscription
            {
                Status = entrada.Status,
                OperatingMode = entrada.OperatingMode,
                Reference = entrada.Reference
            };

            if (!(entrada.Statistics is null))
            {
                retorno.Statistics = new Statistics
                {
                    AudioAnalysisTime = entrada.Statistics.AudioAnalysisTime,
                    ContentFetchTime = entrada.Statistics.ContentFetchTime.ToList(),
                    DiarizationTime = entrada.Statistics.DiarizationTime,
                    FormattingTime = entrada.Statistics.FormattingTime,
                    JobPreparationTime = entrada.Statistics.JobPreparationTime,
                    MergeTime = entrada.Statistics.MergeTime,
                    RequestProcessingTime = entrada.Statistics.RequestProcessingTime,
                    SegmentationTime = entrada.Statistics.SegmentationTime,
                    TranscriptionTime = entrada.Statistics.TranscriptionTime
                };

            }

            if (!(entrada.Channels is null) && !(entrada.Channels.FirstChannelLabel is null))
            {
                retorno.Channels = new Model.Channels
                {
                    FirstChannelLabel = new Model.FirstChannelLabel
                    {
                        Errors = entrada.Channels.FirstChannelLabel.Errors.ToList(),
                        Lattice = new Model.Lattice
                        {
                            Conversation = new Conversation
                            {
                                Links = GetLinksFromAux(entrada.Channels.FirstChannelLabel.Lattice.The1)
                            }
                        }
                    }
                };
            }

            return retorno;
        }

        private static List<Model.Links> GetLinksFromAux(Lattice1 the1)
        {
            //Validações
            if (the1 is null) return null;
            if (the1.Links is null) return null;

            var retorno = new List<Model.Links>();
            var the0Props = the1.Links
                .GetType()
                .GetProperties()
                .Where(prop => prop.PropertyType.Equals(typeof(The0)))
                .ToList();

            if (the0Props is null) return null;

            retorno.Add(new Model.Links { Words = new List<Word>() });

            foreach (var prop in the0Props)
            {
                var complexProps = (The0)prop.GetValue(the1.Links);

                if (complexProps is null) continue;

                retorno[0].Words.Add(new Word
                {
                    BestPath = complexProps.BestPath,
                    End = complexProps.End,
                    Intensity = complexProps.Intensity,
                    Speaker = complexProps.Speaker,
                    Start = complexProps.Start,
                    Text = complexProps.Word,
                    Weight = complexProps.Weight
                });
            }

            return retorno;
        }
    }
}
