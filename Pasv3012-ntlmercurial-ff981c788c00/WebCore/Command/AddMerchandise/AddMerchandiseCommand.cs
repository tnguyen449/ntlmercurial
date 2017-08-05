using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCore.Command
{
    public class AddMerchandiseCommand
    {
        public int Id { get; set; }
        public string MerchandiseId { get; set; }
        public Nullable<int> MerchandiseTypeId { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<int> Weight { get; set; }
        public Nullable<int> StatusCode { get; set; }
        public Nullable<bool> IsDeclare { get; set; }
        public string DeclareValue { get; set; }
        public Nullable<int> SpecialPrice { get; set; }
        public string Description { get; set; }
        public Nullable<int> SubTotal { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
