using System;
using System.Collections.Generic;

namespace Aula23Listas
{
    class Program
    {
        static void Main(string[] args)
        {
           List<Produto> produtos = new List<Produto>();
           

           produtos.Add( new Produto("PS5",3245, 4000f));
           produtos.Add( new Produto("XBOX",6579, 4500f));

           foreach(Produto p in produtos){
               Console.ForegroundColor = ConsoleColor.DarkGreen;
               Console.WriteLine($"Preço: ${p.Preco} -  Produto: {p.Nome}");
               Console.ResetColor();
       }
               System.Console.WriteLine();

           List<Cartão> cartões = new List<Cartão>();
            
           cartões.Add(new Cartão("Gustavo",34566, "MasterCard", "09/09/2029",3456));
           cartões.Add(new Cartão("Bruno",45555, "Visa", "01/08/2025",3346));
          
          foreach(Cartão c in cartões){
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Titular: {c.Titular} - Bandeira: {c.bandeira} - Vencimento: {c.vencimento}");
            Console.ResetColor();
          }

           
        }
    }
}
