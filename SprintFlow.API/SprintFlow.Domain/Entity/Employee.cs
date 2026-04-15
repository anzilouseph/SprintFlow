using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprintFlow.Domain.Entity
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public long RoleId { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreatedBy { get; set; }
        public string Designation { get; set; }
        public int Age { get; set; }
        public string Mobile { get; set; }  
        public string Email { get; set; }
        public bool IsDeleted { get; set; } 

    }
}
