﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace venditiun.Models
{
    public class Position
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public bool Active { get; set; }
    }
}
