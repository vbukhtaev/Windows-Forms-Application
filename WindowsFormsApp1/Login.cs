using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text.Length == 0 || passwordTextBox.Text.Length == 0)
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                string returnValue = login();

                if (returnValue.Equals("1"))
                {
                    MessageBox.Show("Вы вошли как администратор!", "Успех");
                    AdminMenu adminMenuForm = new AdminMenu();
                    adminMenuForm.Show();
                }
                else if (returnValue.Equals("0"))
                {
                    int userId = getCurrentUserId();
                    MessageBox.Show("Вы вошли как обычный пользователь!", "Успех");
                    UserMenu userMenuForm = new UserMenu(userId);
                    userMenuForm.Show();
                } 
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int getCurrentUserId()
        {
            try
            {
                sqlConnection.Open();
                sqlCommand_GetUserId.Parameters["@login"].Value = loginTextBox.Text;
                sqlCommand_GetUserId.Parameters["@password"].Value = passwordTextBox.Text;
                sqlCommand_GetUserId.ExecuteNonQuery();
                int currentUserId = (int) sqlCommand_GetUserId.Parameters["@RETURN_VALUE"].Value;
                return currentUserId;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
                return -1;
            }
            finally
            {
                sqlConnection.Close();
                clearFields();
            }
        }

        private string login()
        {
            string returnValue = "-1";

            try
            {
                sqlConnection.Open();
                sqlCommand_LoginUser.Parameters["@login"].Value = loginTextBox.Text;
                sqlCommand_LoginUser.Parameters["@password"].Value = passwordTextBox.Text;
                sqlCommand_LoginUser.ExecuteNonQuery();
                returnValue = sqlCommand_LoginUser.Parameters["@RETURN_VALUE"].Value.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
            }
            finally
            {
                sqlConnection.Close();
            }

            return returnValue;
        }

        private void clearFields()
        {
            loginTextBox.Text = "";
            passwordTextBox.Text = "";
        }
    }
}
