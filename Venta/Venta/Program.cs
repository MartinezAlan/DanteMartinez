using System;

public class Venta
{
    private int id;
    private string comentarios;
    private long idUsuario;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Comentarios
    {
        get { return comentarios; }
        set { comentarios = value; }
    }

    public long IdUsuario
    {
        get { return idUsuario; }
        set { idUsuario = value; }
    }

    public Venta()
    {
        id = 0;
        comentarios = string.Empty;
        idUsuario = 0;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Venta venta = new Venta();
        venta.Id = 001;
        venta.Comentarios = "Venta realizada con éxito";
        venta.IdUsuario = 1001;

        Console.WriteLine("Información de la Venta:");
        Console.WriteLine("ID: " + venta.Id);
        Console.WriteLine("Comentarios: " + venta.Comentarios);
        Console.WriteLine("ID de Usuario: " + venta.IdUsuario);

        Console.ReadLine();
    }
}
