using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LayUIDemo.Models
{
    public class ReJson<T>
    {
        public int code { set; get; }
        public int count { set; get; }
        public List<T> data { set; get; }
        public string msg { set; get; }
    }
}