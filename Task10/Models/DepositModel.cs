using System.ComponentModel.DataAnnotations;

namespace Task10.Models
{
    public class DepositModel
    {
        [Display(Name = "Вклад:")]
        [Required(ErrorMessage = "Введённое значени не явлется вкладом!")]
        [RegularExpression(@"^[0-9]+(\,[0-9]{1,2})$", ErrorMessage = "У вклада не может быть больше двух цифр после запятой!")]
        public string Deposit {  get; set; } = string.Empty;

        public int MonthCount { get; set; }
    }
}
