using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }
        [Display(Name="Имя")]
        [StringLength(15)]
        [Required(ErrorMessage ="Длина имени не менее 5 символов")]
        public string name { get; set; }
        [Display(Name = "Фамилию")]
        [StringLength(15)]
        [Required(ErrorMessage = "Длина фамилии не менее 5 символов")]
        public string surname { get; set; }
        [Display(Name = "Адресс")]
        [StringLength(15)]
        [Required(ErrorMessage = "Длина адресса не менее 5 символов")]
        public string adress { get; set; }
        [Display(Name = "Телефон")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(15)]
        [Required(ErrorMessage = "Длина номера не менее 5 символов")]
        public string phone { get; set; }
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(15)]
        [Required(ErrorMessage = "Длина email не менее 5 символов")]
        public string email { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        [BindNever]
        public List<OrderDetail> orderDetail { get; set; }

    }
}
