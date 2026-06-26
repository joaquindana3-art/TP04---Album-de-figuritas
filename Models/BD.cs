namespace TP04.Models;
using Microsoft.Data.SqlClient;
using Dapper;

public class BD
{
    
    private string _connectionString = @"Server=localhost;DataBase=Album;Integrated Security=true;TrustServerCertificate=true";
    public void crearFigurita(Figurita figurita) {

        string query = "INSERT INTO Figuritas (idJugador) VALUES (@pidJugador)";
        using (SqlConnection connection = new SqlConnection(_connectionString)) {

            connection.Execute(query, new {@pidJugador = figurita.idJugador});

        }

    }
    public List<Figurita> seleccionarFiguritas() {

        List<Figurita> figuritas = new List<Figurita>();
        using (SqlConnection connection = new SqlConnection(_connectionString)) {

            string query = "SELECT * FROM Figuritas";
            figuritas = connection.Query<Figurita>(query).ToList();

        }
        return figuritas;

    }

}