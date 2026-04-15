using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprintFlow.Domain.Entity
{
    [Table ("Role")]
    public class Role
    {
        [Key]
        public long Id { get; set; }
        public string RoleName { get; set; }    
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
    }
}
