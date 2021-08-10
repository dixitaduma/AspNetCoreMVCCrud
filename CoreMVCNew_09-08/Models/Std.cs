using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCNew_09_08.Models
{
    [Table("Student")]
    public class Student
    {
        [Key()]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public string Email { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "age must be between 1 and 100")]
        public int Age { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Phone { get; set; }
    }

    public class StdContext : DbContext
    {
        public StdContext(DbContextOptions<StdContext> options) : base(options)
        {
        }
        public virtual DbSet<Student> Students { get; set; }
    }

}
