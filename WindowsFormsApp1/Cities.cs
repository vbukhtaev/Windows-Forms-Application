using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Cities : Form
    {
        private DataRow row;

        public Cities()
        {
            InitializeComponent();
        }

        private void CitiesForm_Load(object sender, EventArgs e)
        {
            this.dataSet_SelectAllCities.Clear();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet_SelectAllCities.select_all_city". При необходимости она может быть перемещена или удалена.
            this.select_all_cityTableAdapter.Fill(this.dataSet_SelectAllCities.select_all_city);
        }

        private void CitiesForm_Deactivate(object sender, EventArgs e)
        {
            cityDataAdapter.Update(dataSet_SelectAllCities);
        }

        private void addCityButton_Click(object sender, EventArgs e)
        {
            if ((cityIdTextBox.Text.Length == 0) || (cityNameTextBox.Text.Length == 0))
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                select_all_cityTableAdapter.Fill(dataSet_SelectAllCities.select_all_city);
                sqlConnection.Open();

                try { 
                    insertCityCommand.Parameters["@id"].Value = Convert.ToInt32(cityIdTextBox.Text);
                    insertCityCommand.Parameters["@name"].Value = Convert.ToString(cityNameTextBox.Text);
                    insertCityCommand.ExecuteNonQuery();
                    MessageBox.Show("Город добавлен.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!");
                }
                finally
                {
                    sqlConnection.Close();
                    select_all_cityTableAdapter.Fill(dataSet_SelectAllCities.select_all_city);
                    clearFields();
                }
            }
        }

        public static DataRow GetCurrentRow(DataGridView dg)
        {
            CurrencyManager cm = (CurrencyManager)dg.BindingContext[dg.DataSource, dg.DataMember];
            if (cm.Count == 0) { return null; }
            DataRowView drv = (DataRowView)cm.Current;
            return drv.Row;
        }

        private void findCityButton_Click(object sender, EventArgs e)
        {
            row = GetCurrentRow(citiesDataGridView);
            cityIdTextBox.Text = row["id"].ToString();
            cityNameTextBox.Text = row["name"].ToString();
        }

        private void updateCityButton_Click(object sender, EventArgs e)
        {
            if ((cityIdTextBox.Text.Length == 0) || (cityNameTextBox.Text.Length == 0))
            {
                MessageBox.Show("Заполните все поля!");
            }
            else {
                select_all_cityTableAdapter.Fill(dataSet_SelectAllCities.select_all_city);
                row = GetCurrentRow(citiesDataGridView);
                sqlConnection.Open();

                try {
                    updateCityCommand.Parameters["@id"].Value = Convert.ToInt32(cityIdTextBox.Text);
                    updateCityCommand.Parameters["@name"].Value = Convert.ToString(cityNameTextBox.Text);
                    updateCityCommand.ExecuteNonQuery();
                    MessageBox.Show("Город изменен.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!");
                }
                finally
                {
                    sqlConnection.Close();
                    select_all_cityTableAdapter.Fill(dataSet_SelectAllCities.select_all_city);
                    clearFields();
                }
            }
        }

        private void deleteCityButton_Click(object sender, EventArgs e)
        {
            if (cityIdTextBox.Text.Length == 0)
            {
                MessageBox.Show("Укажите идентификатор города!");
            }
            else
            {
                select_all_cityTableAdapter.Fill(dataSet_SelectAllCities.select_all_city);
                sqlConnection.Open();

                try
                {
                    deleteCityCommand.Parameters["@id"].Value = Convert.ToInt32(cityIdTextBox.Text);
                    deleteCityCommand.ExecuteNonQuery();
                    MessageBox.Show("Город удален.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!");
                }
                finally
                {
                    sqlConnection.Close();
                    select_all_cityTableAdapter.Fill(dataSet_SelectAllCities.select_all_city);
                    clearFields();
                }
            }
        }

        private void clearFields()
        {
            cityIdTextBox.Text = "";
            cityNameTextBox.Text = "";
        }
    }
}
