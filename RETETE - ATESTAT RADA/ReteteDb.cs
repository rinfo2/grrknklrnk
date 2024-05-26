using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using RETETE__ATESTAT_RADA;

public class ReteteDb
{
    private string connectionString;

    public ReteteDb()
    {
        connectionString = ConfigurationManager.ConnectionStrings["ReteteDbConnectionString"].ConnectionString;
    }

    public List<TipReteta> GetTipuriRetete()
    {
        List<TipReteta> tipuriRetete = new List<TipReteta>();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT Id, NumeTip FROM TipuriRetete";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                tipuriRetete.Add(new TipReteta
                {
                    Id = reader.GetInt32(0),
                    NumeTip = reader.GetString(1)
                });
            }
        }

        return tipuriRetete;
    }

    public List<Reteta> GetRetete(string cuvantCheie, int tipId)
    {
        List<Reteta> retete = new List<Reteta>();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT Id, Nume, Descriere, TipId FROM Retete WHERE (Nume LIKE @cuvantCheie OR Descriere LIKE @cuvantCheie) AND TipId = @tipId";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@cuvantCheie", "%" + cuvantCheie + "%");
            command.Parameters.AddWithValue("@tipId", tipId);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                retete.Add(new Reteta
                {
                    Id = reader.GetInt32(0),
                    Nume = reader.GetString(1),
                    Descriere = reader.GetString(2),
                    TipId = reader.GetInt32(3)
                });
            }
        }

        return retete;
    }

    public List<Ingredient> GetIngrediente(int retetaId)
    {
        List<Ingredient> ingrediente = new List<Ingredient>();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT Id, RetetaId, NumeIngredient, Cantitate FROM Ingrediente WHERE RetetaId = @retetaId";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@retetaId", retetaId);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ingrediente.Add(new Ingredient
                {
                    Id = reader.GetInt32(0),
                    RetetaId = reader.GetInt32(1),
                    NumeIngredient = reader.GetString(2),
                    Cantitate = reader.GetString(3)
                });
            }
        }

        return ingrediente;
    }

    public void PopuleazaBazaDeDate()
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            // Populați tabelul TipuriRetete
            string insertTipuriRetete = @"
                INSERT INTO TipuriRetete (NumeTip) VALUES ('Fel Principal');
                INSERT INTO TipuriRetete (NumeTip) VALUES ('Desert');
                INSERT INTO TipuriRetete (NumeTip) VALUES ('Aperitiv');
            ";
            SqlCommand cmdInsertTipuriRetete = new SqlCommand(insertTipuriRetete, connection);
            cmdInsertTipuriRetete.ExecuteNonQuery();

            // Populați tabelul Retete
            string insertRetete = @"
                INSERT INTO Retete (Nume, Descriere, TipId) VALUES ('Spaghete Carbonara', 'Spaghete cu sos de smântână și bacon', 1);
                INSERT INTO Retete (Nume, Descriere, TipId) VALUES ('Cheesecake', 'Prăjitură cu brânză și fructe', 2);
                INSERT INTO Retete (Nume, Descriere, TipId) VALUES ('Bruschette', 'Pâine prăjită cu roșii și busuioc', 3);
            ";
            SqlCommand cmdInsertRetete = new SqlCommand(insertRetete, connection);
            cmdInsertRetete.ExecuteNonQuery();

            // Populați tabelul Ingrediente
            string insertIngrediente = @"
                INSERT INTO Ingrediente (RetetaId, NumeIngredient, Cantitate) VALUES (1, 'Spaghete', '200g');
                INSERT INTO Ingrediente (RetetaId, NumeIngredient, Cantitate) VALUES (1, 'Bacon', '100g');
                INSERT INTO Ingrediente (RetetaId, NumeIngredient, Cantitate) VALUES (1, 'Smântână', '50ml');

                INSERT INTO Ingrediente (RetetaId, NumeIngredient, Cantitate) VALUES (2, 'Brânză de vaci', '200g');
                INSERT INTO Ingrediente (RetetaId, NumeIngredient, Cantitate) VALUES (2, 'Biscuiți digestivi', '100g');
                INSERT INTO Ingrediente (RetetaId, NumeIngredient, Cantitate) VALUES (2, 'Zahăr', '50g');

                INSERT INTO Ingrediente (RetetaId, NumeIngredient, Cantitate) VALUES (3, 'Pâine', '2 felii');
                INSERT INTO Ingrediente (RetetaId, NumeIngredient, Cantitate) VALUES (3, 'Roșii', '1 bucată');
                INSERT INTO Ingrediente (RetetaId, NumeIngredient, Cantitate) VALUES (3, 'Busuioc', '2 frunze');
            ";
            SqlCommand cmdInsertIngrediente = new SqlCommand(insertIngrediente, connection);
            cmdInsertIngrediente.ExecuteNonQuery();
        }
    }
}
