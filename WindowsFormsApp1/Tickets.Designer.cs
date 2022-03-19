
namespace WindowsFormsApp1
{
    partial class Tickets
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.updateTicketButton = new System.Windows.Forms.Button();
            this.findTicketButton = new System.Windows.Forms.Button();
            this.deleteTicketButton = new System.Windows.Forms.Button();
            this.ticketIdTextBox = new System.Windows.Forms.MaskedTextBox();
            this.flightDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.selectAllFlights = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.ticketDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.deleteTicketCommand = new System.Data.SqlClient.SqlCommand();
            this.insertTicketCommand = new System.Data.SqlClient.SqlCommand();
            this.selectTicketCommand = new System.Data.SqlClient.SqlCommand();
            this.updateTicketCommand = new System.Data.SqlClient.SqlCommand();
            this.ticketsDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectallticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_SelectAllTickets = new WindowsFormsApp1.DataSet_SelectAllTickets();
            this.addTicketButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flightIdComboBox = new System.Windows.Forms.ComboBox();
            this.selectallflightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_SelectAllFlights = new WindowsFormsApp1.DataSet___SelectAllFlights();
            this.userDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.selectAllUsers = new System.Data.SqlClient.SqlCommand();
            this.select_all_ticketTableAdapter = new WindowsFormsApp1.DataSet_SelectAllTicketsTableAdapters.select_all_ticketTableAdapter();
            this.priceTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userIdComboBox = new System.Windows.Forms.ComboBox();
            this.selectalluserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_SelectAllUsers = new WindowsFormsApp1.DataSet_SelectAllUsers();
            this.select_all_flightTableAdapter = new WindowsFormsApp1.DataSet___SelectAllFlightsTableAdapters.select_all_flightTableAdapter();
            this.select_all_userTableAdapter = new WindowsFormsApp1.DataSet_SelectAllUsersTableAdapters.select_all_userTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectallticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SelectAllTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectallflightBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SelectAllFlights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectalluserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SelectAllUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // updateTicketButton
            // 
            this.updateTicketButton.Location = new System.Drawing.Point(543, 79);
            this.updateTicketButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateTicketButton.Name = "updateTicketButton";
            this.updateTicketButton.Size = new System.Drawing.Size(80, 30);
            this.updateTicketButton.TabIndex = 55;
            this.updateTicketButton.Text = "Изменить";
            this.updateTicketButton.UseVisualStyleBackColor = true;
            this.updateTicketButton.Click += new System.EventHandler(this.updateTicketButton_Click);
            // 
            // findTicketButton
            // 
            this.findTicketButton.Location = new System.Drawing.Point(543, 113);
            this.findTicketButton.Margin = new System.Windows.Forms.Padding(2);
            this.findTicketButton.Name = "findTicketButton";
            this.findTicketButton.Size = new System.Drawing.Size(80, 30);
            this.findTicketButton.TabIndex = 54;
            this.findTicketButton.Text = "Найти";
            this.findTicketButton.UseVisualStyleBackColor = true;
            this.findTicketButton.Click += new System.EventHandler(this.findTicketButton_Click);
            // 
            // deleteTicketButton
            // 
            this.deleteTicketButton.Location = new System.Drawing.Point(543, 45);
            this.deleteTicketButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteTicketButton.Name = "deleteTicketButton";
            this.deleteTicketButton.Size = new System.Drawing.Size(80, 30);
            this.deleteTicketButton.TabIndex = 53;
            this.deleteTicketButton.Text = "Удалить";
            this.deleteTicketButton.UseVisualStyleBackColor = true;
            this.deleteTicketButton.Click += new System.EventHandler(this.deleteTicketButton_Click);
            // 
            // ticketIdTextBox
            // 
            this.ticketIdTextBox.Location = new System.Drawing.Point(9, 430);
            this.ticketIdTextBox.Mask = "00000";
            this.ticketIdTextBox.Name = "ticketIdTextBox";
            this.ticketIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.ticketIdTextBox.TabIndex = 47;
            // 
            // flightDataAdapter
            // 
            this.flightDataAdapter.SelectCommand = this.selectAllFlights;
            this.flightDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "select_all_flight", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("id", "id"),
                        new System.Data.Common.DataColumnMapping("number", "number"),
                        new System.Data.Common.DataColumnMapping("departure_date", "departure_date"),
                        new System.Data.Common.DataColumnMapping("arrival_date", "arrival_date"),
                        new System.Data.Common.DataColumnMapping("departure_airport_id", "departure_airport_id"),
                        new System.Data.Common.DataColumnMapping("destination_airport_id", "destination_airport_id"),
                        new System.Data.Common.DataColumnMapping("plane_board_number", "plane_board_number")})});
            // 
            // selectAllFlights
            // 
            this.selectAllFlights.CommandText = "dbo.select_all_flight";
            this.selectAllFlights.CommandType = System.Data.CommandType.StoredProcedure;
            this.selectAllFlights.Connection = this.sqlConnection;
            this.selectAllFlights.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlConnection
            // 
            this.sqlConnection.ConnectionString = "Data Source=DESKTOP-3SOCJMQ;Initial Catalog=my_database;Integrated Security=True";
            this.sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // ticketDataAdapter
            // 
            this.ticketDataAdapter.DeleteCommand = this.deleteTicketCommand;
            this.ticketDataAdapter.InsertCommand = this.insertTicketCommand;
            this.ticketDataAdapter.SelectCommand = this.selectTicketCommand;
            this.ticketDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "select_all_ticket", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("id", "id"),
                        new System.Data.Common.DataColumnMapping("price", "price"),
                        new System.Data.Common.DataColumnMapping("flight_id", "flight_id"),
                        new System.Data.Common.DataColumnMapping("user_id", "user_id")})});
            this.ticketDataAdapter.UpdateCommand = this.updateTicketCommand;
            // 
            // deleteTicketCommand
            // 
            this.deleteTicketCommand.CommandText = "dbo.delete_ticket";
            this.deleteTicketCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.deleteTicketCommand.Connection = this.sqlConnection;
            this.deleteTicketCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, "id")});
            // 
            // insertTicketCommand
            // 
            this.insertTicketCommand.CommandText = "dbo.add_ticket";
            this.insertTicketCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.insertTicketCommand.Connection = this.sqlConnection;
            this.insertTicketCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, "id"),
            new System.Data.SqlClient.SqlParameter("@price", System.Data.SqlDbType.Int, 4, "price"),
            new System.Data.SqlClient.SqlParameter("@flight_id", System.Data.SqlDbType.Int, 4, "flight_id"),
            new System.Data.SqlClient.SqlParameter("@user_id", System.Data.SqlDbType.Int, 4, "user_id")});
            // 
            // selectTicketCommand
            // 
            this.selectTicketCommand.CommandText = "dbo.select_all_ticket";
            this.selectTicketCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.selectTicketCommand.Connection = this.sqlConnection;
            this.selectTicketCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // updateTicketCommand
            // 
            this.updateTicketCommand.CommandText = "dbo.update_ticket";
            this.updateTicketCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.updateTicketCommand.Connection = this.sqlConnection;
            this.updateTicketCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, "id"),
            new System.Data.SqlClient.SqlParameter("@price", System.Data.SqlDbType.Int, 4, "price"),
            new System.Data.SqlClient.SqlParameter("@flight_id", System.Data.SqlDbType.Int, 4, "flight_id"),
            new System.Data.SqlClient.SqlParameter("@user_id", System.Data.SqlDbType.Int, 4, "user_id")});
            // 
            // ticketsDataGridView
            // 
            this.ticketsDataGridView.AutoGenerateColumns = false;
            this.ticketsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.ticketsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.ticketsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.flightidDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn});
            this.ticketsDataGridView.DataSource = this.selectallticketBindingSource;
            this.ticketsDataGridView.Location = new System.Drawing.Point(11, 11);
            this.ticketsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.ticketsDataGridView.Name = "ticketsDataGridView";
            this.ticketsDataGridView.ReadOnly = true;
            this.ticketsDataGridView.RowHeadersWidth = 62;
            this.ticketsDataGridView.RowTemplate.Height = 28;
            this.ticketsDataGridView.Size = new System.Drawing.Size(501, 362);
            this.ticketsDataGridView.TabIndex = 46;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Идентификатор";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 112;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // flightidDataGridViewTextBoxColumn
            // 
            this.flightidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.flightidDataGridViewTextBoxColumn.DataPropertyName = "flight_id";
            this.flightidDataGridViewTextBoxColumn.HeaderText = "Идентификатор авиарейса";
            this.flightidDataGridViewTextBoxColumn.Name = "flightidDataGridViewTextBoxColumn";
            this.flightidDataGridViewTextBoxColumn.ReadOnly = true;
            this.flightidDataGridViewTextBoxColumn.Width = 112;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "Идентификатор купившего пользователя";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.ReadOnly = true;
            this.useridDataGridViewTextBoxColumn.Width = 112;
            // 
            // selectallticketBindingSource
            // 
            this.selectallticketBindingSource.DataMember = "select_all_ticket";
            this.selectallticketBindingSource.DataSource = this.dataSet_SelectAllTickets;
            // 
            // dataSet_SelectAllTickets
            // 
            this.dataSet_SelectAllTickets.DataSetName = "DataSet_SelectAllTickets";
            this.dataSet_SelectAllTickets.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addTicketButton
            // 
            this.addTicketButton.Location = new System.Drawing.Point(543, 11);
            this.addTicketButton.Margin = new System.Windows.Forms.Padding(2);
            this.addTicketButton.Name = "addTicketButton";
            this.addTicketButton.Size = new System.Drawing.Size(80, 30);
            this.addTicketButton.TabIndex = 52;
            this.addTicketButton.Text = "Добавить";
            this.addTicketButton.UseVisualStyleBackColor = true;
            this.addTicketButton.Click += new System.EventHandler(this.addTicketButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 401);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 26);
            this.label5.TabIndex = 45;
            this.label5.Text = "Идентификатор\r\nавиарейса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 401);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 26);
            this.label2.TabIndex = 44;
            this.label2.Text = "Цена\r\nбилета";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 401);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 26);
            this.label1.TabIndex = 43;
            this.label1.Text = "Идентификатор\r\nбилета";
            // 
            // flightIdComboBox
            // 
            this.flightIdComboBox.DataSource = this.selectallflightBindingSource;
            this.flightIdComboBox.DisplayMember = "id";
            this.flightIdComboBox.FormattingEnabled = true;
            this.flightIdComboBox.Location = new System.Drawing.Point(250, 429);
            this.flightIdComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.flightIdComboBox.Name = "flightIdComboBox";
            this.flightIdComboBox.Size = new System.Drawing.Size(84, 21);
            this.flightIdComboBox.TabIndex = 42;
            this.flightIdComboBox.ValueMember = "id";
            // 
            // selectallflightBindingSource
            // 
            this.selectallflightBindingSource.DataMember = "select_all_flight";
            this.selectallflightBindingSource.DataSource = this.dataSet_SelectAllFlights;
            // 
            // dataSet_SelectAllFlights
            // 
            this.dataSet_SelectAllFlights.DataSetName = "DataSet_SelectAllFlights";
            this.dataSet_SelectAllFlights.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userDataAdapter
            // 
            this.userDataAdapter.SelectCommand = this.selectAllUsers;
            this.userDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "select_all_user", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("id", "id"),
                        new System.Data.Common.DataColumnMapping("login", "login"),
                        new System.Data.Common.DataColumnMapping("password", "password"),
                        new System.Data.Common.DataColumnMapping("is_admin", "is_admin")})});
            // 
            // selectAllUsers
            // 
            this.selectAllUsers.CommandText = "dbo.select_all_user";
            this.selectAllUsers.CommandType = System.Data.CommandType.StoredProcedure;
            this.selectAllUsers.Connection = this.sqlConnection;
            this.selectAllUsers.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // select_all_ticketTableAdapter
            // 
            this.select_all_ticketTableAdapter.ClearBeforeFill = true;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(129, 430);
            this.priceTextBox.Mask = "0000000";
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 401);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 26);
            this.label3.TabIndex = 58;
            this.label3.Text = "Идентификатор\r\nкупившего пользователя";
            // 
            // userIdComboBox
            // 
            this.userIdComboBox.DataSource = this.selectalluserBindingSource;
            this.userIdComboBox.DisplayMember = "id";
            this.userIdComboBox.FormattingEnabled = true;
            this.userIdComboBox.Location = new System.Drawing.Point(358, 429);
            this.userIdComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.userIdComboBox.Name = "userIdComboBox";
            this.userIdComboBox.Size = new System.Drawing.Size(84, 21);
            this.userIdComboBox.TabIndex = 57;
            this.userIdComboBox.ValueMember = "id";
            // 
            // selectalluserBindingSource
            // 
            this.selectalluserBindingSource.DataMember = "select_all_user";
            this.selectalluserBindingSource.DataSource = this.dataSet_SelectAllUsers;
            // 
            // dataSet_SelectAllUsers
            // 
            this.dataSet_SelectAllUsers.DataSetName = "DataSet_SelectAllUsers";
            this.dataSet_SelectAllUsers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // select_all_flightTableAdapter
            // 
            this.select_all_flightTableAdapter.ClearBeforeFill = true;
            // 
            // select_all_userTableAdapter
            // 
            this.select_all_userTableAdapter.ClearBeforeFill = true;
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userIdComboBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.updateTicketButton);
            this.Controls.Add(this.findTicketButton);
            this.Controls.Add(this.deleteTicketButton);
            this.Controls.Add(this.ticketIdTextBox);
            this.Controls.Add(this.ticketsDataGridView);
            this.Controls.Add(this.addTicketButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flightIdComboBox);
            this.Name = "Tickets";
            this.Text = "Билеты";
            this.Deactivate += new System.EventHandler(this.Tickets_Deactivate);
            this.Load += new System.EventHandler(this.Tickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticketsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectallticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SelectAllTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectallflightBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SelectAllFlights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectalluserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SelectAllUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button updateTicketButton;
        private System.Windows.Forms.Button findTicketButton;
        private System.Windows.Forms.Button deleteTicketButton;
        private System.Windows.Forms.MaskedTextBox ticketIdTextBox;
        private System.Data.SqlClient.SqlDataAdapter flightDataAdapter;
        private System.Data.SqlClient.SqlCommand selectAllFlights;
        private System.Data.SqlClient.SqlConnection sqlConnection;
        private System.Data.SqlClient.SqlDataAdapter ticketDataAdapter;
        private System.Data.SqlClient.SqlCommand deleteTicketCommand;
        private System.Data.SqlClient.SqlCommand insertTicketCommand;
        private System.Data.SqlClient.SqlCommand selectTicketCommand;
        private System.Data.SqlClient.SqlCommand updateTicketCommand;
        private System.Windows.Forms.DataGridView ticketsDataGridView;
        private System.Windows.Forms.Button addTicketButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox flightIdComboBox;
        private System.Data.SqlClient.SqlDataAdapter userDataAdapter;
        private System.Data.SqlClient.SqlCommand selectAllUsers;
        private DataSet_SelectAllTickets dataSet_SelectAllTickets;
        private System.Windows.Forms.BindingSource selectallticketBindingSource;
        private DataSet_SelectAllTicketsTableAdapters.select_all_ticketTableAdapter select_all_ticketTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox priceTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox userIdComboBox;
        private DataSet___SelectAllFlights dataSet_SelectAllFlights;
        private System.Windows.Forms.BindingSource selectallflightBindingSource;
        private DataSet___SelectAllFlightsTableAdapters.select_all_flightTableAdapter select_all_flightTableAdapter;
        private DataSet_SelectAllUsers dataSet_SelectAllUsers;
        private System.Windows.Forms.BindingSource selectalluserBindingSource;
        private DataSet_SelectAllUsersTableAdapters.select_all_userTableAdapter select_all_userTableAdapter;
    }
}