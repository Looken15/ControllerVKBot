using ControllerBot.Models;
using ControllerBot.Models.MessageObjects;
using ControllerBot.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ControllerBot.Controllers;

[ApiController]
[Route("[controller]")]
public class MainController : ControllerBase
{
    private readonly IMainService mainService;
    public MainController(IMainService _mainService)
    {
        mainService = _mainService;
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Message message)
    {
        Console.WriteLine($"{DateTime.Now.ToString()} {JsonConvert.SerializeObject(message)}");
        var parseResult = await mainService.Parse(message);
        return Ok(parseResult);
    }
}