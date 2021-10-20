using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando a lista
            List<string>
            list = new List<string>();
            //adicionando elementos na lista
            list.Add("Vinicius");
            list.Add("Beatriz");
            list.Add("Gustavo");
            list.Add("Adilson");
            list.Add("Alexandre");

            //adicona um elemento sugerido
            list.Insert(2, "Fernando");

                //realiza uma leitura em loop dos elementos inseridos
                Console.WriteLine("quantidade de elementos na Lista: " + list.Count);
                //encontrar o primeiro elemento que inicia com a letra A com uma função
                string s1 = list.Find(x => x[0] == 'A');
                Console.WriteLine("Primeiro elemento que começa com a letra A: " + s1);
                //encontra o ultimo elemento que incia com a letra  A com uma função
                string s2 = list.FindLast(x => x[0] == 'A');
                Console.WriteLine("Primeiro elemento que começa coma letra A: " + s2);

                //buscar elemento pela sua posição
                int pos1 = list.FindIndex(x => x[0] == 'A');
                Console.WriteLine("Primeira posição de 'A': " + pos1);
                int pos2 = list.FindLastIndex(x => x[0] == 'A');
                Console.WriteLine("Ultima posição de 'A': " + pos2);

                //buscar todos os elementos com tamanho igual
                List<string> list2 = list.FindAll(x => x.Length == 5);
                Console.WriteLine("-------------------------------");

            foreach (string obj in list2)
            {
                Console.WriteLine(obj);

                //remover elemento da lista

                list.Remove("Alexandre");
                Console.WriteLine("===================");

            }

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //remover determinado elemento da lista
            list.RemoveAll(x => x[0] == 'W');
            Console.WriteLine("+++++++++++++++++++");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //Remover elemento de determinada posição da lista

            list.RemoveAt(3);
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxx");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //remover elemento da lista a partir da posição e quantos elementos 
            list.RemoveRange(1, 2);
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxx");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

        }


    }

}
