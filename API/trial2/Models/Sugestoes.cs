﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace trial2.Models
{
    public class Sugestoes
    {
        [Key]
        public int identificacao { get; set; }
        public string nome { get; set; }
        public string sugestoes { get; set; }
        public string estado { get; set; }
        public string motivo { get; set; }
        public DateTime data { get; set; }
        public string user_email { get; set; }
        public string estadoU { get; set; }
    }
}
