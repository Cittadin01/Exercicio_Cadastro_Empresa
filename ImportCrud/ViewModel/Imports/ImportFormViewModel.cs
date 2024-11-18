using System;
using System.ComponentModel.DataAnnotations;

namespace ImportCrud.ViewModel.Imports
{
    public class ImportFormViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        [Required]
        [StringLength(100)]
        public string Company { get; set; }

        [Required]
        [StringLength(100)]
        public string Origin { get; set; }

        [Required]
        [StringLength(100)]
        public string Destination { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Total value must be a positive number.")]
        public decimal TotalValue { get; set; }

        public bool Active { get; set; }

        [Required]
        [Display(Name = "Process Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ProcessDate { get; set; }

        [Required]
        [Display(Name = "Estimated Time of Departure")]
        [DataType(DataType.DateTime)]
        public DateTime EstimatedTimeDeparture { get; set; }

        [Required]
        [Display(Name = "Estimated Time of Arrival")]
        [DataType(DataType.DateTime)]
        public DateTime EstimatedTimeArrival { get; set; }
    }

}