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

            // Nastavi vir podatkov za ComboBox z imeni kategorij
            cmbCategory.DataSource = new List<string>(categoryMap.Keys);
        }

        // Dogodek za spremembo besedila v txtYearFrom
        private void txtYearFrom_TextChanged(object sender, EventArgs e)
        {
            UpdateResults();
        }

        // Dogodek za spremembo besedila v txtYearTo
        private void txtYearTo_TextChanged(object sender, EventArgs e)
        {
            UpdateResults();
        }

        // Dogodek za spremembo izbranega elementa v cmbCategory
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateResults();
        }

        // Metoda za posodobitev rezultatov
        private void UpdateResults()
        {
            // Nastavi iskalne parametre
            searchParams = new SearchParams
            {
                YearFrom = txtYearFrom.Text,
                YearTo = txtYearTo.Text,
                Category = cmbCategory.SelectedItem?.ToString()
            };

            // Preveri, ali so parametri veljavni
            if (searchParams.AreParamsValid())
            {
                int yearFrom = int.Parse(searchParams.YearFrom);
                int yearTo = int.Parse(searchParams.YearTo);
                string category = searchParams.GetEnglishCategory(categoryMap);

                // Če je kategorija veljavna, pridobi rezultate in jih prikaži
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
                    lstResults.Items.Clear();
                }
            }
            else
            {
                lstResults.Items.Clear();
            }
        }

        // Metoda za pridobivanje Nobelovih nagrad iz baze podatkov
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

    // Razred za iskalne parametre
    public class SearchParams
    {
        public string YearFrom { get; set; }
        public string YearTo { get; set; }
        public string Category { get; set; }

        // Metoda za preverjanje veljavnosti parametrov
        public bool AreParamsValid()
        {
            if (string.IsNullOrEmpty(YearFrom) || string.IsNullOrEmpty(YearTo) || string.IsNullOrEmpty(Category))
            {
                return false;
            }

            if (!int.TryParse(YearFrom, out _) || !int.TryParse(YearTo, out _))
            {
                return false;
            }

            return true;
        }

        // Metoda za pridobivanje angleškega imena kategorije
        public string GetEnglishCategory(Dictionary<string, string> categoryMap)
        {
            if (categoryMap.TryGetValue(Category, out string englishCategory))
            {
                return englishCategory;
            }

            return null;
        }
    }
}
