using System;
using System.Collections.Generic;

namespace Repository
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Repository pattern implements separation of concerns by abstracting the data persistence logic in your applications");
            Console.WriteLine();

            Repository<SomeConcreteEntity> repository = new Repository<SomeConcreteEntity>();

            SomeConcreteEntity entity1 = new SomeConcreteEntity { Id = 0, Name = "Some name 1" };
            SomeConcreteEntity entity2 = new SomeConcreteEntity { Id = 1, Name = "Some name 2" };

            repository.Create(entity1);
            repository.Create(entity2);

            PrintSomeConcreteEntities(repository.Get());

            entity1.Name = "Other name";
            repository.Update(entity1);

            PrintSomeConcreteEntities(repository.Get());

            repository.Delete(entity1);

            PrintSomeConcreteEntities(repository.Get());

            SomeConcreteEntity entity = repository.GetById(1);
            Console.WriteLine($"{entity.Id}\t{entity.Name}\n");
        }

        private static void PrintSomeConcreteEntities(List<SomeConcreteEntity> container)
        {
            string str = string.Empty;

            foreach (SomeConcreteEntity item in container)
            {
                str += $"{item.Id}\t{item.Name}\n";
            }

            Console.WriteLine(str);
        }
    }
}
