using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Enums.Class_Models;
using Tools.Interfaces.IClass_Models;

namespace Tools.Models.Class_Models
{
    public class Admin : User, IAdmin
    {
        public Admin()
        {
            
        }
        public Guid Id { get; set; }
        public AdminLevel Level { get; set; }
        public bool IsDisabled { get; set; }
    }
}
