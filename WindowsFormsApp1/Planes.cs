using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Planes : Form
    {
        private DataRow row;

        public Planes()
        {
            InitializeComponent();
        }

        private void Planes_Load(object sender, EventArgs e)
        {
            this.dataSet_SelectAllPlanes.Clear();
            this.dataSet_SelectManufacturerNames.Clear();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet_SelectManufacturerNames.select_all_manufacturer". При необходимости она может быть перемещена или удалена.
            this.select_all_manufacturerTableAdapter.Fill(this.dataSet_SelectManufacturerNames.select_all_manufacturer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet_SelectAllPlanes.select_all_plane". При необходимости она может быть перемещена или удалена.
            this.select_all_planeTableAdapter.Fill(this.dataSet_SelectAllPlanes.select_all_plane);

        }

        private void Planes_Deactivate(Object sender, EventArgs e)
        {
            planeDataAdapter.Update(dataSet_SelectAllPlanes);
        }

        private void addPlaneButton_Click(object sender, EventArgs e)
        {
            if ((boardNumberTextBox.Text.Length == 0) ||
                (manufacturerIdComboBox.Text.Length == 0) ||
                (modelTextBox.Text.Length == 0) ||
                (capacityTextBox.Text.Length == 0))
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                select_all_planeTableAdapter.Fill(dataSet_SelectAllPlanes.select_all_plane);
                sqlConnection.Open();

                try
                {
                    insertPlaneCommand.Parameters["@board_number"].Value = boardNumberTextBox.Text;
                    insertPlaneCommand.Parameters["@manufacturer_id"].Value = Convert.ToInt32(manufacturerIdComboBox.SelectedValue.ToString());
                    insertPlaneCommand.Parameters["@model"].Value = modelTextBox.Text;
                    insertPlaneCommand.Parameters["@capacity"].Value = Convert.ToInt32(capacityTextBox.Text);
                    insertPlaneCommand.ExecuteNonQuery();
                    MessageBox.Show("Самолет добавлен.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!");
                }
                finally
                {
                    sqlConnection.Close();
                    select_all_planeTableAdapter.Fill(dataSet_SelectAllPlanes.select_all_plane);
                    clearFields();
                }
            }
        }

        private void deletePlaneButton_Click(object sender, EventArgs e)
        {
            if (boardNumberTextBox.Text.Length == 0)
            {
                MessageBox.Show("Укажите бортовой номер самолета!");
            }
            else
            {
                select_all_planeTableAdapter.Fill(dataSet_SelectAllPlanes.select_all_plane);
                sqlConnection.Open();

                try
                {
                    deletePlaneCommand.Parameters["@board_number"].Value = boardNumberTextBox.Text;
                    deletePlaneCommand.ExecuteNonQuery();
                    MessageBox.Show("Самолет удален.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!");
                }
                finally
                {
                    sqlConnection.Close();
                    select_all_planeTableAdapter.Fill(dataSet_SelectAllPlanes.select_all_plane);
                    clearFields();
                }
            }
        }

        private void updatePlaneButton_Click(object sender, EventArgs e)
        {
            if ((boardNumberTextBox.Text.Length == 0) ||
                (manufacturerIdComboBox.Text.Length == 0) ||
                (modelTextBox.Text.Length == 0) ||
                (capacityTextBox.Text.Length == 0))
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                select_all_planeTableAdapter.Fill(dataSet_SelectAllPlanes.select_all_plane);
                row = Manufacturers.GetCurrentRow(planesDataGridView);
                sqlConnection.Open();

                try
                {
                    updatePlaneCommand.Parameters["@board_number"].Value = boardNumberTextBox.Text;
                    updatePlaneCommand.Parameters["@manufacturer_id"].Value = Convert.ToInt32(manufacturerIdComboBox.SelectedValue.ToString());
                    updatePlaneCommand.Parameters["@model"].Value = modelTextBox.Text;
                    updatePlaneCommand.Parameters["@capacity"].Value = Convert.ToInt32(capacityTextBox.Text);
                    updatePlaneCommand.ExecuteNonQuery();
                    MessageBox.Show("Самолет изменен.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!");
                }
                finally
                {
                    sqlConnection.Close();
                    select_all_planeTableAdapter.Fill(dataSet_SelectAllPlanes.select_all_plane);
                    clearFields();
                }
            }
        }

        private void findPlaneButton_Click(object sender, EventArgs e)
        {
            row = Manufacturers.GetCurrentRow(planesDataGridView);
            boardNumberTextBox.Text = row["board_number"].ToString();
            manufacturerIdComboBox.SelectedValue = Convert.ToInt32(row["manufacturer_id"].ToString());
            modelTextBox.Text = row["model"].ToString();
            capacityTextBox.Text = row["capacity"].ToString();
        }

        private void clearFields()
        {
            boardNumberTextBox.Text = "";
            modelTextBox.Text = "";
            capacityTextBox.Text = "";
            manufacturerIdComboBox.SelectedIndex = -1;
        }
    }
}
