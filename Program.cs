using Reviews;
using Productos;
class Program
{
    static void Main(string [] args)
    {
        Review review1 = new Review(1,"Pésimo");
        Producto producto1 = new Producto ("Oreo",2.99);
        producto1.addReview(review1);
        Console.WriteLine (producto1.getInfoProducto());

    }
}