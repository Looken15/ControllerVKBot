using ControllerBot.Models;
using ControllerBot.VKAPI.Interfaces;

namespace ControllerBot.VKAPI;

public partial class VKAPI
{
    private readonly string _methodGetConversationById = "messages.getConversationsById";

    public async Task<Conversation> GetConversationsById(IEnumerable<int> peerIds)
    {
        var param = new Dictionary<string, string>
        {
            { "peer_ids", string.Join(',', peerIds.Select(x => x.ToString())) },
            { "extended", "1" }
        };
        var response = await Get<Conversation>(_methodGetConversationById, param);
        return response ?? null;
    }
}