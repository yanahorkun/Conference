using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;


namespace Conferense.Models
{
    public class IndexViewModel
    {
        public bool HasPassword { get; set; }
        public IList<UserLoginInfo> Logins { get; set; }
        public string PhoneNumber { get; set; }
        public bool TwoFactor { get; set; }
        public bool BrowserRemembered { get; set; }
        public string Status { get; set; }
    }


    public class ManageLoginsViewModel
    {
        public IList<UserLoginInfo> CurrentLogins { get; set; }
        public IList<AuthenticationDescription> OtherLogins { get; set; }
    }

    public class FactorViewModel
    {
        public string Purpose { get; set; }
    }

    public class SetPasswordViewModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "Значення {0} повинно вміщати більше: {2}.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Новий пароль")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Підтвердження нового пароля")]
        [Compare("NewPassword", ErrorMessage = "Новий пароль і його підтвердження не співпадають.")]
        public string ConfirmPassword { get; set; }
    }

    public class SetFileViewModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        [Display(Name = "Виберіть файл")]
        [Required(ErrorMessage = "Не вірний формат файлу. Приймаються файли типу .doc та .txt")]
        public HttpPostedFileBase File { get; set; }
    }

    public class SetInfoViewModel 
    {
        [Display(Name = "Колонка данных 1")]
        public string data1 { get; set; }
        [Display(Name = "Колонка данных 1")]
        public string data2 { get; set; }
        [Display(Name = "Колонка данных 1")]
        public string data3 { get; set; }
        [Display(Name = "Колонка данных 1")]
        public string data4 { get; set; }
        [Display(Name = "Колонка данных 1")]
        public string data5 { get; set; }
    }

    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Поточний пароль")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Значение {0} должно содержать символов не менее: {2}.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Новий пароль")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Підтверждення нового пароля")]
        [Compare("NewPassword", ErrorMessage = "Новий пароль і його підтвердження не співпадають.")]
        public string ConfirmPassword { get; set; }
    }

    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Номер телефона")]
        public string Number { get; set; }
    }

    public class VerifyPhoneNumberViewModel
    {
        [Required]
        [Display(Name = "Код")]
        public string Code { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Номер телефона")]
        public string PhoneNumber { get; set; }
    }

    public class ConfigureTwoFactorViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
    }
}