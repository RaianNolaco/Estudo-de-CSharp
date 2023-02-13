namespace Estudo.CursoUdemy.Secao9.ExerciciosPropostos.ExercicioProposto.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Product Product { get; set; }

        public OrderItem() { }

        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product;
            Price = Product.Price;
        }


        public double subTotal()
        {
            return Quantity * Price;
        }

    }
}