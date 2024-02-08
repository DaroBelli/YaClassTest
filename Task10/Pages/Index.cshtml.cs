using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Task10.Conrollers;
using Task10.Contexts;
using Task10.Models;
using Task10.Models.DB;

namespace Task10.Pages
{
    [IgnoreAntiforgeryToken]
    public class IndexModel(YaClassTestContext db) : PageModel
    {
        private readonly YaClassTestContext context = db;
        public DepositModel? DepositModel { get; set; }
        public string Message { get; set; } = string.Empty;

        public async Task OnPost(DepositModel depositModel) 
        {
            if (ModelState.IsValid)
            {
                decimal deposit = decimal.Parse(depositModel.Deposit);
                Message = $"Конечная сумма составит: {DepositController.GetDepositFromProcent(deposit, depositModel.MonthCount)}";

                await context.Deposits.AddAsync(new Deposit { InitialDeposit = deposit , MonthCount = depositModel.MonthCount});
                await context.SaveChangesAsync();
            }
            else Message = "Значение введено не корректно!";
        }

        public void OnGet()
        {
        }
    }
}
