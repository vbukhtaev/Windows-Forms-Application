using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Flights : Form
    {
        private DataRow row;

        public Flights()
        {
            InitializeComponent();
        }

        private void Flights_Load(object sender, EventArgs e)
        {
            this.dataSet_SelectAllDepartureAirports.Clear();
            this.dataSet_SelectAllDestinationAirports.Clear();
            this.dataSet_SelectAllPlanes.Clear();
            this.dataSet_SelectAllFlights.Clear();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet_SelectAllDestinationAirports.select_all_airport". При необходимости она может быть перемещена или удалена.
            this.select_all_airportTableAdapter1.Fill(this.dataSet_SelectAllDestinationAirports.select_all_airport);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet_SelectAllDepartureAirports.select_all_airport". При необходимости она может быть перемещена или удалена.
            this.select_all_airportTableAdapter.Fill(this.dataSet_SelectAllDepartureAirports.select_all_airport);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet__SelectAllPlanes.select_all_plane". При необходимости она может быть перемещена или удалена.
            this.select_all_planeTableAdapter.Fill(this.dataSet_SelectAllPlanes.select_all_plane);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet_SelectAllFlights.select_all_flight". При необходимости она может быть перемещена или удалена.
            this.select_all_flightTableAdapter.Fill(this.dataSet_SelectAllFlights.select_all_flight);

        }

        private void Flights_Deactivate(object sender, EventArgs e)
        {
            flightDataAdapter.Update(dataSet_SelectAllFlights);
        }

        private void addFlightButton_Click(object sender, EventArgs e)
        {
            if ((flightIdTextBox.Text.Length == 0) ||
                (flightNumberTextBox.Text.Length == 0) ||
                (departureAirportIdComboBox.Text.Length == 0) ||
                (arrivalAirportIdComboBox.Text.Length == 0) ||
                (planeBoardNumberComboBox.Text.Length == 0))
            {
                MessageBox.Show("Заполните все поля!");
            }
            else if (departureAirportIdComboBox.Text.Equals(arrivalAirportIdComboBox.Text))
            {
                MessageBox.Show("Идентификаторы аэропортов не должны совпадать!");
            }
            else
            {
                select_all_flightTableAdapter.Fill(dataSet_SelectAllFlights.select_all_flight);
                sqlConnection.Open();

                try
                {
                    insertFlightCommand.Parameters["@id"].Value = Convert.ToInt32(flightIdTextBox.Text);
                    insertFlightCommand.Parameters["@number"].Value = flightNumberTextBox.Text;
                    insertFlightCommand.Parameters["@departure_date"].Value = departureDateTimePicker.Value;
                    insertFlightCommand.Parameters["@arrival_date"].Value = arrivalDateTimePicker.Value;
                    insertFlightCommand.Parameters["@departure_airport_id"].Value = Convert.ToInt32(departureAirportIdComboBox.SelectedValue.ToString());
                    insertFlightCommand.Parameters["@destination_airport_id"].Value = Convert.ToInt32(arrivalAirportIdComboBox.SelectedValue.ToString());
                    insertFlightCommand.Parameters["@plane_board_number"].Value = planeBoardNumberComboBox.SelectedValue.ToString();
                    insertFlightCommand.ExecuteNonQuery();
                    MessageBox.Show("Авиарейс добавлен.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!");
                }
                finally
                {
                    sqlConnection.Close();
                    select_all_flightTableAdapter.Fill(dataSet_SelectAllFlights.select_all_flight);
                    clearFields();
                }
            }
        }

        private void deleteFlightButton_Click(object sender, EventArgs e)
        {
            if (flightIdTextBox.Text.Length == 0)
            {
                MessageBox.Show("Укажите идентификатор авиарейса!");
            }
            else
            {
                select_all_flightTableAdapter.Fill(dataSet_SelectAllFlights.select_all_flight);
                sqlConnection.Open();

                try
                {
                    deleteFlightCommand.Parameters["@id"].Value = Convert.ToInt32(flightIdTextBox.Text);
                    deleteFlightCommand.ExecuteNonQuery();
                    MessageBox.Show("Авиарейс удален.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!");
                }
                finally
                {
                    sqlConnection.Close();
                    select_all_flightTableAdapter.Fill(dataSet_SelectAllFlights.select_all_flight);
                    clearFields();
                }
            }
        }

        private void updateFlightButton_Click(object sender, EventArgs e)
        {
            if ((flightIdTextBox.Text.Length == 0) ||
                (flightNumberTextBox.Text.Length == 0) ||
                (departureAirportIdComboBox.Text.Length == 0) ||
                (arrivalAirportIdComboBox.Text.Length == 0) ||
                (planeBoardNumberComboBox.Text.Length == 0))
            {
                MessageBox.Show("Заполните все поля!");
            }
            else if (departureAirportIdComboBox.Text.Equals(arrivalAirportIdComboBox.Text))
            {
                MessageBox.Show("Идентификаторы аэропортов не должны совпадать!");
            }
            else
            {
                select_all_flightTableAdapter.Fill(dataSet_SelectAllFlights.select_all_flight);
                row = Cities.GetCurrentRow(flightsDataGridView);
                sqlConnection.Open();

                try
                {
                    updateFlightCommand.Parameters["@id"].Value = Convert.ToInt32(flightIdTextBox.Text);
                    updateFlightCommand.Parameters["@number"].Value = flightNumberTextBox.Text;
                    updateFlightCommand.Parameters["@departure_date"].Value = departureDateTimePicker.Value;
                    updateFlightCommand.Parameters["@arrival_date"].Value = arrivalDateTimePicker.Value;
                    updateFlightCommand.Parameters["@departure_airport_id"].Value = Convert.ToInt32(departureAirportIdComboBox.SelectedValue.ToString());
                    updateFlightCommand.Parameters["@destination_airport_id"].Value = Convert.ToInt32(arrivalAirportIdComboBox.SelectedValue.ToString());
                    updateFlightCommand.Parameters["@plane_board_number"].Value = planeBoardNumberComboBox.SelectedValue.ToString();
                    updateFlightCommand.ExecuteNonQuery();
                    MessageBox.Show("Авиарейс изменен.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!");
                }
                finally
                {
                    sqlConnection.Close();
                    select_all_flightTableAdapter.Fill(dataSet_SelectAllFlights.select_all_flight);
                    clearFields();
                }
            }
        }

        private void findFlightButton_Click(object sender, EventArgs e)
        {
            row = Cities.GetCurrentRow(flightsDataGridView);
            flightIdTextBox.Text = row["id"].ToString();
            flightNumberTextBox.Text = row["number"].ToString();
            departureDateTimePicker.Value = (DateTime) row["departure_date"];
            arrivalDateTimePicker.Value = (DateTime) row["arrival_date"];
            departureAirportIdComboBox.SelectedValue = Convert.ToInt32(row["departure_airport_id"].ToString());
            arrivalAirportIdComboBox.SelectedValue = Convert.ToInt32(row["destination_airport_id"].ToString());
            planeBoardNumberComboBox.SelectedValue = row["plane_board_number"].ToString();
        }

        private void clearFields()
        {
            flightIdTextBox.Text = "";
            flightNumberTextBox.Text = "";
            departureDateTimePicker.Value = DateTime.Now;
            arrivalDateTimePicker.Value = DateTime.Now;
            departureAirportIdComboBox.SelectedIndex = -1;
            arrivalAirportIdComboBox.SelectedIndex = -1;
            planeBoardNumberComboBox.SelectedIndex = -1;
        }
    }
}
