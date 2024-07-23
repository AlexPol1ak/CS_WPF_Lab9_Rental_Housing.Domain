using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_WPF_Lab9_Rental_Housing.Domain.Entities
{
    /// <summary>
    /// Model table Houses
    /// </summary>
    public class House
    {
        public House() { }

        public int HouseId { get; set; }
        public string City { get; set; }
        public string Street {  get; set; }
        public int Number {  get; set; }
        public int? Block { get; set; } = null;
        public int CountFloors {  get; set; }
        public bool HasElevator { get; set; } = false;
        public int BuildingYear { get; set; }
        public ICollection<Apartment> Apartments { get; set; }

        public override string ToString()
        {
            return $"{City}, {Street}, {Number}";
        }
    }
}
