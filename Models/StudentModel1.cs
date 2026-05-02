using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCFirst.Models
{
    public class StudentModel1
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        [StringLength(100)]
        public string StudentName { get; set; }
        [Range(1, 100)]
        public int Age { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }

    }
}