using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
    public class CustomList<T> : IEnumerable
    {
        int count;
        public int Count
        {
            get
            {
                return count;
            }
        }
        int capacity;
        public int Capacity
        {
            get
            {
                return capacity;
            }
        }
        T[] listArray;
        public T this[int i]
        {
            get
            {
                return listArray[i];
            }
            set
            {
                listArray[i] = value;
            }
        }
        public CustomList() {
            capacity = 4;
            listArray = new T[capacity];
        }
        public void Add(T item)
        {            
            if (count == capacity)
            {
                capacity *= 2;
                T[] values = listArray;
                listArray = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    listArray[i] = values[i];
                }               
            }
            listArray[count] = item;
            count++;                          
        }

    /////Remove Method///////////////////////////////////////////////////////////////////// 
        public void Remove(T item)
        {                      
            {
                for (int i = 0;  i < count; i++)
                {
                    if (item.Equals(listArray[i]))
                    {                     
                        for (int j = i; j < count; j++)
                        {                           
                            if (j == count -1)
                            {
                                listArray[j] = default(T);
                            }
                            else
                            {
                                listArray[j] = listArray[j + 1];
                            }
                        }
                        break;
                    }
                    
                }                
                count--;
            }                                    
               
        }

    /////ToString Override/////////////////////////////////////////////////////////////////       
        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result += listArray[i].ToString();

            }
            return result;
        }

        public IEnumerator GetEnumerator()
        {
            for (int index = 0; index < Count; index++)
            {
                yield return this[index];
            }
        }

    /////Overload + Operator////////////////////////////////////////////////////////////////           
        public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> results = new CustomList<T>();
            for( int i =0; i < list1.Count; i++)
            {
                results.Add(list1[i]);
            }
            for (int i = 0; i < list2.Count; i++)
            {
                results.Add(list2[i]);
            }            
            return results;
        }

    /////OverLoad -Operator/////////////////////////////////////////////////////////////////
        public static CustomList<T> operator -(CustomList<T> list1, CustomList<T> list2)
        {            
            CustomList<T> valueRemains = new CustomList<T>();
            for (int i = 0; i < list1.Count; i++)
            {
                bool wasFound = false;
                for (int j =0; j < list2.Count; j++)
                {
                    if (list1[i].Equals(list2[j]))
                    {
                        wasFound = true;
                        break;
                    }                                        
                }
                if(wasFound == false)
                {
                    valueRemains.Add(list1[i]);
                }               
            }
            return valueRemains;
        }

    /////Zip////////////////////////////////////////////////////////////////////////////////////
        public static CustomList<T> Zip(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> zipList = new CustomList<T>();
            for(int i = 0; i< list1.Count; i++)
            {                
                zipList.Add(list1[i]);
                zipList.Add(list2[i]);
            }
            return zipList;
        }
    }
}


