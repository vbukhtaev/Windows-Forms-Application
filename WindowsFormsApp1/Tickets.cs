using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Tickets : Form
    {
        private DataRow row;

        public Tickets()
        {
            InitializeComponent();
        }

        private void Tickets_Load(object sender, EventArgs e)
        {
            this.dataSet_SelectAllFlights.Clear();
            this.dataSet_SelectAllUsers.Clear();
            this.dataSet_SelectAllTickets.Clear();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet_SelectAllUsers.select_all_user". При необходимости она может быть перемещена или удалена.
            this.select_all_userTableAdapter.Fill(this.dataSet_SelectAllUsers.select_all_user);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet___SelectAllFlights.select_all_flight". При необходимости она может быть перемещена или удалена.
            this.select_all_flightTableAdapter.Fill(this.dataSet_SelectAllFlights.select_all_flight);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet_SelectAllTickets.select_all_ticket". При необходимости она может быть перемещена или удалена.
            this.select_all_ticketTableAdapter.Fill(this.dataSet_SelectAllTickets.select_all_ticket);
        }

        private void Tickets_Deactivate(object sender, EventArgs e)
        {
            ticketDataAdapter.Update(dataSet_SelectAllTickets);
        }

        private void addTicketButton_Click(object sender, EventArgs e)
        {
            if ((ticketIdTextBox.Text.Length == 0) ||
                (priceTextBox.Text.Length == 0) ||
                (flightIdComboBox.Text.Length == 0))
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                select_all_ticketTableAdapter.Fill(dataSet_SelectAllTickets.select_all_ticket);
                sqlConnection.Open();

                try
                {
                    insertTicketCommand.Parameters["@id"].Value = Convert.ToInt32(ticketIdTextBox.Text);
                    insertTicketCommand.Parameters["@price"].Value = Convert.ToInt32(priceTextBox.Text);
                    insertTicketCommand.Parameters["@flight_id"].Value = Convert.ToInt32(flightIdComboBox.SelectedValue.ToString());

                    if (userIdComboBox.Text.Length == 0)
                        insertTicketCommand.Parameters["@user_id"].Value = System.DBNull.Value;
                    else
                        insertTicketCommand.Parameters["@user_id"].Value = Convert.ToInt32(userIdComboBox.SelectedValue.ToString());

                    insertTicketCommand.ExecuteNonQuery();
                    MessageBox.Show("Билет добавлен.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!");
                }
                finally
                {
                    sqlConnection.Close();
                    select_all_ticketTableAdapter.Fill(dataSet_SelectAllTickets.select_all_ticket);
                    clearFields();
                }
            }
        }

        private void deleteTicketButton_Click(object sender, EventArgs e)
        {
            if (ticketIdTextBox.Text.Length == 0)
            {
                MessageBox.Show("Укажите идентификатор билета!");
            }
            else
            {
                select_all_ticketTableAdapter.Fill(dataSet_SelectAllTickets.select_all_ticket);
                sqlConnection.Open();

                try
                {
                    deleteTicketCommand.Parameters["@id"].Value = Convert.ToInt32(ticketIdTextBox.Text);
                    deleteTicketCommand.ExecuteNonQuery();
                    MessageBox.Show("Билет удален.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!");
                }
                finally
                {
                    sqlConnection.Close();
                    select_all_ticketTableAdapter.Fill(dataSet_SelectAllTickets.select_all_ticket);
                    clearFields();
                }
            }
        }

        private void updateTicketButton_Click(object sender, EventArgs e)
        {
            if ((ticketIdTextBox.Text.Length == 0) ||
                (priceTextBox.Text.Length == 0) ||
                (flightIdComboBox.Text.Length == 0))
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                select_all_ticketTableAdapter.Fill(dataSet_SelectAllTickets.select_all_ticket);
                row = Cities.GetCurrentRow(ticketsDataGridView);
                sqlConnection.Open();

                try
                {
                    updateTicketCommand.Parameters["@id"].Value = Convert.ToInt32(ticketIdTextBox.Text);
                    updateTicketCommand.Parameters["@price"].Value = Convert.ToInt32(priceTextBox.Text);
                    updateTicketCommand.Parameters["@flight_id"].Value = Convert.ToInt32(flightIdComboBox.SelectedValue.ToString());

                    if (userIdComboBox.Text.Length == 0)
                        updateTicketCommand.Parameters["@user_id"].Value = System.DBNull.Value;
                    else
                        updateTicketCommand.Parameters["@user_id"].Value = Convert.ToInt32(userIdComboBox.SelectedValue.ToString());

                    updateTicketCommand.ExecuteNonQuery();
                    MessageBox.Show("Билет изменен.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!");
                }
                finally
                {
                    sqlConnection.Close();
                    select_all_ticketTableAdapter.Fill(dataSet_SelectAllTickets.select_all_ticket);
                    clearFields();
                }
            }
        }

        private void findTicketButton_Click(object sender, EventArgs e)
        {
            row = Cities.GetCurrentRow(ticketsDataGridView);
            ticketIdTextBox.Text = row["id"].ToString();
            priceTextBox.Text = row["price"].ToString();
            flightIdComboBox.SelectedValue = Convert.ToInt32(row["flight_id"].ToString());

            if (row["user_id"].ToString().Equals(""))
            {
                userIdComboBox.SelectedIndex = -1;
            }
            else
            {
                userIdComboBox.SelectedValue = Convert.ToInt32(row["user_id"].ToString());
            }
            
        }
        private void clearFields()
        {
            ticketIdTextBox.Text = "";
            priceTextBox.Text = "";
            flightIdComboBox.SelectedIndex = -1;
            userIdComboBox.SelectedIndex = -1;
        }
    }
}
