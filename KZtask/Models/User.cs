using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace KZtask.Models
{
    public class User
    {
        [Required(ErrorMessage = "Имя пользователя не должно быть пустым")]
        [Display(Name ="Введите имя пользователя")]
        public string Id { get; set; }
        [Required(ErrorMessage = "Пароль не должен быть пустым")]
        [Display(Name = "Введите пароль")]
        public string Password { get; set; }

    }
}
