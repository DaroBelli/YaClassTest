using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Task10.Conrollers;
using Task10.Models;

namespace Task10.Pages
{
    [IgnoreAntiforgeryToken]
    public class IndexModel : PageModel
    {
        public DepositModel? DepositModel { get; set; }
        public string Message { get; set; } = string.Empty;

        public void OnPost(DepositModel depositModel) 
        {
            if (ModelState.IsValid)
            {
                Message = $"Конечная сумма составит: {Deposit.GetDepositFromProcent(decimal.Parse(depositModel.Deposit), depositModel.MonthCount)}";
            }
            else Message = "Значение введено не корректно!";
        }

        public void OnGet()
        {
        }
    }
}
