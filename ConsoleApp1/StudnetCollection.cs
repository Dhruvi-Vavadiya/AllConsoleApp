using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace ConsoleApp1
{
    public class StudnetCollection <T>
    {
        string jjj = "Hello";
        string ans = jjj.Reverse();
        private List<T> myList;
        private static int objectCount = 0;

        public StudnetCollection() //ctor
        {
            myList = new List<T>();
            objectCount++;
        }

       
        public void AddList(T data)
        {
            this.myList.Add(data);
        }
        public void Show()
        {
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
        }


        public int Count
        {
            get { 
                return myList.Count;
            }
        }
    }
}
