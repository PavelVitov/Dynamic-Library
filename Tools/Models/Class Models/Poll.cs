using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Enums.Class_Models;

namespace Tools.Models.Class_Models
{
    public class Poll : AcitvePoll
    {
        public Poll()
        {
            DateEnded = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime DateEnded { get; set; }
    }
}
