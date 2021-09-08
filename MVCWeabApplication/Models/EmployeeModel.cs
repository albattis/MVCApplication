using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCWeabApplication.Models
{
    public class EmployeeModel
    {
        [Display(Name ="Employee Id")]
        [Range(100000,999999,ErrorMessage ="You need to enter a valid EmployeeId")]
        public int EmployeeId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage ="You need to give us your First Name. ")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You need to give us your Last Name. ")]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "You need to give us your email address. ")]
        public string EmailAddress { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name ="Confirm Email")]
        [Compare("EmailAddress",ErrorMessage ="The email and confrim email must match")]
        public string ConfirmEmail { get; set; }

        [DataType(DataType.Password)]
        [StringLength(100,MinimumLength =10,ErrorMessage ="You need to provide a long enought password.")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="You password and Confirm password do not match")]
        public string ConfrimPassword { get; set; }
    }
}