using System;

namespace Domain.ViewModels
{
    public class CustomerVM
    {      
        public string SenderName { get; set; }
        public string SenderPhone { get; set; }
        public SelectedLocation BolFromName { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverPhone { get; set; }
        public SelectedLocation BolToName { get; set; }
        public string CreatedBy { get; set; }
    }
    public class SelectedLocation
    {
        public Location selected { get;set; } 
    }
    public class Location
    {
        public string Address { get; set; }
        public string BranchCode { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Id { get; set; }
        public int Type { get; set; }
    }


}