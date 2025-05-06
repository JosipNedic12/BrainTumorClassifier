namespace BrainTumorClassifier.Models
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PredictionResult
    {
        [JsonPropertyName("predicted_label")]
        public string PredictedLabel { get; set; }

        [JsonPropertyName("scores")]
        public Dictionary<string, float> Scores { get; set; }
    }
}
