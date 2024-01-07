using Newtonsoft.Json;

namespace ControllerBot.Models;

public class Conversation
{
    [JsonProperty("response")]
    public Response Response { get; set; }
}

public class Response
{
    [JsonProperty("count")]
    public int Count { get; set; }
    [JsonProperty("profiles")]
    public Profiles[] Profiles { get; set; }
    [JsonProperty("items")]
    public Items[] Items { get; set; }
}

public class Profiles
{
    [JsonProperty("id")]
    public int Id { get; set; }
    [JsonProperty("sex")]
    public int Sex { get; set; }
    [JsonProperty("screen_name")]
    public string ScreenName { get; set; }
    [JsonProperty("photo_50")]
    public string Photo50 { get; set; }
    [JsonProperty("photo_100")]
    public string Photo100 { get; set; }
    [JsonProperty("online_info")]
    public OnlineInfo OnlineInfo { get; set; }
    [JsonProperty("online")]
    public int Online { get; set; }
    [JsonProperty("first_name")]
    public string FirstName { get; set; }
    [JsonProperty("last_name")]
    public string LastName { get; set; }
    [JsonProperty("can_access_closed")]
    public bool CanAccessClosed { get; set; }
    [JsonProperty("is_closed")]
    public bool IsClosed { get; set; }
}

public class OnlineInfo
{
    [JsonProperty("visible")]
    public bool Visible { get; set; }
    [JsonProperty("last_seen")]
    public int LastSeen { get; set; }
    [JsonProperty("is_online")]
    public bool IsOnline { get; set; }
    [JsonProperty("app_id")]
    public int AppId { get; set; }
    [JsonProperty("is_mobile")]
    public bool IsMobile { get; set; }
}

public class Items
{
    [JsonProperty("peer")]
    public Peer Peer { get; set; }
    [JsonProperty("last_message_id")]
    public int LastMessageId { get; set; }
    [JsonProperty("last_conversation_message_id")]
    public int LastConversationMessageId { get; set; }
    [JsonProperty("in_read")]
    public int InRead { get; set; }
    [JsonProperty("out_read")]
    public int OutRead { get; set; }
    [JsonProperty("version")]
    public int Version { get; set; }
    [JsonProperty("sort_id")]
    public Sort_id SortId { get; set; }
    [JsonProperty("in_read_cmid")]
    public int InReadCmid { get; set; }
    [JsonProperty("out_read_cmid")]
    public int OutReadCmid { get; set; }
    [JsonProperty("is_marked_unread")]
    public bool IsMarkedUnread { get; set; }
    [JsonProperty("important")]
    public bool Important { get; set; }
    [JsonProperty("unanswered")]
    public bool Unanswered { get; set; }
    [JsonProperty("can_write")]
    public CanWrite CanWrite { get; set; }
    [JsonProperty("peer_flags")]
    public int PeerFlags { get; set; }
}

public class Peer
{
    [JsonProperty("id")]
    public int Id { get; set; }
    [JsonProperty("type")]
    public string Type { get; set; }
    [JsonProperty("local_id")]
    public int LocalId { get; set; }
}

public class Sort_id
{
    [JsonProperty("major_id")]
    public int MajorId { get; set; }
    [JsonProperty("minor_id")]
    public int MinorId { get; set; }
}

public class CanWrite
{
    [JsonProperty("allowed")]
    public bool Allowed { get; set; }
}

