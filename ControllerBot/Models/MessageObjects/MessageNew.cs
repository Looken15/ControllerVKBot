using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace ControllerBot.Models.MessageObjects;

public class MessageNew
{
    [JsonProperty("message")]
    public MessageNewHolder Message { get; set; }
}

public class MessageNewHolder
{
    [JsonProperty("date")]
    public int Date { get; set; }
    [JsonProperty("from_id")]
    public int FromId { get; set; }
    [JsonProperty("id")]
    public int Id { get; set; }
    [JsonProperty("out")]
    public int Out { get; set; }
    [JsonProperty("version")]
    public int Version { get; set; }
    
    [JsonProperty("attachments")]
    public IEnumerable<object> Attachments { get; set; }
    
    [JsonProperty("conversation_message_id")]
    public int ConversationMessageId { get; set; }
    
    [JsonProperty("fwd_messages")]
    public IEnumerable<object> ForwardMessages { get; set; }
    
    [JsonProperty("reply_message")]
    public ReplyMessage ReplyMessage { get; set; }
    
    [JsonProperty("important")]
    public bool Important { get; set; }
    [JsonProperty("is_hidden")]
    public bool IsHidden { get; set; }
    [JsonProperty("peer_id")]
    public int PeerId { get; set; }
    [JsonProperty("random_id")]
    public int RandomId { get; set; }
    [JsonProperty("text")]
    public string Text { get; set; }
    [JsonProperty("is_unavailable")]
    public bool IsUnavailable { get; set; }
}

public class ReplyMessage
{
    [JsonProperty("date")]
    public int Date { get; set; }
    [JsonProperty("from_id")]
    public int FromId { get; set; }
    [JsonProperty("text")]
    public string Text { get; set; }
    [JsonProperty("attachments")]
    public IEnumerable<object> Attachments { get; set; }
    [JsonProperty("conversation_message_id")]
    public int ConversationMessageId { get; set; }
    [JsonProperty("id")]
    public int Id { get; set; }
    [JsonProperty("peer_id")]
    public int PeerId { get; set; }
}