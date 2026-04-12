using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprintFlow.Domain.Entity
{
    [Table ("TaskItem")]
    public class TaskItem
    {
        public long Id { get; set; }
        public long TaskId {  get; set; }
        public string Description { get; set; }
        public decimal EstimateTime { get; set; }
        public long StatusId {  get; set; }
        public bool IsDeleted { get; set; }
    }
}
