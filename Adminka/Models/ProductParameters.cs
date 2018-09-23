using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adminka.Models
{
    public class ProductParameters
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool InStock { get; set; }
    }
}