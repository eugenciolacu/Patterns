using System.Collections.Generic;

namespace Repository
{
    public interface IRepository<T> where T : EntityBase
    {
        void Create(T entity);

        void Delete(T entity);

        List<T> Get();

        T GetById(long id);

        void Update(T entity);
    }
}
