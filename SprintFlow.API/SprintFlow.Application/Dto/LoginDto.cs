using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprintFlow.Application.Dto
{
    public class LoginDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string IsDeleted { get; set; }
        public long RoleId { get; set; }    
    }
}
