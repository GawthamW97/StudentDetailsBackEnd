using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Student
    {
        [Key]
        [Column(TypeName = "nvarchar(10)")]
        public string Code { get; set; }
        [Column(TypeName = "char(10)")]
        public string FirstName { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string LastName { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string DOB { get; set; }
        [Column(TypeName = "nvarchar(15)")]
        public string Username { get; set; }
        [Column(TypeName = "nvarchar(15)")]
        public string Password { get; set; }

    }
}
