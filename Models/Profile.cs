using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CentricTeam9MIS4200.Models
{
    public class Profile
    {
        public int profileID { get; set; }
        [Display(Name = "First Name")]
        [Required]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        public string lastName { get; set; }
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        [Required]
        public string email { get; set; }
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [Required]
        public string phone { get; set; }
        [Display(Name = "Office")]
        [Required]
        public string office { get; set; }
        [Display(Name = "Role")]
        [Required]
        public string role { get; set; }
        [Display(Name = "Date Hired")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime dateHired { get; set; }

    }
}