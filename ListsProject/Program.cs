using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTSLib;
using static System.Console;

namespace ListsProject
{
    class Program
    {
        class Personas
        {
            string nombre;
            string apellido;

            public string Nombre { get => nombre; set => nombre = value; }
            public string Apellido { get => apellido; set => apellido = value; }

            public Personas(string nombre, string apellido)
            {
                Nombre = nombre;
                Apellido = apellido;
            }
        }
        static void Main(string[] args)
        {
            
            DTSLib.LinkedList<int> list = new DTSLib.LinkedList<int>();
            //list.Insert(0, 333);
            list.Add(5);
            list.Add(23);
            list.Add(-1);
            list.Add(76);
            list.Add(-58);
            //list.Insert(0, 555);
            //list.Insert(2, 0);
            //list.Insert(6, -463);
            //WriteLine($"Removed {list.Remove(0)}");
            //WriteLine($"Removed {list.Remove(0)}");
            //WriteLine($"Removed {list.Remove(2)}");
            //WriteLine($"Removed {list.Remove(3)}");

            Console.Write("Linked List: ");
            Console.Write("[ ");
            for (int i = 0; i < list.Size; i++)
            {
                Console.Write($"{list[i]} ");
            }
            Console.Write("]");
            WriteLine();
            WriteLine("=========1.Metodo Find=========");
            WriteLine(list.Find(value => value < 0));
            WriteLine("=========2.Metodo ForEach=========");
            list.ForEach();
            double average = 0.0;
            list.ForEach(value => average += value);
            average /= list.Size;
            WriteLine("El promedio es: " + average);         
            WriteLine("=========3.objetos de la clase en un ciclo foreach=========");
            DTSLib.LinkedList<Personas> list2 = new DTSLib.LinkedList<Personas>();
            list2.Add(new Personas("Francisco", "Perez"));
            list2.Add(new Personas("Miguel", "Fuentes"));
            list2.Add(new Personas("Jimena", "Vadillo"));
            list2.Add(new Personas("Francisco", "Valdez"));

            foreach (Personas personas in list2)
            {
                Console.WriteLine($"Persona: {personas.Nombre} {personas.Apellido}");
            }
        }
        static void Main2(string[] args)
        {
            ArrayList<int> list = new ArrayList<int>(2);
            list.Add(5);
            list.Add(23);
            list.Add(-1);
            list.Add(76);
            list.Add(-58);

            //list.Insert(5, 93);
            //list.Insert(3, 0);
            //list.Insert(0, 100);
            //Console.WriteLine(list.Remove(1));
            Console.WriteLine("=====FOR=====");
            for (int i = 0; i < list.Size; i++)
            {
                Console.WriteLine($"List[{i}] = {list[i]}");
            }

            Console.WriteLine("=====FOREACH=====");
            foreach (int value in list)
            {
                Console.WriteLine($"{value}");
            }

            //IEnumerator enumerator = list.GetEnumerator();
            //enumerator.Reset();
            //while (enumerator.MoveNext())
            //{
            //    int value = (int)enumerator.Current;
            //    Console.WriteLine($"{value}");
            //}

            Console.WriteLine("=====PROMEDIO=====");
            //double average = 0.0;
            //foreach (int value in list)
            //{
            //    average += value;
            //}
            //average /= list.Size;

            double average = 0.0;
            list.ForEach(value => average += value);
            average /= list.Size;

            Console.WriteLine($"Promedio = {average}");
            Console.WriteLine("");

            WriteLine("=====FOREACH PARA NEGATIVOS=====");
            foreach (int value in list.FindAll(value => value < 0))
            {
                WriteLine($"{value}");
            }
        }
    }
}
