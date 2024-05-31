
/*
3. Implement a GenericRepository<T> class that implements IRepository<T> interface
that will have common /CRUD/ operations so that it can work with any data source
such as SQL Server, Oracle, In-Memory Data etc. Make sure you have a type constraint
on T were it should be of reference type and can be of type Entity which has one
property called Id. IRepository<T> should have following methods
1. void Add(T item)
2. void Remove(T item)
3. Void Save()
4. IEnumerable<T> GetAll()
5. T GetById(int id)

*/

// public abstract class Entity
// {
//     public int Id { get; set; }
// }

// public interface IRepository<T> where T : Entity
// {
//     void Add(T item);
//     void Remove(T item);
//     void Save();
//     IEnumerable<T> GetAll();
//     T GetById(int id);
// }

// public class GenericRepository<T> : IRepository<T> where T : Entity, new()
// {
//     private List<T> items = new List<T>(); // Simulating a data store

//     public void Add(T item)
//     {
//         items.Add(item);
//     }

//     public void Remove(T item)
//     {
//         items.Remove(item);
//     }

//     public void Save()
//     {
//         // In a real scenario, this method would persist changes to the data source.
//     }

//     public IEnumerable<T> GetAll()
//     {
//         return items;
//     }

//     public T GetById(int id)
//     {
//         return items.FirstOrDefault(item => item.Id == id);
//     }
// }
