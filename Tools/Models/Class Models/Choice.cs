﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Models.Class_Models
{
    public class Choice
    {
        public Choice()
        {
            
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int PollId { get; set; }
        public Poll Poll { get; set; }

    }
}
