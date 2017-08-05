using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domain.ViewModels
{
    public class MerchandiseVM
    {
        public int  Id { get; set; }
        public string MerchandiseId { get; set; }
        public MerchandiseTypeVM merchandiseType { get; set; }
        public string quantity { get; set; }
        public string weight { get; set; }
        public bool isDeclared { get; set; }
        public string declareValue { get; set; }
        public string specialPrice { get; set; }
        public string description { get; set; }
        public int subTotal { get; set; }
      
    }
    
}