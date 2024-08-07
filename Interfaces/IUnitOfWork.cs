using CS_WPF_Lab9_Rental_Housing.Domain.Entities;
using System.Linq.Expressions;

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

        void LoadRelatedEntities<T, TProperty>(T entity, Expression<Func<T, IEnumerable<TProperty>>> navigationProperty)
          where T : class
          where TProperty : class;
    }
}
