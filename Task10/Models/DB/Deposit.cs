using System.ComponentModel.DataAnnotations;

namespace Task10.Models.DB;

public partial class Deposit
{
    public decimal InitialDeposit { get; set; }

    [Key]
    public int Id { get; set; }

    public int MonthCount { get; set; }
}
