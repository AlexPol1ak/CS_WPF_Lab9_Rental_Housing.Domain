using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace CS_WPF_Lab9_Rental_Housing.Domain.Entities
{
    /// <summary>
    /// Model table Apartments
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
        public int HouseId { get; set; }
        public House House { get; set; }

        public Apartment() { }

        public override string ToString()
        {
            return $"{House.City}, ул. {House.Street}, дом {House.Number}, " +
                $"Кв. {Number}, Площадь {Area} кв.м. " +
                $"Стоимость: {Price?.ToString() ?? "-"}/мес.\n" +
                $"Владелец: {Owner?.ToString() ?? "-"}";
        }

        public string ToString(bool full = false)
        {
            if (full == false) return ToString();

            string info = $"Город: {House.City}\n" +
               $"Улица: {House.Street}\n" +
               $"Номер дома: {House.Number} \n" +
               $"Корпус: {(House.Block != null ? House.Block : "Нет")}\n" +
               $"Количество этажей: {House.CountFloors}\n" +
               $"Лифт: {(House.HasElevator == true ? "Да" : "Нет")}\n" +
               $"Год постройки: {House.BuildingYear}\n" +
               $"Номер квартиры: {this.Number}\n" +
               $"Этаж: {Floor}\n" +
               $"Количество комнат: {CountRooms}\n" +
               $"Площадь: {Area} кв.м.\n" +
               $"Владелец: {(Owner != null ? Owner : "-")}\n" +
               $"Номер владельца: {(OwnerTel != null ? OwnerTel.ToString() : "-")}\n" +
               $"Цена: {(Price == null ? "-" : $"${Price}")}\n";

            return info;
        }
    }
}
