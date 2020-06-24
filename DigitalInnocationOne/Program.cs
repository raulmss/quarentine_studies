using System;
using DigitalInnocationOne.Media;

namespace DigitalInnocationOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Dupla[] duplas = new Dupla[10];
            int size = 0;
            string tmp;
            int opt = 0;
            while(opt != 4)
            {
                Console.WriteLine("Teacher's Options");
                Console.WriteLine("1 - Add Student");
                Console.WriteLine("2 - List Students");
                Console.WriteLine("3 - See the average");

                tmp = Console.ReadLine();
                opt = Int32.Parse(tmp);
            //Adicionar      
                if(opt == 1)
                {  
                    string nome = Console.ReadLine();
                    decimal nota = decimal.Parse(Console.ReadLine());
                    duplas[size] = new Dupla(nome, nota);
                    size++;
                    Console.WriteLine("Name added sucessfully");
                }
            //Ler todos os nomes
                if(opt == 2)
                {
                    Console.WriteLine("Nome(s):");
                    for (int i = 0; i < size; i++)
                    {
                        if(duplas[i].nome != null)
                        Console.WriteLine($"{duplas[i].nome}");
                    }     
                }
                
            }    
        }
          
    }
}
