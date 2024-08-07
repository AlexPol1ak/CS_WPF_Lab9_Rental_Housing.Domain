namespace CS_WPF_Lab9_Rental_Housing.Domain.Entities
{
    /// <summary>
    /// Model table Photos
    /// </summary>
    public class Photo
    {
        public int PhotoId { get; set; }
        public string PhotoName { get; set; }

        public int ApartmentId { get; set; }
        public Apartment Apartment { get; set; }

        public Photo() { }

        public override string ToString()
        {
            return $"Квартира ID:{Apartment?.ApartmentId}, PhotoID: {PhotoId.ToString()}, " +
                $"Name: {PhotoName.ToString()}";
        }
    }
}
