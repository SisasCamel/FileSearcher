using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace _1st_try
{
    class Program
    {
         public static void Main(string[] args)
        {
              Console.WriteLine("File: ");
              string file = Console.ReadLine();
              Console.WriteLine("What are you looking for? ");
              string whattofind = Console.ReadLine();
              bool finish = false;
              string[] readFile = System.IO.File.ReadAllLines(file);
              StringBuilder searchres = new StringBuilder();
              for (int n = 0; n<readFile.Length; n++)
              {
                  System.Console.WriteLine((n + 1) + ".  " + readFile[n]);
                  if (readFile[n].Contains(whattofind))
                  {
                      searchres.Append(whattofind +  " was found in line " + (n+1) + "\n");
                  }
                  if (n == readFile.Length - 1)
                  {
                          finish = true;
                          if (finish = true)
                          {
                                Console.WriteLine(searchres);
                          }
                  }
              }
         }
    }



}