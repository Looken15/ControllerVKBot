using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ControllerBot.Models;

public static class MessageType
{
    public static string Confirmation { get; } = "confirmation";
    public static string MessageRead { get; } = "message_read";
    public static string MessageNew { get; } = "message_new";
    public static string MessageAllow { get; } = "message_allow";

    public static string MessageReactionEvent { get; } = "message_reaction_event";
}