using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Logistic_2;

namespace Logistic_2
{
    public class ProductsItems
    {
       
        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        public string NameOfItem { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "This field is required!")]
        public DateTime DateOfProduction { get;set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "This field is required!")]
        public DateTime BestBefore { get; set; }
        public int Amount { get; set; }
        public string TotalWeight { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        public string Category { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        public string Container { get; set; }
    }
}
