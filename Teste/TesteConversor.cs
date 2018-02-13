using CCA.Transcription.Lattice;
using CCA.Transcription.Lattice.Model.Auxiliar;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Teste
{
    [TestClass]
    public class TesteConversor
    {
        [TestMethod]
        public void DeveConverterLatticeAuxiliarComSucesso()
        {
            try
            {
                var arquivo = File.ReadAllText(@"C:\git\NuanceLatticeToTranscription\NuanceLatticeToTranscription\Exemplo\356002034530001.wav.txt");
                var obj = LatticeAuxiliar.FromJson(arquivo);

                Assert.IsNotNull(obj);
            }
            catch (System.Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void DeveConverterNuanceLatticeComSucesso()
        {
            try
            {
                var arquivo = File.ReadAllText(@"C:\git\NuanceLatticeToTranscription\NuanceLatticeToTranscription\Exemplo\356002034530001.wav.txt");
                var obj = LatticeAuxiliar.FromJson(arquivo);

                Assert.IsNotNull(obj);

                var objConvertido = Conversor.FromLatticeAuxiliar(obj);

                Assert.IsNotNull(obj);
            }
            catch (System.Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void DeveConverterNuanceLatticeParaNuanceTranscription()
        {
            try
            {
                var arquivo = File.ReadAllText(@"C:\git\NuanceLatticeToTranscription\NuanceLatticeToTranscription\Exemplo\356002034530001.wav.txt");
                var obj = LatticeAuxiliar.FromJson(arquivo);

                Assert.IsNotNull(obj);

                var objConvertido = Conversor.FromLatticeAuxiliar(obj);

                Assert.IsNotNull(obj);

                var objNuanceTrancriptionOriginal = Conversor.ConverterParaOficial(objConvertido);

                Assert.IsNotNull(objNuanceTrancriptionOriginal);
            }
            catch (System.Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
