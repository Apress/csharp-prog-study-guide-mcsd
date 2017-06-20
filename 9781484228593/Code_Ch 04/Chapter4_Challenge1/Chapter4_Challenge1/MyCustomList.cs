using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Chapter4_Challenge1
{
    class MyCustomList<T> : IList<T>, ICollection<T>, IEnumerable<T>
    {
        private readonly IList<T> _list = new List<T>();

        #region Implementation of IEnumerable

        /// <summary>
        /// Returns enumerator of the generic type list
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        /// <summary>
        /// returns enumerator of strongly typed list
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion

        #region Implementation of ICollection<T>

        /// <summary>
        /// Add item to the list
        /// </summary>
        /// <param name="item">item that needs to be added in the list</param>
        public void Add(T item)
        {
            _list.Add(item);
        }

        /// <summary>
        /// Clears all the items of the list
        /// </summary>
        public void Clear()
        {
            _list.Clear();
        }

        /// <summary>
        /// check if the list contains this item
        /// </summary>
        /// <param name="item">item to be checked</param>
        /// <returns>returns true if item is found in the list</returns>
        public bool Contains(T item)
        {
            return _list.Contains(item);
        }

        /// <summary>
        /// Copies elements of collection to array
        /// </summary>
        /// <param name="array">array in which values should be copied</param>
        /// <param name="arrayIndex">starting index from which you wanna start copying</param>
        public void CopyTo(T[] array, int arrayIndex)
        {
            _list.CopyTo(array, arrayIndex);
        }

        /// <summary>
        /// Remove the item from the collection
        /// </summary>
        /// <param name="item">item to be removed</param>
        /// <returns>returns true if item removed otherwise false</returns>
        public bool Remove(T item)
        {
            return _list.Remove(item);
        }

        /// <summary>
        /// return total values of the collection
        /// </summary>
        public int Count
        {
            get { return _list.Count; }
        }

        /// <summary>
        /// returns true if the collection is readonly otherwise false
        /// </summary>
        public bool IsReadOnly
        {
            get { return _list.IsReadOnly; }
        }

        #endregion

        #region Implementation of IList<T>

        /// <summary>
        /// returns index of the item
        /// </summary>
        /// <param name="item">item whose index needs to be checked</param>
        /// <returns>return index of the item</returns>
        public int IndexOf(T item)
        {
            return _list.IndexOf(item);
        }

        /// <summary>
        /// Insert item to a specific index
        /// </summary>
        /// <param name="index"> indx in which item needs to be inserted</param>
        /// <param name="item">item which needs to be inserted</param>
        public void Insert(int index, T item)
        {
            _list.Insert(index, item);
        }

        /// <summary>
        /// Reomve item at given index
        /// </summary>
        /// <param name="index">index at which item needs to be removed</param>
        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        /// <summary>
        /// returns the value at spefic index
        /// </summary>
        /// <param name="index">index of the value</param>
        /// <returns>return item at specific index</returns>
        public T this[int index]
        {
            get { return _list[index]; }
            set { _list[index] = value; }
        }

        #endregion

        #region Your Added Stuff

        // Add new features to your collection.

        #endregion
    }
}
