using System.Text.Json.Serialization;

namespace ControllerBot.Models;

public class Message
{
    [JsonPropertyName("type")]
    public string Type { get; set; }
    [JsonPropertyName("event_id")]
    public string EventId { get; set; }
    [JsonPropertyName("v")]
    public string Version { get; set; }
    [JsonPropertyName("object")]
    public object Object { get; set; }
    [JsonPropertyName("group_id")]
    public int GroupId { get; set; }
}