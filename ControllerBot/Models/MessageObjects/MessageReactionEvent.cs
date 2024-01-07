using Newtonsoft.Json;

namespace ControllerBot.Models.MessageObjects;

public class MessageReactionEvent
{
    [JsonProperty("reacted_id")]
    public int ReactedId { get; set; }
    [JsonProperty("peer_id")]
    public int PeerId { get; set; }
    [JsonProperty("cmid")]
    public int CMID { get; set; }
    [JsonProperty("reaction_id")]
    public int ReactionId { get; set; }
}

