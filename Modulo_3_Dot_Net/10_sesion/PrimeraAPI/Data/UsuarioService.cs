//Producto Service
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using PrimeraAPI.Models;
using Microsoft.Extensions.Configuration;

namespace PrimeraAPI.Data
{
    public class UsuarioService
    {
        private readonly string _connectionString;

        public UsuarioService(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("TiendaDB");
        }

        //Función para hashear la contraseña
        private string Hash(string pass)
        {
            using var sha = SHA256.Create();

            var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(pass));
            return Convert.ToBase64String(bytes);

        }

        public async Task<bool> RegistroAsync(string username, string password)
        {
            var hash = Hash(password);
            using var connnetion = new SqlConnection(_connectionString);
            await connnetion.OpenAsync();

            var cmd = new SqlCommand(
                "INSERT INTO Usuarios ( NombreUsuario , PasswordHash ) VALUES (@user , @pass)", connnetion
            );
            cmd.Parameters.AddWithValue("@user", username);
            cmd.Parameters.AddWithValue("@pass", hash);
            try
            {
                await cmd.ExecuteNonQueryAsync();
                return true;
            }            
            catch (SqlException ex) when (ex.Number == 2627)
            {
                return false;
            }
            
        }

    }

}
