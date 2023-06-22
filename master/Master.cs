using System;
using System.Collections.Generic;
using System.Data.SqlClient;

internal class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string NombreUsuario { get; set; }
    public string Contraseña { get; set; }
    public string Mail { get; set; }

    public List<Usuario> TraerUsuarios()
    {
        string connectionString = @"Server=DESKTOP-N3CROP1;Database=SistemaGestion;Trusted_Connection=True;";
        List<Usuario> listaUsuarios = new List<Usuario>();
        var query = "SELECT Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail FROM Usuario";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(reader["Id"]);
                        usuario.Nombre = reader["Nombre"].ToString();
                        usuario.Apellido = reader["Apellido"].ToString();
                        usuario.NombreUsuario = reader["NombreUsuario"].ToString();
                        usuario.Contraseña = reader["Contraseña"].ToString();
                        usuario.Mail = reader["Mail"].ToString();
                        listaUsuarios.Add(usuario);
                    }
                }
            }
        }

        return listaUsuarios;
    }
}

internal class Producto
{
    public int Id { get; set; }
    public string Descripciones { get; set; }
    public double Costo { get; set; }
    public double PrecioVenta { get; set; }
    public int Stock { get; set; }
    public int IdUsuario { get; set; }

    public List<Producto> TraerProductos()
    {
        string connectionString = @"Server=DESKTOP-N3CROP1;Database=SistemaGestion;Trusted_Connection=True;";
        List<Producto> listaProductos = new List<Producto>();
        var query = "SELECT Id, Descripciones, Costo, PrecioVenta, Stock, IdUsuario FROM Producto";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var producto = new Producto();
                        producto.Id = Convert.ToInt32(reader["Id"]);
                        producto.Descripciones = reader["Descripciones"].ToString();
                        producto.Costo = Convert.ToDouble(reader["Costo"]);
                        producto.PrecioVenta = Convert.ToDouble(reader["PrecioVenta"]);
                        producto.Stock = Convert.ToInt32(reader["Stock"]);
                        producto.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
                        listaProductos.Add(producto);
                    }
                }
            }
        }

        return listaProductos;
    }
}

internal class ProductoVendido
{
    public int Id { get; set; }
    public int Stock { get; set; }
    public int IdProducto { get; set; }
    public int IdVenta { get; set; }

    public List<ProductoVendido> TraerProductosVendidos()
    {
        string connectionString = @"Server=DESKTOP-N3CROP1;Database=SistemaGestion;Trusted_Connection=True;";
        List<ProductoVendido> listaProductosVendidos = new List<ProductoVendido>();
        var query = "SELECT Id, Stock, IdProducto, IdVenta FROM ProductoVendido";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productoVendido = new ProductoVendido();
                        productoVendido.Id = Convert.ToInt32(reader["Id"]);
                        productoVendido.Stock = Convert.ToInt32(reader["Stock"]);
                        productoVendido.IdProducto = Convert.ToInt32(reader["IdProducto"]);
                        productoVendido.IdVenta = Convert.ToInt32(reader["IdVenta"]);
                        listaProductosVendidos.Add(productoVendido);
                    }
                }
            }
        }

        return listaProductosVendidos;
    }
}

internal class Venta
{
    public int Id { get; set; }
    public string Comentarios { get; set; }

    public List<Venta> TraerVentas()
    {
        string connectionString = @"Server=DESKTOP-N3CROP1;Database=SistemaGestion;Trusted_Connection=True;";
        List<Venta> listaVentas = new List<Venta>();
        var query = "SELECT Id, Comentarios FROM Venta";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var venta = new Venta();
                        venta.Id = Convert.ToInt32(reader["Id"]);
                        venta.Comentarios = reader["Comentarios"].ToString();
                        listaVentas.Add(venta);
                    }
                }
            }
        }

        return listaVentas;
    }
}
internal class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string NombreUsuario { get; set; }
    public string Contraseña { get; set; }
    public string Mail { get; set; }

    public bool IniciarSesion(string nombreUsuario, string contraseña)
    {
        string connectionString = @"Server=DESKTOP-N3CROP1;Database=SistemaGestion;Trusted_Connection=True;";
        var query = "SELECT Id FROM Usuario WHERE NombreUsuario = @NombreUsuario AND Contraseña = @Contraseña";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                command.Parameters.AddWithValue("@Contraseña", contraseña);

                var result = command.ExecuteScalar();
                if (result != null)
                {
                    Id = Convert.ToInt32(result);
                    return true;
                }
            }
        }

        return false;
    }
}
