using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Airports : Form
    {
        private DataRow row;

        public Airports()
        {
            InitializeComponent();
        }

        private void Airports_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet__SelectCitiesForAirports.select_all_city". При необходимости она может быть перемещена или удалена.
            this.select_all_cityTableAdapter.Fill(this.dataSet__SelectCitiesForAirports.select_all_city);
            this.dataSet_SelectAllAirports.Clear();
            this.dataSet__SelectCitiesForAirports.Clear();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet_SelectCityNames.select_all_city". При необходимости она может быть перемещена или удалена.
            this.select_all_cityTableAdapter.Fill(this.dataSet__SelectCitiesForAirports.select_all_city);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet_SelectAllAirports.select_all_airport". При необходимости она может быть перемещена или удалена.
            this.select_all_airportTableAdapter.Fill(this.dataSet_SelectAllAirports.select_all_airport);
        }

        private void Airports_Deactivate(Object sender, EventArgs e)
        {
            airportDataAdapter.Update(dataSet_SelectAllAirports);
        }

        private void addAirportButton_Click(object sender, EventArgs e)
        {
            if ((airportIdTextBox.Text.Length == 0) ||
                (airportNameTextBox.Text.Length == 0) ||
                (terminalsAmountTextBox.Text.Length == 0) ||
                (runwaysAmountTextBox.Text.Length == 0) ||
                (cityIdComboBox.Text.Length == 0))
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                select_all_airportTableAdapter.Fill(dataSet_SelectAllAirports.select_all_airport);
                sqlConnection.Open();

                try
                {
                    insertAirportCommand.Parameters["@id"].Value = Convert.ToInt32(airportIdTextBox.Text);
                    insertAirportCommand.Parameters["@name"].Value = airportNameTextBox.Text;
                    insertAirportCommand.Parameters["@terminals_amount"].Value = Convert.ToInt32(terminalsAmountTextBox.Text);
                    insertAirportCommand.Parameters["@runways_amount"].Value = Convert.ToInt32(runwaysAmountTextBox.Text);
                    insertAirportCommand.Parameters["@city_id"].Value = Convert.ToInt32(cityIdComboBox.SelectedValue.ToString());
                    insertAirportCommand.ExecuteNonQuery();
                    MessageBox.Show("Аэропорт добавлен.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!");
                }
                finally
                {
                    sqlConnection.Close();
                    select_all_airportTableAdapter.Fill(dataSet_SelectAllAirports.select_all_airport);
                    clearFields();
                }
            }
        }

        private void deleteAirportButton_Click(object sender, EventArgs e)
        {
            if (airportIdTextBox.Text.Length == 0)
            {
                MessageBox.Show("Укажите идентификатор аэропорта!");
            }
            else
            {
                select_all_airportTableAdapter.Fill(dataSet_SelectAllAirports.select_all_airport);
                sqlConnection.Open();

                try
                {
                    deleteAirportCommand.Parameters["@id"].Value = Convert.ToInt32(airportIdTextBox.Text);
                    deleteAirportCommand.ExecuteNonQuery();
                    MessageBox.Show("Аэропорт удален.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!");
                }
                finally
                {
                    sqlConnection.Close();
                    select_all_airportTableAdapter.Fill(dataSet_SelectAllAirports.select_all_airport);
                    clearFields();
                }
            }
        }

        private void updateAirportButton_Click(object sender, EventArgs e)
        {
            if ((airportIdTextBox.Text.Length == 0) ||
                (airportNameTextBox.Text.Length == 0) ||
                (terminalsAmountTextBox.Text.Length == 0) ||
                (runwaysAmountTextBox.Text.Length == 0) ||
                (cityIdComboBox.Text.Length == 0))
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                select_all_airportTableAdapter.Fill(dataSet_SelectAllAirports.select_all_airport);
                row = Cities.GetCurrentRow(airportsDataGridView);
                sqlConnection.Open();

                try
                {
                    updateAirportCommand.Parameters["@id"].Value = airportIdTextBox.Text;
                    updateAirportCommand.Parameters["@name"].Value = airportNameTextBox.Text;
                    updateAirportCommand.Parameters["@terminals_amount"].Value = Convert.ToInt32(terminalsAmountTextBox.Text);
                    updateAirportCommand.Parameters["@runways_amount"].Value = Convert.ToInt32(runwaysAmountTextBox.Text);
                    updateAirportCommand.Parameters["@city_id"].Value = Convert.ToInt32(cityIdComboBox.SelectedValue.ToString());
                    updateAirportCommand.ExecuteNonQuery();
                    MessageBox.Show("Аэропорт изменен.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!");
                }
                finally
                {
                    sqlConnection.Close();
                    select_all_airportTableAdapter.Fill(dataSet_SelectAllAirports.select_all_airport);
                    clearFields();
                }
            }
        }

        private void findAirportButton_Click(object sender, EventArgs e)
        {
            row = Cities.GetCurrentRow(airportsDataGridView);
            airportIdTextBox.Text = row["id"].ToString();
            airportNameTextBox.Text = row["name"].ToString();
            terminalsAmountTextBox.Text = row["terminals_amount"].ToString();
            runwaysAmountTextBox.Text = row["runways_amount"].ToString();
            cityIdComboBox.SelectedValue = Convert.ToInt32(row["city_id"].ToString());
        }

        private void clearFields()
        {
            airportIdTextBox.Text = "";
            airportNameTextBox.Text = "";
            terminalsAmountTextBox.Text = "";
            runwaysAmountTextBox.Text = "";
            cityIdComboBox.SelectedIndex = -1;
        }
    }
}
