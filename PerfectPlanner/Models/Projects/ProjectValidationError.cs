﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectPlanner.Models.Projects
{
    class ProjectValidationError
    {
        public string message { get; set; }
        public Dictionary<String, List<String>> errors { get; set; }
    }
}
