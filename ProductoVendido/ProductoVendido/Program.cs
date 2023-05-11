using System;

public class ProductoVendido
{
    private int id;
    private int idProducto;
    private int stock;
    private int idVenta;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public int IdProducto
    {
        get { return idProducto; }
        set { idProducto = value; }
    }

    public int Stock
    {
        get { return stock; }
        set { stock = value; }
    }

    public int IdVenta
    {
        get { return idVenta; }
        set { idVenta = value; }
    }

    public static void Main(string[] args)
    {
        ProductoVendido productoVendido = new ProductoVendido();
        productoVendido.Id = 001;
        productoVendido.IdProducto = 1001;
        productoVendido.Stock = 55;
        productoVendido.IdVenta = 10001;

        Console.WriteLine("Producto Vendido:");
        Console.WriteLine("ID: " + productoVendido.Id);
        Console.WriteLine("ID del Producto: " + productoVendido.IdProducto);
        Console.WriteLine("Stock: " + productoVendido.Stock);
        Console.WriteLine("ID de la Venta: " + productoVendido.IdVenta);

        Console.ReadLine();
    }
}
