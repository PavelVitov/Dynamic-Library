using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Enums.Class_Models;

namespace Tools.Models.Class_Models
{
    public class AcitvePoll
    {
        public AcitvePoll()
        {
            CreateDate = DateTime.Now;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public List<Choice> Choices { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public bool IsPrivate { get; set; }
        public bool IsActive { get; set; }
        public bool IsAccessible { get; set; }
        public Gene Gene { get; set; }
    }
}
