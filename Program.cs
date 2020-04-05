using LibrarieEntitati;
using System;


namespace ManagementStudenti
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Ionescu");
            //s.SetNote("");
            //Console.WriteLine(s.ConversieLaSir());
            Menu(s);
            Console.ReadKey();
        }
        static void Menu(Student s)
        {
            string menu = "\nS: Citeste note de la tastatura ca un sir de caractere\nT: Citeste note de la tastatura(cate o nota pe rand)\nC: Citeste note din linia de comanda\nA: Afisare note\nI: Info autor\nX: Iesire";
            Console.WriteLine(menu);
            do
            {
                string op = Console.ReadLine();
                switch(op)
                {
                    case "s":
                    {
                            /*Console.WriteLine("Introduceti sir de note cu spatiu si virgula intre ani");
                            string lista = Console.ReadLine();
                            string[] data = lista.Split(',');
                            int n = data.Length;
                            string[][] not = new string[4][];
                            for(int i=0;i<n;i++)
                            {
                                //not[i] = data.Split(' ');
                                Console.WriteLine("not[" + i + "]=" + not[i]);
                            }*/
                            s.SetNote();
                            Console.ReadKey();
                        break;
                    }
                    case "t":
                    {
                            Console.WriteLine("Introduceti cate o nota si 0 pentru a temina");
                            int z=Convert.ToInt32(Console.ReadLine());
                            do
                            {

                            } while (z != 0);
                        Console.ReadKey();
                        break;
                    }
                    case "c":
                    {
                       Console.ReadKey();
                       break;

                    }
                    case "a":
                    {
                            Console.WriteLine(s.ConversieLaSir());
                            Console.ReadKey();
                         break;
                    }
                    case "i":
                    {
                        Console.WriteLine("Proiect realizat de ionut taran");
                        Console.ReadKey();
                        break;
                    }
                    case "x":
                        return;
                }
                Console.WriteLine("\nAlege o optiune");
            } while (true);
        }
    }
}
