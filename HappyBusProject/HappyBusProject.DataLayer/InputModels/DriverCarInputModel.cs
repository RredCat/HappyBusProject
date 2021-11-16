﻿using System;
using System.ComponentModel.DataAnnotations;

namespace HappyBusProject.ModelsToReturn
{
    public class DriverCarInputModel
    {
        [Required]
        public string DriverName { get; set; }
        [Required]
        public int DriverAge { get; set; }
        public DateTime MedicalExamPassDate { get; set; }
        [Required]
        public string CarBrand { get; set; }
        [Required]
        public int CarAge { get; set; }
        [Required]
        public int SeatsNum { get; set; }
        [Required]
        public string RegistrationNumPlate { get; set; }
    }
}
