using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Manufacturers : Form
    {
        private DataRow row;

        public Manufacturers()
        {
            InitializeComponent();
        }

        private void Manufacturers_Load(object sender, EventArgs e)
        {
            this.dataSet_SelectAllManufacturers.Clear();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet_SelectAllManufacturers.select_all_manufacturer". При необходимости она может быть перемещена или удалена.
            this.select_all_manufacturerTableAdapter.Fill(this.dataSet_SelectAllManufacturers.select_all_manufacturer);

        }

        private void ManufacturersForm_Deactivate(object sender, EventArgs e)
        {
            manufacturerDataAdapter.Update(dataSet_SelectAllManufacturers);
        }

        private void addManufacturerButton_Click(object sender, EventArgs e)
        {
            if ((manufacturerIdTextBox.Text.Length == 0) || (manufacturerNameTextBox.Text.Length == 0))
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                select_all_manufacturerTableAdapter.Fill(dataSet_SelectAllManufacturers.select_all_manufacturer);
                sqlConnection.Open();

                try
                {
                    insertManufacturerCommand.Parameters["@id"].Value = Convert.ToInt32(manufacturerIdTextBox.Text);
                    insertManufacturerCommand.Parameters["@name"].Value = Convert.ToString(manufacturerNameTextBox.Text);
                    insertManufacturerCommand.ExecuteNonQuery();
                    MessageBox.Show("Производитель добавлен.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!");
                }
                finally
                {
                    sqlConnection.Close();
                    select_all_manufacturerTableAdapter.Fill(dataSet_SelectAllManufacturers.select_all_manufacturer);
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

        private void deleteManufacturerButton_Click(object sender, EventArgs e)
        {
            if (manufacturerIdTextBox.Text.Length == 0)
            {
                MessageBox.Show("Укажите идентификатор производителя!");
            }
            else
            {
                select_all_manufacturerTableAdapter.Fill(dataSet_SelectAllManufacturers.select_all_manufacturer);
                sqlConnection.Open();

                try
                {
                    deleteManufacturerCommand.Parameters["@id"].Value = Convert.ToInt32(manufacturerIdTextBox.Text);
                    deleteManufacturerCommand.ExecuteNonQuery();
                    MessageBox.Show("Производитель удален.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!");
                }
                finally
                {
                    sqlConnection.Close();
                    select_all_manufacturerTableAdapter.Fill(dataSet_SelectAllManufacturers.select_all_manufacturer);
                    clearFields();
                }
            }
        }

        private void updateManufacturerButton_Click(object sender, EventArgs e)
        {
            if ((manufacturerIdTextBox.Text.Length == 0) || (manufacturerNameTextBox.Text.Length == 0))
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                select_all_manufacturerTableAdapter.Fill(dataSet_SelectAllManufacturers.select_all_manufacturer);
                row = GetCurrentRow(manufacturersDataGridView);
                sqlConnection.Open();

                try
                {
                    updateManufacturerCommand.Parameters["@id"].Value = Convert.ToInt32(manufacturerIdTextBox.Text);
                    updateManufacturerCommand.Parameters["@name"].Value = Convert.ToString(manufacturerNameTextBox.Text);
                    updateManufacturerCommand.ExecuteNonQuery();
                    MessageBox.Show("Производитель изменен.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!");
                }
                finally
                {
                    sqlConnection.Close();
                    select_all_manufacturerTableAdapter.Fill(dataSet_SelectAllManufacturers.select_all_manufacturer);
                    clearFields();
                }
            }
        }

        private void findManufacturerButton_Click(object sender, EventArgs e)
        {
            row = GetCurrentRow(manufacturersDataGridView);
            manufacturerIdTextBox.Text = row["id"].ToString();
            manufacturerNameTextBox.Text = row["name"].ToString();
        }

        private void clearFields()
        {
            manufacturerIdTextBox.Text = "";
            manufacturerNameTextBox.Text = "";
        }
    }
}
