using System;
using System.Collections;

namespace collections_arraylist
{
    class Program
    {
       public static void show(ArrayList array)
        {
            foreach (var i in array)
            {
                System.Console.Write(i + " ");
            }
            System.Console.WriteLine();
        }
        static void Main(string[] args)
        {
            bool flag=false,check=false;
            ArrayList arr = new ArrayList();
            arr.Add(34);
            arr.Add("Naran");
            arr.Add("Hunza");
            arr.Add(67);

            System.Console.WriteLine("//////////////////ArrayList////////////////////");
            show(arr);

            System.Console.WriteLine("//////////////////Insert at index 2////////////////////");
            arr.Insert(2, "Murree");
            show(arr);

            System.Console.WriteLine("//////////////////Remove///////////////////");
            arr.RemoveAt(4);
            show(arr);

            System.Console.WriteLine("//////////////////Is Size Fixed////////////////////");
            flag=arr.IsFixedSize;
            System.Console.WriteLine(flag);

            System.Console.WriteLine("//////////////////Contains////////////////////");
            check = arr.Contains("Hunza");
            System.Console.WriteLine(check);

            System.Console.WriteLine("//////////////////reverse////////////////////");
            arr.Reverse();
            show(arr);

            System.Console.WriteLine("//////////////////Merge two array list////////////////////");
            ArrayList arr1 = new ArrayList() { "Shimla", "Kashmir", "Manali" };
            arr.InsertRange(3, arr1);
            show(arr);


        }
    }
}
