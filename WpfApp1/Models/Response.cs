﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public class Response
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public int IdUser { get; set; }
        public int IdProposal { get; set; }
        public int IdRieltor { get; set; }
    }
}
