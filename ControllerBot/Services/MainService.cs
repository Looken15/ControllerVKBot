using ControllerBot.Models;
using ControllerBot.Models.MessageObjects;
using ControllerBot.Services.Interfaces;
using ControllerBot.VKAPI.Interfaces;
using Newtonsoft.Json;

namespace ControllerBot.Services;

public class MainService : IMainService
{
    private readonly IVKAPI vkapi;

    private const string _okMessage = "ok";
    private const string _confirmationMessage = "613d8912";

    public MainService(IVKAPI _vkapi)
    {
        vkapi = _vkapi;
    }

    public async Task<string> Parse(Message message)
    {
        if (message.Type == MessageType.Confirmation)
        {
            return _confirmationMessage;
        }

        if (message.Type == MessageType.MessageNew)
        {
            var messageObject = JsonConvert.DeserializeObject<MessageNew>(message.Object.ToString());
            if (messageObject is null)
            {
                Console.WriteLine("Произошла ошибка!");
                return _okMessage;
            }

            var conversation = await vkapi.GetConversationsById(new List<int> { messageObject.Message.PeerId });
            var userIds = conversation.Response.Profiles.Select(p => p.ScreenName);
            var users = await vkapi.GetUsers(userIds);

            Console.WriteLine($"Текст нового сообщения - {messageObject.Message.Text}");
        }

        if (message.Type == MessageType.MessageReactionEvent)
        {
            var messageObject = JsonConvert.DeserializeObject<MessageReactionEvent>(message.Object.ToString());
            if (messageObject is null)
            {
                Console.WriteLine("Произошла ошибка!");
                return _okMessage;
            }

            if (messageObject.ReactionId == 0)
            {
                return _okMessage;
            }

            await vkapi.DeleteReaction(messageObject.PeerId, messageObject.CMID);
        }

        return _okMessage;
    }
}