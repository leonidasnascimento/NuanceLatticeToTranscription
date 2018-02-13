namespace CCA.Transcription.Model
{
    public class PartialTranscriptModel
    {
        public string Text { get; set; }
        public string Speaker { get; set; }
        public double Start { get; set; }
        public double End { get; set; }
    }
}
