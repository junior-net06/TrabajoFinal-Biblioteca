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
            string query = "SELECT * FROM Libros";
            return dbManager.ExecuteQuery(query);
        }

        public DataTable GetLibroByName(string nombre)
        {
            string query = $"SELECT * FROM Libros WHERE Titulos like '%{nombre}%'";
            return dbManager.ExecuteQuery(query);
        }

        public DataTable GetLibroByAuthor(string autor)
        {
            string query = $"SELECT * FROM Libros WHERE Autor like '%{autor}%'";
            return dbManager.ExecuteQuery(query);
        }

        public DataTable GetLibroByCode(string code)
        {
            string query = $"SELECT * FROM Libros WHERE ISBN = '{code}'";
            return dbManager.ExecuteQuery(query);
        }


        public int InsertLibro(string titulo, string autor, string editora, DateTime fechaPublicacion, string isbn)
        {
            string query = $"INSERT INTO Libros (Titulos, Autor, Editora, Fecha_Publicacion, ISBN) " +
                           $"VALUES ('{titulo}', '{autor}', '{editora}', #{fechaPublicacion.ToShortDateString()}#, '{isbn}')";
            return dbManager.ExecuteNonQuery(query);
        }

        public int UpdateLibro(int idLibro, string titulo, string autor, string editora, DateTime fechaPublicacion, string isbn)
        {
            string query = $"UPDATE Libros SET Titulos='{titulo}', Autor='{autor}', Editora='{editora}', " +
                           $"Fecha_Publicacion=#{fechaPublicacion.ToShortDateString()}#, ISBN='{isbn}' " +
                           $"WHERE Id_libros={idLibro}";
            return dbManager.ExecuteNonQuery(query);
        }

        public int DeleteLibro(int idLibro)
        {
            string query = $"DELETE FROM Libros WHERE Id_libros={idLibro}";
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
                           $"WHERE Id_usuarios={idUsuario}";
            return dbManager.ExecuteNonQuery(query);
        }

        public int DeleteUsuario(int idUsuario)
        {
            string query = $"DELETE FROM Usuarios WHERE Id_usuarios={idUsuario}";
            return dbManager.ExecuteNonQuery(query);
        }

        //operaciones CRUD sobre tabla estudiantes
        public DataTable GetAllEstudiantes()
        {
            string query = "SELECT * FROM Estuadiantes";
            return dbManager.ExecuteQuery(query);
        }

        public DataTable GetEstudiante(string matricula)
        {
            string query = $"SELECT * FROM Estuadiantes WHERE matricula = '{matricula}'";
            return dbManager.ExecuteQuery(query);
        }


        public int InsertEstudiante(string nombre, string apellido, string direccion, string matricula)
        {
            string query = $"INSERT INTO Estuadiantes (Nombre, Apellido, Direccion, Matricula) " +
                           $"VALUES ('{nombre}', '{apellido}', '{direccion}', '{matricula}')";
            return dbManager.ExecuteNonQuery(query);
        }

        public int UpdateEstudiante(int idEstudiante, string nombre, string apellido, string direccion, string matricula)
        {
            string query = $"UPDATE Estuadiantes SET Nombre='{nombre}', Apellido='{apellido}', " +
                           $"Direccion='{direccion}', Matricula='{matricula}' " +
                           $"WHERE Id_estudiantes={idEstudiante}";
            return dbManager.ExecuteNonQuery(query);
        }

        public int DeleteEstudiante(int idEstudiante)
        {
            string query = $"DELETE FROM Estuadiantes WHERE Id_estudiantes={idEstudiante}";
            return dbManager.ExecuteNonQuery(query);
        }

        //Operaciones CRUD sobre tabla prestamos
        public DataTable GetAllPrestamos()
        {
            string query = "SELECT * FROM Prestamo";
            return dbManager.ExecuteQuery(query);
        }

        public int InsertPrestamo(int idLibro, int idEstudiante, DateTime fechaSalida, DateTime fechaDevolucion)
        {
            string fechaSalidaFormateada = fechaSalida.ToString("yyyy-MM-dd HH:mm:ss");
            string fechaDevolucionFormateada = fechaDevolucion.ToString("yyyy-MM-dd HH:mm:ss");

            string query = $"INSERT INTO Prestamo (Id_libro, id_estudiante, Fecha_Salida, Fecha_devolucion) " +
                           $"VALUES ({idLibro}, {idEstudiante}, #{fechaSalidaFormateada}#, #{fechaDevolucionFormateada}#)";

            return dbManager.ExecuteNonQuery(query);
        }

        public int UpdatePrestamo(int idPrestamo, bool devuelto)
        {
            string query = $"UPDATE Prestamo SET Devuelto={(devuelto ? "Si" : "No")} " +
                           $"WHERE Id_prestamo={idPrestamo}";
            return dbManager.ExecuteNonQuery(query);
        }

        public int DeletePrestamo(int idPrestamo)
        {
            string query = $"DELETE FROM Prestamo WHERE Id_prestamo={idPrestamo}";
            return dbManager.ExecuteNonQuery(query);
        }

    }
}
