using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace _1st_try
{
    class Program
    {
        public static void Main()
        {
            int milliseconds = 3000;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Thread.Sleep(milliseconds);
            string slash = @"\";
            Console.WriteLine("Enter the File path");
            string pathplace = Console.ReadLine();
            Directory.SetCurrentDirectory(pathplace);
            Console.WriteLine($"Current directory is '{Environment.CurrentDirectory}'");
            Console.WriteLine("File: ");
            string file = Console.ReadLine();
            if (System.IO.File.Exists((Environment.CurrentDirectory + slash + file)))
            {
                if (file.EndsWith(".exe"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nYou are trying to opening an executable file in a text format.\nDo you want to continue?");
                    Console.ForegroundColor = ConsoleColor.White;
                    string confirmexe = Console.ReadLine();
                    if (confirmexe == "yes")
                    {
                        string[] readFile = System.IO.File.ReadAllLines(Environment.CurrentDirectory + slash + file);
                        StringBuilder searchres = new StringBuilder();
                        for (int n = 0; n < readFile.Length; n++)
                        {
                            System.Console.WriteLine((n + 1) + ".  " + readFile[n]);
                        }
                    }
                    else if (confirmexe == "no")
                    {
                        Console.WriteLine("\nDo you want to search for a file again? y/n \n");
                        string tryagain = Console.ReadLine();
                        if (tryagain == "y")
                        {
                            Main();
                        }
                        else if (tryagain != "n")
                        {

                        }
                    }
                    else
                    {

                    }
                }


                else if (file.EndsWith(".jar"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nYou are trying to opening a .jar file in a text format.\nDo you want to continue?");
                    Console.ForegroundColor = ConsoleColor.White;
                    string confirmexe = Console.ReadLine();
                    if (confirmexe == "yes")
                    {
                        string[] readFile = System.IO.File.ReadAllLines(Environment.CurrentDirectory + slash + file);
                        StringBuilder searchres = new StringBuilder();
                        for (int n = 0; n < readFile.Length; n++)
                        {
                            System.Console.WriteLine((n + 1) + ".  " + readFile[n]);
                        }
                    }
                    else if (confirmexe == "no")
                    {
                        Console.WriteLine("\nDo you want to search for a file again? y/n \n");
                        string tryagain = Console.ReadLine();
                        if (tryagain == "y")
                        {
                            Main();
                        }
                        else if (tryagain != "n")
                        {

                        }
                    }
                    else
                    {

                    }
                }



                else if (file.Contains(".png") || file.Contains(".jpg") || file.Contains(".jpeg") || file.Contains(".gif"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nYou are trying to opening an image/gif file in a text format.\nDo you want to continue?");
                    Console.ForegroundColor = ConsoleColor.White;
                    string confirmexe = Console.ReadLine();
                    if (confirmexe == "yes")
                    {
                        string[] readFile = System.IO.File.ReadAllLines(Environment.CurrentDirectory + slash + file);
                        StringBuilder searchres = new StringBuilder();
                        for (int n = 0; n < readFile.Length; n++)
                        {
                            System.Console.WriteLine((n + 1) + ".  " + readFile[n]);
                        }
                    }
                    else if (confirmexe == "no")
                    {
                        Console.WriteLine("\nDo you want to search for another file? y/n \n");
                        string tryagain = Console.ReadLine();
                        if (tryagain == "y")
                        {
                            Main();
                        }
                        else if (tryagain != "n")
                        {

                        }
                    }
                    else
                    {

                    }
                }




                else if (IsPdf(file) == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nThis is a pdf, pdf's contain colors and other values that\ncannot be recognized easily in a console app. Do you want to continue anyways?\nTake into account you won't be able to search for specific words.");
                    Console.ForegroundColor = ConsoleColor.White;
                    string pdfconfirm = Console.ReadLine();
                    if (pdfconfirm == "yes")
                    {
                        string[] readFile = System.IO.File.ReadAllLines(Environment.CurrentDirectory + slash + file);
                        StringBuilder searchres = new StringBuilder();
                        for (int n = 0; n < readFile.Length; n++)
                        {
                            System.Console.WriteLine((n + 1) + ".  " + readFile[n]);
                        }
                    }
                    else if (pdfconfirm != "yes")
                    {
                        Console.WriteLine("\nDo you want to search for a file again? y/n \n");
                        string tryagain = Console.ReadLine();
                        if (tryagain == "y")
                        {
                            Main();
                        }
                        else if (tryagain == "n")
                        {

                        }
                        else
                        {

                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    SlowTypewrite(".....");
                    Console.WriteLine("\nLoaded\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nWhat are you looking for?\n");
                    string whattofind = Console.ReadLine();
                    bool finish = false;
                    string[] readFile = System.IO.File.ReadAllLines(Environment.CurrentDirectory + slash + file);
                    StringBuilder searchres = new StringBuilder();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("-----------");
                    Console.ForegroundColor = ConsoleColor.White;
                    for (int n = 0; n < readFile.Length; n++)
                    {
                        System.Console.WriteLine((n + 1) + ".  " + readFile[n]);
                        if (readFile[n].Contains(whattofind))
                        {

                            searchres.Append("\n" + whattofind + " was found in line " + (n + 1) + "\n");
                        }
                        if (n == readFile.Length - 1)
                        {
                            finish = true;
                            if (finish = true)
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("-----------");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(searchres);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("\nDo you want to search for a file again? y/n \n");
                                string tryagain = Console.ReadLine();
                                if (tryagain == "y")
                                {
                                    Main();
                                }
                                else if (tryagain == "n")
                                {

                                }
                                else
                                {

                                }
                            }
                        }
                    }
                }
            }

            else
            {
                Console.WriteLine("This file couldn't be found \n");
                Console.WriteLine("Want to search for a file again? \n");
                string tryagain = Console.ReadLine();
                if (tryagain == "yes")
                {
                    Main();
                }
                else if (tryagain != "yes")
                {

                }
            }
        }
        



        public static bool IsPdf(string path)
        {
            var pdfString = "%PDF-";
            var pdfBytes = Encoding.ASCII.GetBytes(pdfString);
            var len = pdfBytes.Length;
            var buf = new byte[len];
            var remaining = len;
            var pos = 0;
            using (var f = File.OpenRead(path))
            {
                while (remaining > 0)
                {
                    var amtRead = f.Read(buf, pos, remaining);
                    if (amtRead == 0) return false;
                    
                    remaining -= amtRead;
                    pos += amtRead;
                    
                }
                return pdfBytes.SequenceEqual(buf);
            }
        }
        static void SlowTypewrite(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(300);
            }
        }




    }
}
