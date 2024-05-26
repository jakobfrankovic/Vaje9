using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DataBaseVmesnik
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> categoryMap;
        private SearchParams searchParams;

        public Form1()
        {
            InitializeComponent();
            PopulateCategories();
        }

        private void PopulateCategories()
        {
            // Mapa kategorij, ki povezuje slovenske kategorije z angleškimi imeni
            categoryMap = new Dictionary<string, string>
            {
                { "Kemija", "Chemistry" },
                { "Fizika", "Physics" },
                { "Medicina", "Medicine" },
                { "Literatura", "Literature" },
                { "Mir", "Peace" },
                { "Ekonomija", "Economics" }
            };

            cmbCategory.DataSource = new List<string>(categoryMap.Keys);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchParams = new SearchParams
            {
                YearFrom = txtYearFrom.Text,
                YearTo = txtYearTo.Text,
                Category = cmbCategory.SelectedItem?.ToString()
            };

            if (searchParams.AreParamsValid())
            {
                int yearFrom = int.Parse(searchParams.YearFrom);
                int yearTo = int.Parse(searchParams.YearTo);
                string category = searchParams.GetEnglishCategory(categoryMap);

                if (category != null)
                {
                    try
                    {
                        List<string> results = GetNobelPrizes(yearFrom, yearTo, category);
                        lstResults.Items.Clear();
                        foreach (var result in results)
                        {
                            lstResults.Items.Add(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Izbrana kategorija ni veljavna.");
                }
            }
            else
            {
                MessageBox.Show("Prosim, vnesite pravilne letnice in izberite kategorijo.");
            }
        }

        private List<string> GetNobelPrizes(int yearFrom, int yearTo, string category)
        {
            List<string> results = new List<string>();
            string connectionString = "Data Source=..\\..\\..\\nobelDB.db;Version=3;";

            using (var connection = new System.Data.SQLite.SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM nobel WHERE yr >= @yearFrom AND yr <= @yearTo AND subject = @category";
                    using (var command = new System.Data.SQLite.SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@yearFrom", yearFrom);
                        command.Parameters.AddWithValue("@yearTo", yearTo);
                        command.Parameters.AddWithValue("@category", category);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                results.Add($"{reader["yr"]} - {reader["subject"]} - {reader["winner"]}");
                            }
                        }
                    }
                }
                catch (System.Data.SQLite.SQLiteException ex)
                {
                    throw new Exception("SQL napaka: " + ex.Message);
                }
            }

            return results;
        }
    }
}
