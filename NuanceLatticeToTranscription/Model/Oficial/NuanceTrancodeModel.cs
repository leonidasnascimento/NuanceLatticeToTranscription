using Newtonsoft.Json;

namespace CCA.Transcription.Model
{
    public class NuanceTrancodeModel
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("operating_mode")]
        public string OperatingMode { get; set; }

        [JsonProperty("statistics")]
        public StatisticsModel Statistics { get; set; }

        [JsonProperty("channels")]
        public ChannelsModel Channels { get; set; }
    }
}
