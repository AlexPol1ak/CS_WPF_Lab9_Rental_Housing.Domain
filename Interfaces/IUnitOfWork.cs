using CS_WPF_Lab9_Rental_Housing.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_WPF_Lab9_Rental_Housing.Domain.Interfaces
{
    /// <summary>
    /// Provides access to repositories
    /// </summary>
    public interface IUnitOfWork
    {
        IRepository<House> HousesRepository { get; }
        IRepository<Apartment> ApartmentsRepository { get; }
        IRepository<Photo> PhotosRepository { get; }

        void SaveChanges();
    }
}
