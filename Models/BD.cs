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
    public Figurita seleccionarFiguritasPorID(int id) {

        List<Figurita> figuritas = new List<Figurita>();
        Figurita figurita;
        using (SqlConnection connection = new SqlConnection(_connectionString)) {

            string query = "SELECT * FROM Figuritas WHERE id = @pid";
            figurita = connection.QueryFirstOrDefault<Figurita>(query, new { pid = id });
        }
        return figurita;

    }
    public List<Figurita> abrirSobre()
    {

        List<Figurita> figuritasSobre = new List<Figurita>();
        for (int i = 0; i < 5; i++) {

            Random random = new Random(1, 30);
            figuritasSobre.Add(seleccionarFiguritasPorID(random));

        }
        return figuritasSobre;

    }
}