using System;
using Pet_Amigos.Classes.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Amigos.Services
{
    internal class ProviderService
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\gonza\\Documents\\SudriaGonzalo.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";

        public void CrearTabla()
        {
            string query = @"
            CREATE TABLE IF NOT EXISTS Providers (
            Cuit INT PRIMARY KEY,
            Name NVARCHAR(100),
            Surname NVARCHAR(100),
            Tel NVARCHAR(20),
            Sex NVARCHAR(10),
            Born NVARCHAR(50),
            Addres NVARCHAR(200),
            Email NVARCHAR(100)
        )";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conexion);
                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void InsertarProveedor(ProviderModel provider)
        {
            string query = "INSERT INTO Providers (Cuit, Name, Surname, Tel, Sex, Born, Addres, Email) VALUES (@Cuit, @Name, @Surname, @Tel, @Sex, @Born, @Addres, @Email)";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Cuit", provider.Cuit);
                cmd.Parameters.AddWithValue("@Name", provider.Name);
                cmd.Parameters.AddWithValue("@Surname", provider.Surname);
                cmd.Parameters.AddWithValue("@Tel", provider.Tel);
                cmd.Parameters.AddWithValue("@Sex", provider.Sex);
                cmd.Parameters.AddWithValue("@Born", provider.Born);
                cmd.Parameters.AddWithValue("@Addres", provider.Addres);
                cmd.Parameters.AddWithValue("@Email", provider.Email);

                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
