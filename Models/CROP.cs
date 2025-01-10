using System.Text.Json.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace CallSummarizerDemoUI.Models;

public class CROP
{
    [JsonPropertyName("type")]
    public CROPType? Type { get; set; }
    
    [JsonPropertyName("trigger")]
    public string? Trigger { get; set; }
    
    [JsonPropertyName("recommendation")]
    public string? Recommendation { get; set; }
    
    [JsonPropertyName("evidence")] 
    public List<string>? Evidence { get; set; }
    
    [JsonPropertyName("policyNumberReference")]
    public string? PolicyNumberReference { get; set; }
    
    [JsonPropertyName("originalAnalysis")]
    public Guid OriginalAnalysis { get; set; }
}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum CROPType
{
    CustomerRetentionRisk,
    CustomerProductEducation,
    DocumentationNeeded, 
    PaymentIssue,
    UpdateRequired,
    CSRTrainingNeeded,
    PossibleMaliciousActivity,
    None

}
