
namespace WindowsFormsApp1
{
    partial class UserMenu
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
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand_SelectBoughtTickets = new System.Data.SqlClient.SqlCommand();
            this.ticketDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand_BuyTicket = new System.Data.SqlClient.SqlCommand();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.allTicketsTabPage = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.maxPriceTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.departureDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.destinationCityIdComboBox = new System.Windows.Forms.ComboBox();
            this.selectallcityBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_SelectDestinationCitiesForUser = new WindowsFormsApp1.DataSet_SelectDestinationCitiesForUser();
            this.departureCityIdComboBox = new System.Windows.Forms.ComboBox();
            this.selectallcityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_SelectDepartureCitiesForUser = new WindowsFormsApp1.DataSet_SelectDepartureCitiesForUser();
            this.findButton = new System.Windows.Forms.Button();
            this.buyButton = new System.Windows.Forms.Button();
            this.allTicketsDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departurecityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureairportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationcityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationairportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departuredateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivaldateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.findticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_SelectTicketsByParams = new WindowsFormsApp1.DataSet_SelectTicketsByParams();
            this.boughtTicketsTabPage = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectboughtticketsforuserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_SelectBoughtTickets = new WindowsFormsApp1.DataSet_SelectBoughtTickets();
            this.select_bought_tickets_for_userTableAdapter = new WindowsFormsApp1.DataSet_SelectBoughtTicketsTableAdapters.select_bought_tickets_for_userTableAdapter();
            this.find_ticketTableAdapter = new WindowsFormsApp1.DataSet_SelectTicketsByParamsTableAdapters.find_ticketTableAdapter();
            this.select_all_cityTableAdapter = new WindowsFormsApp1.DataSet_SelectDepartureCitiesForUserTableAdapters.select_all_cityTableAdapter();
            this.select_all_cityTableAdapter1 = new WindowsFormsApp1.DataSet_SelectDestinationCitiesForUserTableAdapters.select_all_cityTableAdapter();
            this.tabControl.SuspendLayout();
            this.allTicketsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectallcityBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SelectDestinationCitiesForUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectallcityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SelectDepartureCitiesForUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allTicketsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SelectTicketsByParams)).BeginInit();
            this.boughtTicketsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectboughtticketsforuserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SelectBoughtTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlConnection
            // 
            this.sqlConnection.ConnectionString = "Data Source=DESKTOP-3SOCJMQ;Initial Catalog=my_database;Integrated Security=True";
            this.sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand_SelectBoughtTickets
            // 
            this.sqlCommand_SelectBoughtTickets.CommandText = "dbo.select_all_ticket";
            this.sqlCommand_SelectBoughtTickets.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand_SelectBoughtTickets.Connection = this.sqlConnection;
            this.sqlCommand_SelectBoughtTickets.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // ticketDataAdapter
            // 
            this.ticketDataAdapter.SelectCommand = this.sqlCommand_SelectBoughtTickets;
            this.ticketDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "select_all_ticket", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("id", "id"),
                        new System.Data.Common.DataColumnMapping("price", "price"),
                        new System.Data.Common.DataColumnMapping("flight_id", "flight_id"),
                        new System.Data.Common.DataColumnMapping("user_id", "user_id")})});
            this.ticketDataAdapter.UpdateCommand = this.sqlCommand_BuyTicket;
            // 
            // sqlCommand_BuyTicket
            // 
            this.sqlCommand_BuyTicket.CommandText = "dbo.buy_ticket";
            this.sqlCommand_BuyTicket.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand_BuyTicket.Connection = this.sqlConnection;
            this.sqlCommand_BuyTicket.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, "id"),
            new System.Data.SqlClient.SqlParameter("@user_id", System.Data.SqlDbType.Int, 4, "user_id")});
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.allTicketsTabPage);
            this.tabControl.Controls.Add(this.boughtTicketsTabPage);
            this.tabControl.Location = new System.Drawing.Point(14, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1558, 587);
            this.tabControl.TabIndex = 3;
            // 
            // allTicketsTabPage
            // 
            this.allTicketsTabPage.Controls.Add(this.label4);
            this.allTicketsTabPage.Controls.Add(this.maxPriceTextBox);
            this.allTicketsTabPage.Controls.Add(this.label3);
            this.allTicketsTabPage.Controls.Add(this.departureDateTimePicker);
            this.allTicketsTabPage.Controls.Add(this.label2);
            this.allTicketsTabPage.Controls.Add(this.label1);
            this.allTicketsTabPage.Controls.Add(this.destinationCityIdComboBox);
            this.allTicketsTabPage.Controls.Add(this.departureCityIdComboBox);
            this.allTicketsTabPage.Controls.Add(this.findButton);
            this.allTicketsTabPage.Controls.Add(this.buyButton);
            this.allTicketsTabPage.Controls.Add(this.allTicketsDataGridView);
            this.allTicketsTabPage.Location = new System.Drawing.Point(4, 22);
            this.allTicketsTabPage.Name = "allTicketsTabPage";
            this.allTicketsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.allTicketsTabPage.Size = new System.Drawing.Size(1550, 561);
            this.allTicketsTabPage.TabIndex = 0;
            this.allTicketsTabPage.Text = "Все билеты";
            this.allTicketsTabPage.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(613, 506);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Максимальная цена";
            // 
            // maxPriceTextBox
            // 
            this.maxPriceTextBox.Location = new System.Drawing.Point(616, 522);
            this.maxPriceTextBox.Mask = "0000000";
            this.maxPriceTextBox.Name = "maxPriceTextBox";
            this.maxPriceTextBox.Size = new System.Drawing.Size(117, 20);
            this.maxPriceTextBox.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 506);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Дата вылета";
            // 
            // departureDateTimePicker
            // 
            this.departureDateTimePicker.Location = new System.Drawing.Point(392, 522);
            this.departureDateTimePicker.Name = "departureDateTimePicker";
            this.departureDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.departureDateTimePicker.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 506);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Город прилета";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 506);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Город вылета";
            // 
            // destinationCityIdComboBox
            // 
            this.destinationCityIdComboBox.DataSource = this.selectallcityBindingSource1;
            this.destinationCityIdComboBox.DisplayMember = "name";
            this.destinationCityIdComboBox.FormattingEnabled = true;
            this.destinationCityIdComboBox.Location = new System.Drawing.Point(200, 522);
            this.destinationCityIdComboBox.Name = "destinationCityIdComboBox";
            this.destinationCityIdComboBox.Size = new System.Drawing.Size(165, 21);
            this.destinationCityIdComboBox.TabIndex = 58;
            this.destinationCityIdComboBox.ValueMember = "id";
            // 
            // selectallcityBindingSource1
            // 
            this.selectallcityBindingSource1.DataMember = "select_all_city";
            this.selectallcityBindingSource1.DataSource = this.dataSet_SelectDestinationCitiesForUser;
            // 
            // dataSet_SelectDestinationCitiesForUser
            // 
            this.dataSet_SelectDestinationCitiesForUser.DataSetName = "DataSet_SelectDestinationCitiesForUser";
            this.dataSet_SelectDestinationCitiesForUser.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departureCityIdComboBox
            // 
            this.departureCityIdComboBox.DataSource = this.selectallcityBindingSource;
            this.departureCityIdComboBox.DisplayMember = "name";
            this.departureCityIdComboBox.FormattingEnabled = true;
            this.departureCityIdComboBox.Location = new System.Drawing.Point(10, 522);
            this.departureCityIdComboBox.Name = "departureCityIdComboBox";
            this.departureCityIdComboBox.Size = new System.Drawing.Size(165, 21);
            this.departureCityIdComboBox.TabIndex = 57;
            this.departureCityIdComboBox.ValueMember = "id";
            // 
            // selectallcityBindingSource
            // 
            this.selectallcityBindingSource.DataMember = "select_all_city";
            this.selectallcityBindingSource.DataSource = this.dataSet_SelectDepartureCitiesForUser;
            // 
            // dataSet_SelectDepartureCitiesForUser
            // 
            this.dataSet_SelectDepartureCitiesForUser.DataSetName = "DataSet_SelectDepartureCitiesForUser";
            this.dataSet_SelectDepartureCitiesForUser.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(766, 493);
            this.findButton.Margin = new System.Windows.Forms.Padding(2);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(120, 50);
            this.findButton.TabIndex = 56;
            this.findButton.Text = "Найти";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(890, 493);
            this.buyButton.Margin = new System.Windows.Forms.Padding(2);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(120, 50);
            this.buyButton.TabIndex = 55;
            this.buyButton.Text = "Купить";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // allTicketsDataGridView
            // 
            this.allTicketsDataGridView.AutoGenerateColumns = false;
            this.allTicketsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allTicketsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.departurecityDataGridViewTextBoxColumn,
            this.departureairportDataGridViewTextBoxColumn,
            this.destinationcityDataGridViewTextBoxColumn,
            this.destinationairportDataGridViewTextBoxColumn,
            this.departuredateDataGridViewTextBoxColumn,
            this.arrivaldateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.manufacturernameDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn});
            this.allTicketsDataGridView.DataSource = this.findticketBindingSource;
            this.allTicketsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.allTicketsDataGridView.Name = "allTicketsDataGridView";
            this.allTicketsDataGridView.RowHeadersWidth = 51;
            this.allTicketsDataGridView.Size = new System.Drawing.Size(1544, 448);
            this.allTicketsDataGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Идентификатор";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // departurecityDataGridViewTextBoxColumn
            // 
            this.departurecityDataGridViewTextBoxColumn.DataPropertyName = "departure_city";
            this.departurecityDataGridViewTextBoxColumn.HeaderText = "Город вылета";
            this.departurecityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departurecityDataGridViewTextBoxColumn.Name = "departurecityDataGridViewTextBoxColumn";
            this.departurecityDataGridViewTextBoxColumn.Width = 125;
            // 
            // departureairportDataGridViewTextBoxColumn
            // 
            this.departureairportDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.departureairportDataGridViewTextBoxColumn.DataPropertyName = "departure_airport";
            this.departureairportDataGridViewTextBoxColumn.HeaderText = "Аэропорт вылета";
            this.departureairportDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departureairportDataGridViewTextBoxColumn.Name = "departureairportDataGridViewTextBoxColumn";
            this.departureairportDataGridViewTextBoxColumn.Width = 235;
            // 
            // destinationcityDataGridViewTextBoxColumn
            // 
            this.destinationcityDataGridViewTextBoxColumn.DataPropertyName = "destination_city";
            this.destinationcityDataGridViewTextBoxColumn.HeaderText = "Город прилета";
            this.destinationcityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.destinationcityDataGridViewTextBoxColumn.Name = "destinationcityDataGridViewTextBoxColumn";
            this.destinationcityDataGridViewTextBoxColumn.Width = 125;
            // 
            // destinationairportDataGridViewTextBoxColumn
            // 
            this.destinationairportDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.destinationairportDataGridViewTextBoxColumn.DataPropertyName = "destination_airport";
            this.destinationairportDataGridViewTextBoxColumn.HeaderText = "Аэропорт прилета";
            this.destinationairportDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.destinationairportDataGridViewTextBoxColumn.Name = "destinationairportDataGridViewTextBoxColumn";
            this.destinationairportDataGridViewTextBoxColumn.Width = 235;
            // 
            // departuredateDataGridViewTextBoxColumn
            // 
            this.departuredateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.departuredateDataGridViewTextBoxColumn.DataPropertyName = "departure_date";
            this.departuredateDataGridViewTextBoxColumn.HeaderText = "Дата и время вылета";
            this.departuredateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departuredateDataGridViewTextBoxColumn.Name = "departuredateDataGridViewTextBoxColumn";
            this.departuredateDataGridViewTextBoxColumn.Width = 120;
            // 
            // arrivaldateDataGridViewTextBoxColumn
            // 
            this.arrivaldateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.arrivaldateDataGridViewTextBoxColumn.DataPropertyName = "arrival_date";
            this.arrivaldateDataGridViewTextBoxColumn.HeaderText = "Дата и время прилета";
            this.arrivaldateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.arrivaldateDataGridViewTextBoxColumn.Name = "arrivaldateDataGridViewTextBoxColumn";
            this.arrivaldateDataGridViewTextBoxColumn.Width = 120;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 80;
            // 
            // manufacturernameDataGridViewTextBoxColumn
            // 
            this.manufacturernameDataGridViewTextBoxColumn.DataPropertyName = "manufacturer_name";
            this.manufacturernameDataGridViewTextBoxColumn.HeaderText = "Производитель самолета";
            this.manufacturernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.manufacturernameDataGridViewTextBoxColumn.Name = "manufacturernameDataGridViewTextBoxColumn";
            this.manufacturernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Модель самолета";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.Width = 125;
            // 
            // findticketBindingSource
            // 
            this.findticketBindingSource.DataMember = "find_ticket";
            this.findticketBindingSource.DataSource = this.dataSet_SelectTicketsByParams;
            // 
            // dataSet_SelectTicketsByParams
            // 
            this.dataSet_SelectTicketsByParams.DataSetName = "DataSet_SelectTicketsByParams";
            this.dataSet_SelectTicketsByParams.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boughtTicketsTabPage
            // 
            this.boughtTicketsTabPage.Controls.Add(this.dataGridView1);
            this.boughtTicketsTabPage.Location = new System.Drawing.Point(4, 22);
            this.boughtTicketsTabPage.Name = "boughtTicketsTabPage";
            this.boughtTicketsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.boughtTicketsTabPage.Size = new System.Drawing.Size(1550, 561);
            this.boughtTicketsTabPage.TabIndex = 1;
            this.boughtTicketsTabPage.Text = "Купленные билеты";
            this.boughtTicketsTabPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dataGridView1.DataSource = this.selectboughtticketsforuserBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1541, 448);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Идентификатор";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "departure_city";
            this.dataGridViewTextBoxColumn2.HeaderText = "Город вылета";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "departure_airport";
            this.dataGridViewTextBoxColumn3.HeaderText = "Аэропорт вылета";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 160;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "destination_city";
            this.dataGridViewTextBoxColumn4.HeaderText = "Город прилета";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "destination_airport";
            this.dataGridViewTextBoxColumn5.HeaderText = "Аэропорт прилета";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 160;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "departure_date";
            this.dataGridViewTextBoxColumn6.HeaderText = "Дата и время вылета";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "arrival_date";
            this.dataGridViewTextBoxColumn7.HeaderText = "Дата и время прилета";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn8.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 80;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "manufacturer_name";
            this.dataGridViewTextBoxColumn9.HeaderText = "Производитель самолета";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "model";
            this.dataGridViewTextBoxColumn10.HeaderText = "Модель самолета";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // selectboughtticketsforuserBindingSource
            // 
            this.selectboughtticketsforuserBindingSource.DataMember = "select_bought_tickets_for_user";
            this.selectboughtticketsforuserBindingSource.DataSource = this.dataSet_SelectBoughtTickets;
            // 
            // dataSet_SelectBoughtTickets
            // 
            this.dataSet_SelectBoughtTickets.DataSetName = "DataSet_SelectBoughtTickets";
            this.dataSet_SelectBoughtTickets.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // select_bought_tickets_for_userTableAdapter
            // 
            this.select_bought_tickets_for_userTableAdapter.ClearBeforeFill = true;
            // 
            // find_ticketTableAdapter
            // 
            this.find_ticketTableAdapter.ClearBeforeFill = true;
            // 
            // select_all_cityTableAdapter
            // 
            this.select_all_cityTableAdapter.ClearBeforeFill = true;
            // 
            // select_all_cityTableAdapter1
            // 
            this.select_all_cityTableAdapter1.ClearBeforeFill = true;
            // 
            // UserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 611);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserMenu";
            this.Text = "Меню пользователя";
            this.Deactivate += new System.EventHandler(this.UserMenu_Deactivate);
            this.Load += new System.EventHandler(this.UserMenu_Load);
            this.tabControl.ResumeLayout(false);
            this.allTicketsTabPage.ResumeLayout(false);
            this.allTicketsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectallcityBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SelectDestinationCitiesForUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectallcityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SelectDepartureCitiesForUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allTicketsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SelectTicketsByParams)).EndInit();
            this.boughtTicketsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectboughtticketsforuserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SelectBoughtTickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Data.SqlClient.SqlConnection sqlConnection;
        private System.Data.SqlClient.SqlCommand sqlCommand_SelectBoughtTickets;
        private System.Data.SqlClient.SqlDataAdapter ticketDataAdapter;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage allTicketsTabPage;
        private System.Windows.Forms.DataGridView allTicketsDataGridView;
        private System.Windows.Forms.TabPage boughtTicketsTabPage;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.BindingSource selectboughtticketsforuserBindingSource;
        private DataSet_SelectBoughtTickets dataSet_SelectBoughtTickets;
        private DataSet_SelectBoughtTicketsTableAdapters.select_bought_tickets_for_userTableAdapter select_bought_tickets_for_userTableAdapter;
        private System.Data.SqlClient.SqlCommand sqlCommand_BuyTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departurecityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureairportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationcityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationairportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departuredateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivaldateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.BindingSource findticketBindingSource;
        private DataSet_SelectTicketsByParams dataSet_SelectTicketsByParams;
        private DataSet_SelectTicketsByParamsTableAdapters.find_ticketTableAdapter find_ticketTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maxPriceTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker departureDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox destinationCityIdComboBox;
        private System.Windows.Forms.ComboBox departureCityIdComboBox;
        private DataSet_SelectDepartureCitiesForUser dataSet_SelectDepartureCitiesForUser;
        private System.Windows.Forms.BindingSource selectallcityBindingSource;
        private DataSet_SelectDepartureCitiesForUserTableAdapters.select_all_cityTableAdapter select_all_cityTableAdapter;
        private DataSet_SelectDestinationCitiesForUser dataSet_SelectDestinationCitiesForUser;
        private System.Windows.Forms.BindingSource selectallcityBindingSource1;
        private DataSet_SelectDestinationCitiesForUserTableAdapters.select_all_cityTableAdapter select_all_cityTableAdapter1;
    }
}