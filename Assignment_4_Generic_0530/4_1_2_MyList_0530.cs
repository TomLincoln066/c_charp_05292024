/*
2. Create a Generic List data structure MyList<T> that can store any data type.
Implement the following methods.
1. void Add (T element)
2. T Remove (int index)
3. bool Contains (T element)
4. void Clear ()
5. void InsertAt (T element, int index)
6. void DeleteAt (int index)
7. T Find (int index)
*/


// public class MyList<T>
// {
//     private T[] items;
//     private int count;

//     public MyList()
//     {
//         items = new T[4]; // Initial capacity
//         count = 0;
//     }

//     // Adds an element to the end of the list
//     public void Add(T element)
//     {
//         EnsureCapacity(count + 1);
//         items[count] = element;
//         count++;
//     }

//     // Removes the element at the specified index and returns it
//     public T Remove(int index)
//     {
//         if (index < 0 || index >= count)
//         {
//             throw new IndexOutOfRangeException("Index out of range");
//         }
//         T removedItem = items[index];
//         for (int i = index; i < count - 1; i++)
//         {
//             items[i] = items[i + 1];
//         }
//         count--;
//         return removedItem;
//     }

//     // Checks if the list contains a specific element
//     public bool Contains(T element)
//     {
//         for (int i = 0; i < count; i++)
//         {
//             if (items[i].Equals(element))
//             {
//                 return true;
//             }
//         }
//         return false;
//     }

//     // Clears all elements from the list
//     public void Clear()
//     {
//         count = 0;
//     }

//     // Inserts an element at the specified index
//     public void InsertAt(T element, int index)
//     {
//         if (index < 0 || index > count)
//         {
//             throw new IndexOutOfRangeException("Index out of range");
//         }
//         EnsureCapacity(count + 1);
//         for (int i = count; i > index; i--)
//         {
//             items[i] = items[i - 1];
//         }
//         items[index] = element;
//         count++;
//     }

//     // Deletes the element at the specified index
//     public void DeleteAt(int index)
//     {
//         if (index < 0 || index >= count)
//         {
//             throw new IndexOutOfRangeException("Index out of range");
//         }
//         for (int i = index; i < count - 1; i++)
//         {
//             items[i] = items[i + 1];
//         }
//         count--;
//     }

//     // Finds and returns the element at the specified index
//     public T Find(int index)
//     {
//         if (index < 0 || index >= count)
//         {
//             throw new IndexOutOfRangeException("Index out of range");
//         }
//         return items[index];
//     }

//     // Ensures that the array has enough capacity to store additional elements
//     private void EnsureCapacity(int minCapacity)
//     {
//         if (minCapacity > items.Length)
//         {
//             int newCapacity = items.Length * 2;
//             T[] newArray = new T[newCapacity];
//             items.CopyTo(newArray, 0);
//             items = newArray;
//         }
//     }
// }




