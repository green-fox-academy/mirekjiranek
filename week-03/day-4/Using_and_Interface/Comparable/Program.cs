using System;
using System.Collections.Generic;

namespace Comparable
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Domino> dominoes = new List<Domino>();
            //dominoes.Add(new Domino(5, 2));
            //dominoes.Add(new Domino(4, 6));
            //dominoes.Add(new Domino(1, 5));
            //dominoes.Add(new Domino(6, 7));
            //dominoes.Add(new Domino(2, 4));
            //dominoes.Add(new Domino(7, 1));
            //dominoes.Add(new Domino(6, 1));

            //dominoes.Sort();

            //foreach (var i in dominoes)
            //{
            //    Console.Write(i.Print());
            //}

            List<ToDo> todos = new List<ToDo>();
            todos.Add(new ToDo(true, "Get milk"));
            todos.Add(new ToDo(false, "Vacuum the house"));
            todos.Add(new ToDo(true, "Pay the bills"));
            todos.Add(new ToDo(false, "Preorder new PS"));

            todos.Sort();

            foreach (var i in todos)
            {
                Console.WriteLine(i.Print());
            }
        }
    }
}
