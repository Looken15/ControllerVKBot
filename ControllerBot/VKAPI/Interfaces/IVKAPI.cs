using ControllerBot.Models;

namespace ControllerBot.VKAPI.Interfaces;

public interface IVKAPI
{
    string GetToken();

    Task<Conversation> GetConversationsById(IEnumerable<int> peerIds);

    Task<string> GetUsers(IEnumerable<string> userIds);

    Task DeleteReaction(int peerId, int cmid);
}