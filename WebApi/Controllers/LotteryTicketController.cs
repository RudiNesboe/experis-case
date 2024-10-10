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

    [HttpGet("LotteryTickets")]
    public IEnumerable<LotteryTicket> GetLotteryTickets()
    {
        return Enumerable.Range(1, 100).Select(index => new LotteryTicket
        {
            Number = index,
            Owner = null,
            IsDrawn = false
        })
        .ToArray();
    }

    [HttpPost("LotteryTickets/{number}/buy")]
    public LotteryTicket BuyLotteryTicket(int number)
    {
        //Set owner on ticket with given number if available
        return new LotteryTicket()
        {
            Number = number,
            Owner = null,
            IsDrawn = false
        };
    }

    [HttpPost("LotteryTickets/draw")]
    public LotteryTicket DrawLotteryTicket()
    {
        // Get random ticket that is not drawn and return 
        return new LotteryTicket()
        {
            Number = 7,
            Owner = null,
            IsDrawn = false
        };
    }
}
