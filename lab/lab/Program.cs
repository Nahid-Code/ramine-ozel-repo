using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //    string a = Console.ReadLine();

            //    Say(a);
            //    Console.Read();\
            #region task4 


            //int b =int.Parse( Console.ReadLine());
            //int[] a = new int[b] ;
            //int sum = 0;
            //for (int i = 0; i <= b-1; i++)
            //{
            //    int daxiledilen = int.Parse(Console.ReadLine());
            //    a[i] = daxiledilen;

            //}

            //for (int i = 0; i < a.Length; i++)
            //{
            //    sum += a[i];
            //}
            //Console.WriteLine(sum);
            //Console.WriteLine(a);
            //Console.ReadLine();
            #endregion
            //string cumle = Console.ReadLine();
            //string soz = Console.ReadLine();
            //Console.WriteLine(Method(cumle,soz));
            //Console.Read();

            #region task 3


            //int a = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = 1; a>= i; i++)
            //{
            //    int daxiledilen = int.Parse(Console.ReadLine());
            //    sum += daxiledilen;
            //}
            //Console.WriteLine(sum);
            //Console.Read();
            #endregion
            #region task5


            //    string cumle = Console.ReadLine();
            //    Console.WriteLine(Method(cumle));
            //    Console.ReadLine();




            //}
            //static int Method(string sentence)
            //{
            //    int count = 1;
            //    foreach (char item in sentence)
            //    {
            //        if (item ==' ')
            //        {
            //            count++;
            //        }
            //    }
            //    return count;
            #endregion
        }
        #region task6

        
        static string Method(string a,string b)
        {
            string result = "false";
            string[] arr = a.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                if (b==arr[i])
                {
                    result = "True";
                }
            }
            return result;
            #endregion
        }
        #region task1

        //static void  Say(string word)
        //       {
        //           int count = 0;
        //           foreach (char item in word)
        //           {
        //               count++;
        //           }
        //           Console.WriteLine(count);
        //       }
        #endregion
        #region task2


        //static string Tapmaq(int[] arr,int b)
        //      {
        //          string result = "doesnt exist";
        //          foreach (int item in arr)
        //          {
        //              if (item == b) 
        //              {
        //                  result = "Exists";  
        //              }
        //          }

        //          return result;
        //      }
        #endregion
    }

}
