using System;

public class Producto
{
    private int id;
    private string descripcion;
    private double costo;
    private double precioVenta;
    private long idUsuario;
    private string stock;

    public Producto()
    {
        id = 0;
        descripcion = string.Empty;
        costo = 0;
        precioVenta = 0;
        idUsuario = 0;
        stock = string.Empty;
    }

    public Producto(int id, string descripcion, double costo, double precioVenta, long idUsuario, string stock)
    {
        this.id = id;
        this.descripcion = descripcion;
        this.costo = costo;
        this.precioVenta = precioVenta;
        this.idUsuario = idUsuario;
        this.stock = stock;
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Descripcion
    {
        get { return descripcion; }
        set { descripcion = value; }
    }

    public double Costo
    {
        get { return costo; }
        set { costo = value; }
    }

    public double PrecioVenta
    {
        get { return precioVenta; }
        set { precioVenta = value; }
    }

    public long IdUsuario
    {
        get { return idUsuario; }
        set { idUsuario = value; }
    }

    public string Stock
    {
        get { return stock; }
        set { stock = value; }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Producto producto1 = new Producto(001, "mouse", 4500, 6000, 1011, "Contamos con Stock");

        
        Console.WriteLine("ID del Producto: " + producto1.Id);
        Console.WriteLine("Descripción: " + producto1.Descripcion);
        Console.WriteLine("Costo: " + producto1.Costo);
        Console.WriteLine("Precio de Venta: " + producto1.PrecioVenta);
        Console.WriteLine("ID de Usuario: " + producto1.IdUsuario);
        Console.WriteLine("Stock: " + producto1.Stock);

        Console.ReadLine();
    }
}
