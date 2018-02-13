using Newtonsoft.Json;
using System.Collections.Generic;

namespace CCA.Transcription.Model
{
    public class StreamModel
    {
        public IList<object> Errors { get; set; }
        public IList<TranscriptModel> Transcript { get; set; }

        [JsonProperty("partial_transcript")]
        public IList<PartialTranscriptModel> PartialTranscript { get; set; }
    }
}
