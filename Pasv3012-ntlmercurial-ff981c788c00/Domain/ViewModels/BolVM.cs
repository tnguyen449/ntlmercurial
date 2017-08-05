using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domain.ViewModels
{
    public class BolVM
    {
        public int Id { get; set; }
        public string additionalFee { get; set; }
        public string bolCode { get; set; }
        public string collectInBehalf { get; set; }
        public DeliveryTypeVM deliveryType { get; set; }
        public bool isDiscount { get; set; }
        public bool isGuarantee { get; set; }
        public int liabilities { get; set; }
        public string prepaid { get; set; }
        public int prepaidTemp { get; set; }
        public string receiveDate { get; set; }
        public string receiveTime { get; set; }
        public string sendAddress { get; set; }
        public string sendDate { get; set; }
        public int statusCode { get; set; }
        public int total { get; set; }

    }
}