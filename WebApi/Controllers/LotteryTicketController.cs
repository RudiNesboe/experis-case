using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class LotteryTicketController : ControllerBase
{
    private readonly ILogger<LotteryTicketController> _logger;

    public LotteryTicketController(ILogger<LotteryTicketController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetLotteryTickets")]
    public IEnumerable<LotteryTicket> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new LotteryTicket
        {
            Number = index,
            Owner = null,
            IsDrawn = false
        })
        .ToArray();
    }
}
