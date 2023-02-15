using Estudo.CursoUdemy.Secao9.ExerciciosPropostos.ExercicioProposto.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao9.ExerciciosPropostos.ExercicioProposto
{
    public static class MainExercicioProposto
    {
        public static void Executar()
        {
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth data (DD/MM/YYYY): ");
            DateTime Birthday = DateTime.Parse(Console.ReadLine());

            Client cliente = new Client(name,email,Birthday);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status (PENDING_PAYMENT, PROCESSING, SHIPPED, DELIVERED): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Console.Write("How many items to this order: ");
            int qntItems = int.Parse(Console.ReadLine());

            for (int i = 0; i < qntItems; i++)
            {
                Product product = new Product();
            }

            
           
        }
    }
}
