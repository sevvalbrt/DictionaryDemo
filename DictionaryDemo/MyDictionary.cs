using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryDemo
{
    class MyDictionary<T>
    {
        T[] items;

        public MyDictionary()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] temporaryArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < temporaryArray.Length; i++)
            {
                items[i] = temporaryArray[i];
            }
            items[items.Length - 1] = item;
            
        }

        public int Count
        {
            get { return items.Length; } 
        }

        public T[] Items
        {
            get { return items; }
        }
        

    }
}
