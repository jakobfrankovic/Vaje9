using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace DataBaseVmesnikFilmi
{
    public partial class Form1 : Form
    {
        private SQLiteConnection connection;

        // Konstruktor forme
        public Form1()
        {
            InitializeComponent();
            InitializeDatabase();
        }

        // Inicializacija baze podatkov
        private void InitializeDatabase()
        {
            try
            {
                string connectionString = "Data Source=..\\..\\..\\filmi.sqlite;Version=3;";
                connection = new SQLiteConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Napaka pri inicializaciji baze podatkov: {ex.Message}", "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Dogodek za spremembo besedila v vhodnih poljih
        private void Input_TextChanged(object sender, EventArgs e)
        {
            UpdateResults();
        }

        // Posodobitev rezultatov glede na filtre
        private void UpdateResults()
        {
            try
            {
                string yearFrom = txtYearFrom.Text;
                string yearTo = txtYearTo.Text;
                string ratingFrom = txtRatingFrom.Text;
                string ratingTo = txtRatingTo.Text;
                string lengthFrom = txtLengthFrom.Text;
                string lengthTo = txtLengthTo.Text;

                string query = "SELECT * FROM filmi WHERE 1=1";

                if (!string.IsNullOrEmpty(yearFrom) && int.TryParse(yearFrom, out int yFrom))
                    query += " AND leto >= @yearFrom";
                if (!string.IsNullOrEmpty(yearTo) && int.TryParse(yearTo, out int yTo))
                    query += " AND leto <= @yearTo";
                if (!string.IsNullOrEmpty(ratingFrom) && double.TryParse(ratingFrom, out double rFrom))
                    query += " AND ocena >= @ratingFrom";
                if (!string.IsNullOrEmpty(ratingTo) && double.TryParse(ratingTo, out double rTo))
                    query += " AND ocena <= @ratingTo";
                if (!string.IsNullOrEmpty(lengthFrom) && int.TryParse(lengthFrom, out int lFrom))
                    query += " AND dolzina >= @lengthFrom";
                if (!string.IsNullOrEmpty(lengthTo) && int.TryParse(lengthTo, out int lTo))
                    query += " AND dolzina <= @lengthTo";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    if (!string.IsNullOrEmpty(yearFrom) && int.TryParse(yearFrom, out yFrom))
                        command.Parameters.AddWithValue("@yearFrom", yFrom);
                    if (!string.IsNullOrEmpty(yearTo) && int.TryParse(yearTo, out yTo))
                        command.Parameters.AddWithValue("@yearTo", yTo);
                    if (!string.IsNullOrEmpty(ratingFrom) && double.TryParse(ratingFrom, out rFrom))
                        command.Parameters.AddWithValue("@ratingFrom", rFrom);
                    if (!string.IsNullOrEmpty(ratingTo) && double.TryParse(ratingTo, out rTo))
                        command.Parameters.AddWithValue("@ratingTo", rTo);
                    if (!string.IsNullOrEmpty(lengthFrom) && int.TryParse(lengthFrom, out lFrom))
                        command.Parameters.AddWithValue("@lengthFrom", lFrom);
                    if (!string.IsNullOrEmpty(lengthTo) && int.TryParse(lengthTo, out lTo))
                        command.Parameters.AddWithValue("@lengthTo", lTo);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        lstResults.Items.Clear();
                        while (reader.Read())
                        {
                            lstResults.Items.Add($"{reader["naslov"]} - {reader["leto"]} - {reader["dolzina"]} min - {reader["ocena"]}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Napaka pri pridobivanju podatkov: {ex.Message}", "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
