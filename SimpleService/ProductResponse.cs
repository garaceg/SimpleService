using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleService
{
    public class ProductResponse
    {
        public Product? product { get; set; }
        public string? errorMessage { get; set; }
        public bool sucess { get; set; }        
    }

    

}
