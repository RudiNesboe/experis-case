using System.ComponentModel.DataAnnotations;

namespace WebApi;

public class LotteryTicket
{
    [Key]
    public int Number { get; set; }
    public string? Owner { get; set; }
    public bool IsDrawn { get; set; }
}
