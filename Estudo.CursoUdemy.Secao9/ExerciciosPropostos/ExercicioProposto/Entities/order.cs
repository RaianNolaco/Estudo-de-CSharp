using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao9.ExerciciosPropostos.ExercicioProposto.Entities
{
    public class order
    {
        public DateTime Moment { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; }

        public order(OrderStatus status, Client client)
        {
            Status = status;
            Client = client;
        }

        public void addItem(OrderItem newItem)
        {
            Items.Add(newItem);
        }

        public void removeItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double total()
        {
            double total = 0;
            foreach (OrderItem item in Items)
            {
                total += item.subTotal();
            }

            return total;
        }
    }
}
