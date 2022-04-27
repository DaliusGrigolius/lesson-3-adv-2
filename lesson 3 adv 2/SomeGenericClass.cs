using System;
using System.Collections.Generic;

namespace lesson_3_adv_2
{
    public class SomeGenericClass<T>
    {
        private List<T> SomeList { get; set; }

        public SomeGenericClass()
        {
            SomeList = new List<T>();
        }

        public void PrintList()
        {
            foreach (var item in SomeList)
            {
                Console.WriteLine(item);
            }
        }

        public T[] RetrieveConvertedListToArray()
        {
            return SomeList.ToArray();
        }

        public void AddItem(T something)
        {
            SomeList.Add(something);
        }

        public void AddListOfItems(List<T> listOfItems)
        {
            foreach(var item in listOfItems)
            {
                SomeList.Add(item);
            }
        }

        public void DeleteItem(T item)
        {
            SomeList.Remove(item);
        }

        public void DeleteItemByIndex(int itemIndex)
        {
            SomeList.RemoveAt(itemIndex);
        }

        public void DeleteAllItems(T item)
        {
            for (int i = 0; i < SomeList.Count; i++)
            {
                if (SomeList[i].Equals(item))
                {
                    SomeList.RemoveAt(i);
                }
            }
        }

        public bool CheckIfValueIsNull(T item)
        {
            return item == null ? true : false;
        }
    }
}
