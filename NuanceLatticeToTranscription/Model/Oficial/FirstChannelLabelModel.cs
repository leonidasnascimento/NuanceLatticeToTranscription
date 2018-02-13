using Newtonsoft.Json;
using System.Collections.Generic;

namespace CCA.Transcription.Model
{
    public class FirstChannelLabelModel
    {
        [JsonProperty("errors")]
        public IList<object> Errors { get; set; }

        [JsonProperty("statistics")]
        public StatisticsModel Statistics { get; set; }

        [JsonProperty("transcript")]
        public IList<TranscriptModel> Transcript { get; set; }
    }
}
