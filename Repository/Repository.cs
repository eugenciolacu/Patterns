using System;
using System.Collections.Generic;

namespace Repository
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        private List<T> _container;

        public Repository()
        {
            _container = new List<T>();
        }

        public void Create(T entity)
        {
            T tmp = GetById(entity.Id);

            if (tmp != null)
            {
                throw new Exception("Item with index " + entity.Id + " already exists");
            }

            _container.Add(entity);
        }

        public void Delete(T entity)
        {
            _container.Remove(entity);
        }

        public List<T> Get()
        {
            return _container;
        }

        public T GetById(long id)
        {
            return _container.Find(x => x.Id == id);
        }

        public void Update(T entity)
        {
            T tmp = GetById(entity.Id);

            if (tmp == null)
            {
                throw new Exception("No item with such index");
            }

            tmp = entity;
        }
    }
}
