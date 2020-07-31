using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestMVC.Models
{
    public class Model1
    {
        public int Id { get; set; }
        public string UserEmail { get; set; }
        public DateTime Created { get; set; }
        public string ImageURL { get; set; }
        public List<string> Images { get; set; }

    }
}