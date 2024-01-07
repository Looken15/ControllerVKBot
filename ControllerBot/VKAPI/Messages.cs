namespace ControllerBot.VKAPI;

public partial class VKAPI
{
    private readonly string _methodDeleteReaction = "messages.deleteReaction";

    public async Task DeleteReaction(int peerId, int cmid)
    {
        var param = new Dictionary<string, string>
        {
            { "peer_id", peerId.ToString() },
            { "cmid", cmid.ToString() }
        };
        await Get(_methodDeleteReaction, param);
    }
}