﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeThiHuyen995_DATN.Models
{
    public class CommonAbstract
    {
        public string CreatedBy { get; set;}
        public DateTime CreatedDate {  get; set; }
        public DateTime ModifiedDate { get; set;}
        public string ModifiedBy { get; set; }

    }
}