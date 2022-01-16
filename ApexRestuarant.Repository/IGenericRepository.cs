using System.Linq;

namespace ApexRestuarant.Repository
{
    public interface IGenericRepository<T>
    {
        RestuarantContext DbContext { get; set; }

        T Get(int id);

        IQueryable<T> Query();

        void Insert(T entity);

        void Update(T entity);

        void Delete(T entity);

    }
}