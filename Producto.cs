    using Reviews;

namespace Productos;

public class Producto
{
    public Producto(string nombreProducto, double precioProducto)
    {
        string nombre = nombreProducto;
        double precio = precioProducto;
    }
    public string getInfoProducto()
    {
       string info=$"El producto {this.nombre} cuesta {this.precio}";
       foreach (Review review in this.lista)
       {
            info = $"{info} {review.getInfoReview()}";
       }
       return info;
    }
    private List<Review> lista=new List<Review>();
    public string nombre;
    public double precio;
    public void addReview(Review review)
    {
        this.lista.Add(review);
    }
}
