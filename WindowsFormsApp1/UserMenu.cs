using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class UserMenu : Form
    {
        private int userId;

        private int departureCityId;
        private int destinationCityId;
        private DateTime departureDate;
        private int maxPrice;

        private int availableTicketsCount = 0;

        public UserMenu(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            buyButton.Visible = false;
        }

        private void UserMenu_Load(object sender, EventArgs e)
        {
            this.dataSet_SelectBoughtTickets.Clear();
            this.dataSet_SelectTicketsByParams.Clear();
            this.dataSet_SelectDepartureCitiesForUser.Clear();
            this.dataSet_SelectDestinationCitiesForUser.Clear();

            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet_SelectDestinationCitiesForUser.select_all_city". При необходимости она может быть перемещена или удалена.
            this.select_all_cityTableAdapter1.Fill(this.dataSet_SelectDestinationCitiesForUser.select_all_city);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet_SelectDepartureCitiesForUser.select_all_city". При необходимости она может быть перемещена или удалена.
            this.select_all_cityTableAdapter.Fill(this.dataSet_SelectDepartureCitiesForUser.select_all_city);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet_ViewAllTickets.view_all_tickets". При необходимости она может быть перемещена или удалена.
            this.select_bought_tickets_for_userTableAdapter.Fill(this.dataSet_SelectBoughtTickets.select_bought_tickets_for_user, userId);
        }

        private void UserMenu_Deactivate(object sender, EventArgs e)
        {
            ticketDataAdapter.Update(dataSet_SelectTicketsByParams);
            ticketDataAdapter.Update(dataSet_SelectBoughtTickets);
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)allTicketsDataGridView.BindingContext[allTicketsDataGridView.DataSource, allTicketsDataGridView.DataMember];
            DataRowView drv = (DataRowView)cm.Current;
            
            if (cm.Count == 0)
            {
                return;
            }

            DataRow row = drv.Row;
            int ticketId = (int) row["id"];
            buyTicket(ticketId);
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            if (departureCityIdComboBox.Text.Length == 0 ||
                destinationCityIdComboBox.Text.Length == 0)
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                departureCityId = Convert.ToInt32(departureCityIdComboBox.SelectedValue.ToString());
                destinationCityId = Convert.ToInt32(destinationCityIdComboBox.SelectedValue.ToString());
                departureDate = departureDateTimePicker.Value;

                if (maxPriceTextBox.Text.Equals(""))
                {
                    maxPrice = -1;
                }
                else
                {
                    maxPrice = Convert.ToInt32(maxPriceTextBox.Text);
                }

                select_bought_tickets_for_userTableAdapter.Fill(dataSet_SelectBoughtTickets.select_bought_tickets_for_user, userId);
                availableTicketsCount = find_ticketTableAdapter.Fill(dataSet_SelectTicketsByParams.find_ticket,
                        departureCityId,
                        destinationCityId,
                        departureDate,
                        maxPrice
                    );

                if (availableTicketsCount > 0)
                {
                    buyButton.Visible = true;
                }
                else
                {
                    buyButton.Visible = false;
                }
            }
        }

        private void buyTicket(int ticketId)
        {
            select_bought_tickets_for_userTableAdapter.Fill(dataSet_SelectBoughtTickets.select_bought_tickets_for_user, userId);
            sqlConnection.Open();

            try
            {
                sqlCommand_BuyTicket.Parameters["@id"].Value = ticketId;
                sqlCommand_BuyTicket.Parameters["@user_id"].Value = userId;
                sqlCommand_BuyTicket.ExecuteNonQuery();
                MessageBox.Show("Билет куплен.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
            }
            finally
            {
                sqlConnection.Close();
                select_bought_tickets_for_userTableAdapter.Fill(dataSet_SelectBoughtTickets.select_bought_tickets_for_user, userId);
                availableTicketsCount = find_ticketTableAdapter.Fill(dataSet_SelectTicketsByParams.find_ticket,
                        departureCityId,
                        destinationCityId,
                        departureDate,
                        maxPrice
                    );
                
                if (availableTicketsCount <= 0)
                {
                    buyButton.Visible = false;
                }
            }
        }
    }
}
