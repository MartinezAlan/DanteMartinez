﻿using System;

public class Usuario
{
    private int id;
    private string nombre;
    private string apellido;
    private string nombreUsuario;
    private string contraseña;
    private string mail;

    public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contraseña, string mail)
    {
        this.id = id;
        this.nombre = nombre;
        this.apellido = apellido;
        this.nombreUsuario = nombreUsuario;
        this.contraseña = contraseña;
        this.mail = mail;
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public string Apellido
    {
        get { return apellido; }
        set { apellido = value; }
    }

    public string NombreUsuario
    {
        get { return nombreUsuario; }
        set { nombreUsuario = value; }
    }

    public string Contraseña
    {
        get { return contraseña; }
        set { contraseña = value; }
    }

    public string Mail
    {
        get { return mail; }
        set { mail = value; }
    }

    public static void Main(string[] args)
    {
        Usuario usuario = new Usuario(1011, "Dante", "Martinez", "Martinez1011", "Dante1011", "dantemartinez1011@gmail.com");

        Console.WriteLine("ID del Usuario: " + usuario.Id);
        Console.WriteLine("Nombre: " + usuario.Nombre);
        Console.WriteLine("Apellido: " + usuario.Apellido);
        Console.WriteLine("Nombre de usuario: " + usuario.NombreUsuario);
        Console.WriteLine("Contraseña: " + usuario.Contraseña);
        Console.WriteLine("Correo electrónico: " + usuario.Mail);

        Console.ReadLine();
    }
}