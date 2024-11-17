using System;

namespace ImportCrud.Models.Imports
{
    public class Import
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Cnpj { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public decimal TotalValue { get; set; }
        public bool Active { get; set; }
        public DateTime ProcessDate { get; set; }
        public DateTime EstimatedTimeDeparture { get; set; }
        public DateTime EstimatedTimeArrival { get; set; }
    }
}