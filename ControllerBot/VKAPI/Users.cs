namespace ControllerBot.VKAPI;

public partial class VKAPI
{
    private readonly string _methodUsersGet = "users.get";

    public async Task<string> GetUsers(IEnumerable<string> userIds)
    {
        var param = new Dictionary<string, string>
        {
            { "user_ids", string.Join(',', userIds) }
        };
        var response = await Get<string>(_methodUsersGet, param);
        return response ?? null;
    }
}