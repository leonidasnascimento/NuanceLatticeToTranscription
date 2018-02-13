using Newtonsoft.Json;
using System.Collections.Generic;

namespace CCA.Transcription.Model
{
    public class StatisticsModel
    {
        [JsonProperty("request_processing_time")]
        public int RequestProcessingTime { get; set; }

        [JsonProperty("content_fetch_time")]
        public object ContentFetchTime { get; set; }

        [JsonProperty("job_preparation_time")]
        public int JobPreparationTime { get; set; }

        [JsonProperty("audio_length")]
        public float AudioLength { get; set; }

        [JsonProperty("audio_analysis_time")]
        public int AudioAnalysisTime { get; set; }

        [JsonProperty("segmentation_time")]
        public int SegmentationTime { get; set; }

        [JsonProperty("transcription_time")]
        public int TranscriptionTime { get; set; }

        [JsonProperty("diarization_time")]
        public int DiarizationTime { get; set; }

        [JsonProperty("merge_time")]
        public int MergeTime { get; set; }

        [JsonProperty("formatting_time")]
        public int FormattingTime { get; set; }
    }
}
