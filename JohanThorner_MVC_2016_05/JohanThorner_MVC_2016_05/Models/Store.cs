using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Newtonsoft.Json.Serialization;

namespace JohanThorner_MVC_2016_05.Models
{
    public class Store
    {
        public int StoreId { get; set; }
        [StringLength(40,ErrorMessage = "Högst 40 tecken")]
        public string Name { get; set; }
        [StringLength(150, ErrorMessage = "Högst 150 tecken")]
        public string Address { get; set; }
        public List<Product> Products { get; set; }
    }
    
}