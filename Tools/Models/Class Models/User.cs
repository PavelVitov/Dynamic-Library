using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Interfaces.IClass_Models;

namespace Tools.Models.Class_Models
{
    public class User : IUser
    {
        public User()
        {
            CreatedOn = DateTime.Now;
        }
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<int> PollsId { get; set; }
        public List<Poll> Polls { get; set; }
        public List<int> ActivePollsId { get; set; }
        public List<AcitvePoll> ActivePolls { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsDisabled { get; set; }
       
    }
}
