using ControllerBot.Models;

namespace ControllerBot.Services.Interfaces;

public interface IMainService
{ 
    Task<string> Parse(Message message);
}