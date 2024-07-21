﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_WPF_Lab9_Rental_Housing.Domain.Entities
{
    /// <summary>
    /// Photo class
    /// </summary>
    public class Photo
    {
        public int PhotoId { get; set; }
        public string PhotoName { get; set; }    
        
        public int ApartmentId { get; set; }
        public Apartment Apartment { get; set; }

        public override string ToString()
        {
            return $"Квартира ID:{Apartment.ApartmentId}, PhotoID: {PhotoId}";
        }
    }
}
