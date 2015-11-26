using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace nandoso.Models
{
    public class Specials
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int specialsID { get; set; }
        public string productName { get; set; }
        public double price { get; set; }
    }
}