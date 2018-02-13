using Newtonsoft.Json;
using System.Collections.Generic;

namespace CCA.Transcription.Lattice.Model
{
    public partial class NuanceLatticeTranscription
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("operating_mode")]
        public string OperatingMode { get; set; }

        [JsonProperty("statistics")]
        public Statistics Statistics { get; set; }

        [JsonProperty("channels")]
        public Channels Channels { get; set; }
    }

    public partial class Channels
    {
        [JsonProperty("firstChannelLabel")]
        public FirstChannelLabel FirstChannelLabel { get; set; }
    }

    public partial class FirstChannelLabel
    {
        [JsonProperty("errors")]
        public List<object> Errors { get; set; }

        [JsonProperty("statistics")]
        public FirstChannelLabelStatistics Statistics { get; set; }

        [JsonProperty("transcript")]
        public List<Transcript> Transcript { get; set; }

        [JsonProperty("lattice")]
        public Lattice Lattice { get; set; }
    }

    public partial class Lattice
    {
        [JsonProperty("1")]
        public Conversation Conversation { get; set; }
    }

    public partial class Conversation
    {
        [JsonProperty("links")]
        public List<Links> Links { get; set; }
    }

    public partial class Links
    {
        public List<Word> Words { get; set; }
    }

    public partial class Word
    {
        public double Start { get; set; }
        public double End { get; set; }
        public double Weight { get; set; }
        public bool BestPath { get; set; }
        public double Speaker { get; set; }

        [JsonProperty("word")]
        public string Text { get; set; }
        public double Intensity { get; set; }
    }

    public partial class FirstChannelLabelStatistics
    {
        [JsonProperty("content_fetch_time")]
        public long ContentFetchTime { get; set; }

        [JsonProperty("audio_length")]
        public double AudioLength { get; set; }

        [JsonProperty("audio_channels")]
        public long AudioChannels { get; set; }

        [JsonProperty("audio_analysis_time")]
        public long AudioAnalysisTime { get; set; }

        [JsonProperty("segmentation_time")]
        public long SegmentationTime { get; set; }

        [JsonProperty("transcription_time")]
        public long TranscriptionTime { get; set; }

        [JsonProperty("diarization_time")]
        public long DiarizationTime { get; set; }

        [JsonProperty("merge_time")]
        public long MergeTime { get; set; }

        [JsonProperty("formatting_time")]
        public long FormattingTime { get; set; }

        [JsonProperty("execution_time")]
        public long ExecutionTime { get; set; }
    }

    public partial class Transcript
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("speaker")]
        public Speaker Speaker { get; set; }

        [JsonProperty("start")]
        public double Start { get; set; }

        [JsonProperty("end")]
        public double End { get; set; }
    }

    public partial class Statistics
    {
        [JsonProperty("request_processing_time")]
        public long RequestProcessingTime { get; set; }

        [JsonProperty("content_fetch_time")]
        public List<long> ContentFetchTime { get; set; }

        [JsonProperty("job_preparation_time")]
        public long JobPreparationTime { get; set; }

        [JsonProperty("audio_analysis_time")]
        public long AudioAnalysisTime { get; set; }

        [JsonProperty("segmentation_time")]
        public long SegmentationTime { get; set; }

        [JsonProperty("transcription_time")]
        public long TranscriptionTime { get; set; }

        [JsonProperty("diarization_time")]
        public long DiarizationTime { get; set; }

        [JsonProperty("merge_time")]
        public long MergeTime { get; set; }

        [JsonProperty("formatting_time")]
        public long FormattingTime { get; set; }
    }

    public enum Speaker { Atendente, Cliente };
}
