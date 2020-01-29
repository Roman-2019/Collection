﻿using System;
using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Collect
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var notebookCollection = new CustomeList();

            Console.WriteLine("input serial number: ");
            int SerialNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("input name: ");
            string Name = Console.ReadLine();

            var igor = new Notebook(SerialNumber, Name);

            notebookCollection.Add(igor);
            notebookCollection.Add(new Notebook(2, "Vasya"));
            notebookCollection.Add(new Notebook(3, "Kyrlik"));

            foreach (Notebook note in notebookCollection)
                Console.WriteLine(note.Name);
            //Console.ReadKey();
            //Print(notebookCollection);
            //Console.ReadKey();

            var pupkin = notebookCollection[1];
            notebookCollection.Delete(pupkin);

            foreach (Notebook note in notebookCollection)
                Console.WriteLine(note.Name);
            Console.ReadKey();
        }

        //static void Print(CustomeList list) 
        //{
        //    var node = list.Head;
        //    while (node != null) 
        //    {
        //        Console.WriteLine(node.Element.Name);
        //        node = node.NextElement;
        //    }

        //}
    }
}
