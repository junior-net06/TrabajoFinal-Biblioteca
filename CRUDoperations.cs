using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal_Biblioteca
{
    internal class CRUDoperations
    {
        private DBManager dbManager;

        public CRUDoperations()
        {
            dbManager = new DBManager();
        }

        //Operaciones CRUD sobre tabla inventario de libros
        public DataTable GetAllLibros()
        {
            string query = "SELECT * FROM InventarioLibros";
            return dbManager.ExecuteQuery(query);
        }

        public int InsertLibro(string titulo, string autor, string editora, DateTime fechaPublicacion, string isbn)
        {
            string query = $"INSERT INTO InventarioLibros (Titulos, Autor, Editora, Fecha_De_Publicacion, ISBN) " +
                           $"VALUES ('{titulo}', '{autor}', '{editora}', #{fechaPublicacion.ToShortDateString()}#, '{isbn}')";
            return dbManager.ExecuteNonQuery(query);
        }

        public int UpdateLibro(int idLibro, string titulo, string autor, string editora, DateTime fechaPublicacion, string isbn)
        {
            string query = $"UPDATE InventarioLibros SET Titulos='{titulo}', Autor='{autor}', Editora='{editora}', " +
                           $"Fecha_De_Publicacion=#{fechaPublicacion.ToShortDateString()}#, ISBN='{isbn}' " +
                           $"WHERE Id_libros={idLibro}";
            return dbManager.ExecuteNonQuery(query);
        }

        public int DeleteLibro(int idLibro)
        {
            string query = $"DELETE FROM InventarioLibros WHERE Id_libros={idLibro}";
            return dbManager.ExecuteNonQuery(query);
        }

        //Operaciones CRUD sobre tabla usuarios
        public DataTable GetAllUsuarios()
        {
            string query = "SELECT * FROM Usuarios";
            return dbManager.ExecuteQuery(query);
        }


        public DataTable GetUsuario(string cuenta)
        {
            string query = $"SELECT * FROM Usuarios WHERE cuenta = '{cuenta}'";
            return dbManager.ExecuteQuery(query);
        }



        public int InsertUsuario(string nombre, string cuenta, string pass)
        {
            string query = $"INSERT INTO Usuarios (Nombre, Cuenta, Pass) " +
                           $"VALUES ('{nombre}', '{cuenta}', '{pass}')";
            return dbManager.ExecuteNonQuery(query);
        }

        public int UpdateUsuario(int idUsuario, string nombre, string cuenta, string pass)
        {
            string query = $"UPDATE Usuarios SET Nombre='{nombre}', Cuenta='{cuenta}', Pass='{pass}' " +
                           $"WHERE Id_usuario={idUsuario}";
            return dbManager.ExecuteNonQuery(query);
        }

        public int DeleteUsuario(int idUsuario)
        {
            string query = $"DELETE FROM Usuarios WHERE Id_usuario={idUsuario}";
            return dbManager.ExecuteNonQuery(query);
        }

        //operaciones CRUD sobre tabla estudiantes
        public DataTable GetAllEstudiantes()
        {
            string query = "SELECT * FROM VentanaAdministrarEstudiantes";
            return dbManager.ExecuteQuery(query);
        }

        public int InsertEstudiante(string nombre, string apellido, string direccion, string matricula)
        {
            string query = $"INSERT INTO VentanaAdministrarEstudiantes (Nombre, Apellido, Direccion, Matricula) " +
                           $"VALUES ('{nombre}', '{apellido}', '{direccion}', '{matricula}')";
            return dbManager.ExecuteNonQuery(query);
        }

        public int UpdateEstudiante(int idEstudiante, string nombre, string apellido, string direccion, string matricula)
        {
            string query = $"UPDATE VentanaAdministrarEstudiantes SET Nombre='{nombre}', Apellido='{apellido}', " +
                           $"Direccion='{direccion}', Matricula='{matricula}' " +
                           $"WHERE Id_estudiantes={idEstudiante}";
            return dbManager.ExecuteNonQuery(query);
        }

        public int DeleteEstudiante(int idEstudiante)
        {
            string query = $"DELETE FROM VentanaAdministrarEstudiantes WHERE Id_estudiantes={idEstudiante}";
            return dbManager.ExecuteNonQuery(query);
        }

        //Operaciones CRUD sobre tabla prestamos
        public DataTable GetAllPrestamos()
        {
            string query = "SELECT * FROM VentanaPrestamoLibros";
            return dbManager.ExecuteQuery(query);
        }

        public int InsertPrestamo(int idLibro, int idEstudiante, DateTime fechaSalida, DateTime fechaDevolucion)
        {
            string query = $"INSERT INTO VentanaPrestamoLibros (Id_libro, Id_estudiantes, Fecha_Salida, Fecha_devolucion, Retraso, Devuelto) " +
                           $"VALUES ({idLibro}, {idEstudiante}, #{fechaSalida.ToShortDateString()}#, #{fechaDevolucion.ToShortDateString()}#, No, No)";
            return dbManager.ExecuteNonQuery(query);
        }

        public int UpdatePrestamo(int idPrestamo, bool devuelto)
        {
            string query = $"UPDATE VentanaPrestamoLibros SET Devuelto={(devuelto ? "Si" : "No")} " +
                           $"WHERE Id_prestamo={idPrestamo}";
            return dbManager.ExecuteNonQuery(query);
        }

        public int DeletePrestamo(int idPrestamo)
        {
            string query = $"DELETE FROM VentanaPrestamoLibros WHERE Id_prestamo={idPrestamo}";
            return dbManager.ExecuteNonQuery(query);
        }

    }
}
