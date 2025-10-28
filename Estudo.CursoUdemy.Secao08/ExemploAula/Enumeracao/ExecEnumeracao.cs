using Estudo.CursoUdemy.Secao9.ExemploAula.Enumeracao.Entities;
using Estudo.CursoUdemy.Secao9.ExemploAula.Enumeracao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao9.ExemploAula.Enumeracao
{
    public  class ExecEnumeracao
    {
        public static void executar()
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
        }
    }
}
