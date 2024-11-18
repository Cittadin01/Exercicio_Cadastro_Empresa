using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImportCrud.ViewModel.Imports
{
    public class ImportDetailsViewModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Company { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public decimal TotalValue { get; set; }
        public bool Active { get; set; }
        public DateTime ProcessDate { get; set; }
        public DateTime EstimatedTimeDeparture { get; set; }
        public DateTime EstimatedTimeArrival { get; set; }
    }
}