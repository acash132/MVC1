using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCFirst.Models
{
    public class EmployeeModel
    {

        [Key]
        public int EmployeeId { get; set; }
        [Required]
        [StringLength(100)]
        public string EmployeeName { get; set; }
        [Range(1, 100)]
        public int Age { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        public DateTime DOB{ get; set; }
    }
}