using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprintFlow.Domain.Entity
{
    [Table("Task")]
    public class Task
    {
        [Key]
        public long Id { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }
        public decimal EstimateTime { get; set; }   
        public long StatusId { get; set; }
        public long Assingee { get; set; } //the employee who asigned the  task(fk )
        public long AssingedTo { get; set; }    //  ,,       aggined to(fk)
        public bool IsDeleted { get; set; }
    }
}
