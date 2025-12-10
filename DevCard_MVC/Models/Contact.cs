using System.ComponentModel.DataAnnotations;

namespace DevCard_MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage ="این فیلد اجباری است")]
        [MinLength(2, ErrorMessage ="حداقل طول نام 2 است")]
        [MaxLength(100,ErrorMessage ="حداکثر طول نام 100 است")]
        public string Name { get; set; }
        [Required(ErrorMessage = "این فیلد اجباری است")]
        [EmailAddress(ErrorMessage ="مقدار وارد شده ایمیل صحیح نیست")]
        public string Email { get; set; }
        public string Message   { get; set; }
        public string Service { get; set; }
    }
}
