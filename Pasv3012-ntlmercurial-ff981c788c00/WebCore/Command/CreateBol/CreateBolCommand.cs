using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCore.Command
{
    public class CreateBolCommand
    {
        public int Id { get; set; }
        public string BolCode { get; set; }
        public Nullable<int> DeliveryType { get; set; }
        public Nullable<bool> isDiscount { get; set; }
        public Nullable<bool> isGuarantee { get; set; }
        public Nullable<int> StatusCode { get; set; }
        public string Description { get; set; }
        public string Prepaid { get; set; }
        public Nullable<int> PrepaidTemp { get; set; }
        public Nullable<int> Liabilities { get; set; }
        public Nullable<System.DateTime> ReceiveDate { get; set; }
        public Nullable<System.DateTime> ReceiveTime { get; set; }
        public Nullable<System.DateTime> SendDate { get; set; }
        public string SendAddress { get; set; }
        public Nullable<int> Total { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public Nullable<int> BolFromId { get; set; }
        public Nullable<int> BolToId { get; set; }
        public Nullable<int> AdditionalFee { get; set; }
    }
}
