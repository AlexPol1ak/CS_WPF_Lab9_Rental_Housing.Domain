using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_WPF_Lab9_Rental_Housing.Domain.Entities
{
    /// <summary>
    /// Apartment class
    /// </summary>
    public class Apartment
    {
        public int ApartmentId {  get; set; }
        public int Number { get; set; }
        public int Floor { get; set; }
        public int CountRooms {  get; set; }
        public double Area {  get; set; }
        public string? Owner { get; set; } = null;
        public ulong? OwnerTel { get; set; } = null;
        public double? Price { get; set; } = null;
        
        public ICollection<Photo> Photos { get; set; }
        public int HouseId {  get; set; }
        public House House { get; set; }

        public override string ToString()
        {
            return $"{House.City}, ул. {House.Street}, дом {House.Number}, " +
                $"Кв. {Number}, Площадь {Area} кв.м. " +
                $"Стоимость: {Price?.ToString() ?? "-"}/мес.\n" +
                $"Владелец: {Owner?.ToString() ?? "-"}";
        }
    }
}
