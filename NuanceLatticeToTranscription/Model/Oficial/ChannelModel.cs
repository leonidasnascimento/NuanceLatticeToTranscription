using Newtonsoft.Json;

namespace CCA.Transcription.Model
{
    public class ChannelsModel
    {
        [JsonProperty("firstChannelLabel")]
        public FirstChannelLabelModel FirstChannelLabel { get; set; }
    }
}
