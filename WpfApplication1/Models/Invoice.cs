﻿using System.ComponentModel.DataAnnotations;

namespace LPLSystems.Models
{
    public class Invoice
    {
        [Key]
        public int invoiceID { get; set; }

        [Required]
        public int organizationID { get; set; }

        [Required]
        public string pickupLocation { get; set; }

        [Required]
        public string dropoffLocation { get; set; }

        [Range(0, 12)]
        public int employeeID { get; set; }

        [Required]
        public string currency;

        [Required]
        public float invoiceRate;
    }
}
