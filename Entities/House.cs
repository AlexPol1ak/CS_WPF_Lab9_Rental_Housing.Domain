namespace CS_WPF_Lab9_Rental_Housing.Domain.Entities
{
    /// <summary>
    /// Model table Houses
    /// </summary>
    public class House
    {
        public int HouseId { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public int? Block { get; set; } = null;
        public int CountFloors { get; set; }
        public bool HasElevator { get; set; } = false;
        public int BuildingYear { get; set; }
        public ICollection<Apartment> Apartments { get; set; }

        public House() { }

        public override string ToString()
        {
            return $"{City}, {Street}, {Number}";
        }

        public string ToString(bool full)
        {
            if (full == false) return ToString();
            string info = $"Город: {City}\n" +
                $"Улица: {Street}\n" +
                $"Дом: {Number} \n" +
                $"Корпус: {(Block != null ? Block : "Нет")}\n" +
                $"Количество этажей: {CountFloors}\n" +
                $"Лифт: {(HasElevator == true ? "Да" : "Нет")}\n" +
                $"Год постройки: {BuildingYear}\n";
            return info;
        }
    }
}
