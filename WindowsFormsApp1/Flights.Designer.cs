
namespace WindowsFormsApp1
{
    partial class Flights
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
            this.updateFlightButton = new System.Windows.Forms.Button();
            this.findFlightButton = new System.Windows.Forms.Button();
            this.deleteFlightButton = new System.Windows.Forms.Button();
            this.flightIdTextBox = new System.Windows.Forms.MaskedTextBox();
            this.airportDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.selectAllAirports = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.flightDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.deleteFlightCommand = new System.Data.SqlClient.SqlCommand();
            this.insertFlightCommand = new System.Data.SqlClient.SqlCommand();
            this.selectFlightCommand = new System.Data.SqlClient.SqlCommand();
            this.updateFlightCommand = new System.Data.SqlClient.SqlCommand();
            this.flightsDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departuredateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivaldateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureairportidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationairportidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planeboardnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectallflightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_SelectAllFlights = new WindowsFormsApp1.DataSet__SelectAllFlights();
            this.addFlightButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.departureAirportIdComboBox = new System.Windows.Forms.ComboBox();
            this.selectallairportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_SelectAllDepartureAirports = new WindowsFormsApp1.DataSet_SelectAllDepartureAirports();
            this.flightNumberTextBox = new System.Windows.Forms.TextBox();
            this.planeDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.selectAllPlanes = new System.Data.SqlClient.SqlCommand();
            this.select_all_flightTableAdapter = new WindowsFormsApp1.DataSet__SelectAllFlightsTableAdapters.select_all_flightTableAdapter();
            this.departureDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.arrivalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.arrivalAirportIdComboBox = new System.Windows.Forms.ComboBox();
            this.selectallairportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_SelectAllDestinationAirports = new WindowsFormsApp1.DataSet_SelectAllDestinationAirports();
            this.label9 = new System.Windows.Forms.Label();
            this.planeBoardNumberComboBox = new System.Windows.Forms.ComboBox();
            this.selectallplaneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_SelectAllPlanes = new WindowsFormsApp1.DataSet__SelectAllPlanes();
            this.select_all_planeTableAdapter = new WindowsFormsApp1.DataSet__SelectAllPlanesTableAdapters.select_all_planeTableAdapter();
            this.select_all_airportTableAdapter = new WindowsFormsApp1.DataSet_SelectAllDepartureAirportsTableAdapters.select_all_airportTableAdapter();
            this.select_all_airportTableAdapter1 = new WindowsFormsApp1.DataSet_SelectAllDestinationAirportsTableAdapters.select_all_airportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.flightsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectallflightBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SelectAllFlights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectallairportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SelectAllDepartureAirports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectallairportBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SelectAllDestinationAirports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectallplaneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SelectAllPlanes)).BeginInit();
            this.SuspendLayout();
            // 
            // updateFlightButton
            // 
            this.updateFlightButton.Location = new System.Drawing.Point(999, 79);
            this.updateFlightButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateFlightButton.Name = "updateFlightButton";
            this.updateFlightButton.Size = new System.Drawing.Size(80, 30);
            this.updateFlightButton.TabIndex = 55;
            this.updateFlightButton.Text = "Изменить";
            this.updateFlightButton.UseVisualStyleBackColor = true;
            this.updateFlightButton.Click += new System.EventHandler(this.updateFlightButton_Click);
            // 
            // findFlightButton
            // 
            this.findFlightButton.Location = new System.Drawing.Point(999, 113);
            this.findFlightButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.findFlightButton.Name = "findFlightButton";
            this.findFlightButton.Size = new System.Drawing.Size(80, 30);
            this.findFlightButton.TabIndex = 54;
            this.findFlightButton.Text = "Найти";
            this.findFlightButton.UseVisualStyleBackColor = true;
            this.findFlightButton.Click += new System.EventHandler(this.findFlightButton_Click);
            // 
            // deleteFlightButton
            // 
            this.deleteFlightButton.Location = new System.Drawing.Point(999, 45);
            this.deleteFlightButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteFlightButton.Name = "deleteFlightButton";
            this.deleteFlightButton.Size = new System.Drawing.Size(80, 30);
            this.deleteFlightButton.TabIndex = 53;
            this.deleteFlightButton.Text = "Удалить";
            this.deleteFlightButton.UseVisualStyleBackColor = true;
            this.deleteFlightButton.Click += new System.EventHandler(this.deleteFlightButton_Click);
            // 
            // flightIdTextBox
            // 
            this.flightIdTextBox.Location = new System.Drawing.Point(9, 463);
            this.flightIdTextBox.Mask = "00000";
            this.flightIdTextBox.Name = "flightIdTextBox";
            this.flightIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.flightIdTextBox.TabIndex = 47;
            // 
            // airportDataAdapter
            // 
            this.airportDataAdapter.SelectCommand = this.selectAllAirports;
            this.airportDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "select_all_airport", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("id", "id"),
                        new System.Data.Common.DataColumnMapping("name", "name"),
                        new System.Data.Common.DataColumnMapping("terminals_amount", "terminals_amount"),
                        new System.Data.Common.DataColumnMapping("runways_amount", "runways_amount"),
                        new System.Data.Common.DataColumnMapping("city_id", "city_id")})});
            // 
            // selectAllAirports
            // 
            this.selectAllAirports.CommandText = "dbo.select_all_airport";
            this.selectAllAirports.CommandType = System.Data.CommandType.StoredProcedure;
            this.selectAllAirports.Connection = this.sqlConnection;
            this.selectAllAirports.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlConnection
            // 
            this.sqlConnection.ConnectionString = "Data Source=DESKTOP-3SOCJMQ;Initial Catalog=my_database;Integrated Security=True";
            this.sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // flightDataAdapter
            // 
            this.flightDataAdapter.DeleteCommand = this.deleteFlightCommand;
            this.flightDataAdapter.InsertCommand = this.insertFlightCommand;
            this.flightDataAdapter.SelectCommand = this.selectFlightCommand;
            this.flightDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "select_all_flight", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("id", "id"),
                        new System.Data.Common.DataColumnMapping("number", "number"),
                        new System.Data.Common.DataColumnMapping("departure_date", "departure_date"),
                        new System.Data.Common.DataColumnMapping("arrival_date", "arrival_date"),
                        new System.Data.Common.DataColumnMapping("departure_airport_id", "departure_airport_id"),
                        new System.Data.Common.DataColumnMapping("destination_airport_id", "destination_airport_id"),
                        new System.Data.Common.DataColumnMapping("plane_board_number", "plane_board_number")})});
            this.flightDataAdapter.UpdateCommand = this.updateFlightCommand;
            // 
            // deleteFlightCommand
            // 
            this.deleteFlightCommand.CommandText = "dbo.delete_flight";
            this.deleteFlightCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.deleteFlightCommand.Connection = this.sqlConnection;
            this.deleteFlightCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, "id")});
            // 
            // insertFlightCommand
            // 
            this.insertFlightCommand.CommandText = "dbo.add_flight";
            this.insertFlightCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.insertFlightCommand.Connection = this.sqlConnection;
            this.insertFlightCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, "id"),
            new System.Data.SqlClient.SqlParameter("@number", System.Data.SqlDbType.VarChar, 20, "number"),
            new System.Data.SqlClient.SqlParameter("@departure_date", System.Data.SqlDbType.DateTime, 8, "departure_date"),
            new System.Data.SqlClient.SqlParameter("@arrival_date", System.Data.SqlDbType.DateTime, 8, "arrival_date"),
            new System.Data.SqlClient.SqlParameter("@departure_airport_id", System.Data.SqlDbType.SmallInt, 2, "departure_airport_id"),
            new System.Data.SqlClient.SqlParameter("@destination_airport_id", System.Data.SqlDbType.SmallInt, 2, "destination_airport_id"),
            new System.Data.SqlClient.SqlParameter("@plane_board_number", System.Data.SqlDbType.VarChar, 10, "plane_board_number")});
            // 
            // selectFlightCommand
            // 
            this.selectFlightCommand.CommandText = "dbo.select_all_flight";
            this.selectFlightCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.selectFlightCommand.Connection = this.sqlConnection;
            this.selectFlightCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // updateFlightCommand
            // 
            this.updateFlightCommand.CommandText = "dbo.update_flight";
            this.updateFlightCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.updateFlightCommand.Connection = this.sqlConnection;
            this.updateFlightCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, "id"),
            new System.Data.SqlClient.SqlParameter("@number", System.Data.SqlDbType.VarChar, 20, "number"),
            new System.Data.SqlClient.SqlParameter("@departure_date", System.Data.SqlDbType.DateTime, 8, "departure_date"),
            new System.Data.SqlClient.SqlParameter("@arrival_date", System.Data.SqlDbType.DateTime, 8, "arrival_date"),
            new System.Data.SqlClient.SqlParameter("@departure_airport_id", System.Data.SqlDbType.SmallInt, 2, "departure_airport_id"),
            new System.Data.SqlClient.SqlParameter("@destination_airport_id", System.Data.SqlDbType.SmallInt, 2, "destination_airport_id"),
            new System.Data.SqlClient.SqlParameter("@plane_board_number", System.Data.SqlDbType.VarChar, 10, "plane_board_number")});
            // 
            // flightsDataGridView
            // 
            this.flightsDataGridView.AutoGenerateColumns = false;
            this.flightsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.flightsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.flightsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.departuredateDataGridViewTextBoxColumn,
            this.arrivaldateDataGridViewTextBoxColumn,
            this.departureairportidDataGridViewTextBoxColumn,
            this.destinationairportidDataGridViewTextBoxColumn,
            this.planeboardnumberDataGridViewTextBoxColumn});
            this.flightsDataGridView.DataSource = this.selectallflightBindingSource;
            this.flightsDataGridView.Location = new System.Drawing.Point(11, 11);
            this.flightsDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flightsDataGridView.Name = "flightsDataGridView";
            this.flightsDataGridView.ReadOnly = true;
            this.flightsDataGridView.RowHeadersWidth = 62;
            this.flightsDataGridView.RowTemplate.Height = 28;
            this.flightsDataGridView.Size = new System.Drawing.Size(938, 389);
            this.flightsDataGridView.TabIndex = 46;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Идентификатор";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Номер авиарейса";
            this.numberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberDataGridViewTextBoxColumn.Width = 70;
            // 
            // departuredateDataGridViewTextBoxColumn
            // 
            this.departuredateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.departuredateDataGridViewTextBoxColumn.DataPropertyName = "departure_date";
            this.departuredateDataGridViewTextBoxColumn.HeaderText = "Дата и время вылета";
            this.departuredateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departuredateDataGridViewTextBoxColumn.Name = "departuredateDataGridViewTextBoxColumn";
            this.departuredateDataGridViewTextBoxColumn.ReadOnly = true;
            this.departuredateDataGridViewTextBoxColumn.Width = 150;
            // 
            // arrivaldateDataGridViewTextBoxColumn
            // 
            this.arrivaldateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.arrivaldateDataGridViewTextBoxColumn.DataPropertyName = "arrival_date";
            this.arrivaldateDataGridViewTextBoxColumn.HeaderText = "Дата и время прилета";
            this.arrivaldateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.arrivaldateDataGridViewTextBoxColumn.Name = "arrivaldateDataGridViewTextBoxColumn";
            this.arrivaldateDataGridViewTextBoxColumn.ReadOnly = true;
            this.arrivaldateDataGridViewTextBoxColumn.Width = 150;
            // 
            // departureairportidDataGridViewTextBoxColumn
            // 
            this.departureairportidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.departureairportidDataGridViewTextBoxColumn.DataPropertyName = "departure_airport_id";
            this.departureairportidDataGridViewTextBoxColumn.HeaderText = "Идентификатор аэропорта вылета";
            this.departureairportidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departureairportidDataGridViewTextBoxColumn.Name = "departureairportidDataGridViewTextBoxColumn";
            this.departureairportidDataGridViewTextBoxColumn.ReadOnly = true;
            this.departureairportidDataGridViewTextBoxColumn.Width = 125;
            // 
            // destinationairportidDataGridViewTextBoxColumn
            // 
            this.destinationairportidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.destinationairportidDataGridViewTextBoxColumn.DataPropertyName = "destination_airport_id";
            this.destinationairportidDataGridViewTextBoxColumn.HeaderText = "Идентификатор аэропорта прилета";
            this.destinationairportidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.destinationairportidDataGridViewTextBoxColumn.Name = "destinationairportidDataGridViewTextBoxColumn";
            this.destinationairportidDataGridViewTextBoxColumn.ReadOnly = true;
            this.destinationairportidDataGridViewTextBoxColumn.Width = 125;
            // 
            // planeboardnumberDataGridViewTextBoxColumn
            // 
            this.planeboardnumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.planeboardnumberDataGridViewTextBoxColumn.DataPropertyName = "plane_board_number";
            this.planeboardnumberDataGridViewTextBoxColumn.HeaderText = "Бортовой номер самолета";
            this.planeboardnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.planeboardnumberDataGridViewTextBoxColumn.Name = "planeboardnumberDataGridViewTextBoxColumn";
            this.planeboardnumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.planeboardnumberDataGridViewTextBoxColumn.Width = 125;
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
            // addFlightButton
            // 
            this.addFlightButton.Location = new System.Drawing.Point(999, 11);
            this.addFlightButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addFlightButton.Name = "addFlightButton";
            this.addFlightButton.Size = new System.Drawing.Size(80, 30);
            this.addFlightButton.TabIndex = 52;
            this.addFlightButton.Text = "Добавить";
            this.addFlightButton.UseVisualStyleBackColor = true;
            this.addFlightButton.Click += new System.EventHandler(this.addFlightButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 434);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 26);
            this.label5.TabIndex = 45;
            this.label5.Text = "Идентификатор\r\nаэропорта вылета";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 434);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 26);
            this.label2.TabIndex = 44;
            this.label2.Text = "Номер\r\nавиарейса";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 434);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 26);
            this.label1.TabIndex = 43;
            this.label1.Text = "Идентификатор\r\nавиарейса";
            // 
            // departureAirportIdComboBox
            // 
            this.departureAirportIdComboBox.DataSource = this.selectallairportBindingSource;
            this.departureAirportIdComboBox.DisplayMember = "id";
            this.departureAirportIdComboBox.FormattingEnabled = true;
            this.departureAirportIdComboBox.Location = new System.Drawing.Point(496, 462);
            this.departureAirportIdComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.departureAirportIdComboBox.Name = "departureAirportIdComboBox";
            this.departureAirportIdComboBox.Size = new System.Drawing.Size(101, 21);
            this.departureAirportIdComboBox.TabIndex = 42;
            this.departureAirportIdComboBox.ValueMember = "id";
            // 
            // selectallairportBindingSource
            // 
            this.selectallairportBindingSource.DataMember = "select_all_airport";
            this.selectallairportBindingSource.DataSource = this.dataSet_SelectAllDepartureAirports;
            // 
            // dataSet_SelectAllDepartureAirports
            // 
            this.dataSet_SelectAllDepartureAirports.DataSetName = "DataSet_SelectAllDepartureAirports";
            this.dataSet_SelectAllDepartureAirports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flightNumberTextBox
            // 
            this.flightNumberTextBox.Location = new System.Drawing.Point(132, 463);
            this.flightNumberTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flightNumberTextBox.Name = "flightNumberTextBox";
            this.flightNumberTextBox.Size = new System.Drawing.Size(125, 20);
            this.flightNumberTextBox.TabIndex = 41;
            // 
            // planeDataAdapter
            // 
            this.planeDataAdapter.SelectCommand = this.selectAllPlanes;
            this.planeDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "select_all_plane", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("board_number", "board_number"),
                        new System.Data.Common.DataColumnMapping("manufacturer_id", "manufacturer_id"),
                        new System.Data.Common.DataColumnMapping("model", "model"),
                        new System.Data.Common.DataColumnMapping("capacity", "capacity")})});
            // 
            // selectAllPlanes
            // 
            this.selectAllPlanes.CommandText = "dbo.select_all_plane";
            this.selectAllPlanes.CommandType = System.Data.CommandType.StoredProcedure;
            this.selectAllPlanes.Connection = this.sqlConnection;
            this.selectAllPlanes.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // select_all_flightTableAdapter
            // 
            this.select_all_flightTableAdapter.ClearBeforeFill = true;
            // 
            // departureDateTimePicker
            // 
            this.departureDateTimePicker.CustomFormat = "dd.MM.yyyy    hh:mm";
            this.departureDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.departureDateTimePicker.Location = new System.Drawing.Point(276, 463);
            this.departureDateTimePicker.Name = "departureDateTimePicker";
            this.departureDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.departureDateTimePicker.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 447);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Дата вылета";
            // 
            // arrivalDateTimePicker
            // 
            this.arrivalDateTimePicker.CustomFormat = "dd.MM.yyyy    hh:mm";
            this.arrivalDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.arrivalDateTimePicker.Location = new System.Drawing.Point(276, 530);
            this.arrivalDateTimePicker.Name = "arrivalDateTimePicker";
            this.arrivalDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.arrivalDateTimePicker.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 514);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Дата прилета";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(493, 501);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 26);
            this.label6.TabIndex = 61;
            this.label6.Text = "Идентификатор\r\nаэропорта прилета";
            // 
            // arrivalAirportIdComboBox
            // 
            this.arrivalAirportIdComboBox.DataSource = this.selectallairportBindingSource1;
            this.arrivalAirportIdComboBox.DisplayMember = "id";
            this.arrivalAirportIdComboBox.FormattingEnabled = true;
            this.arrivalAirportIdComboBox.Location = new System.Drawing.Point(496, 529);
            this.arrivalAirportIdComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.arrivalAirportIdComboBox.Name = "arrivalAirportIdComboBox";
            this.arrivalAirportIdComboBox.Size = new System.Drawing.Size(101, 21);
            this.arrivalAirportIdComboBox.TabIndex = 60;
            this.arrivalAirportIdComboBox.ValueMember = "id";
            // 
            // selectallairportBindingSource1
            // 
            this.selectallairportBindingSource1.DataMember = "select_all_airport";
            this.selectallairportBindingSource1.DataSource = this.dataSet_SelectAllDestinationAirports;
            // 
            // dataSet_SelectAllDestinationAirports
            // 
            this.dataSet_SelectAllDestinationAirports.DataSetName = "DataSet_SelectAllDestinationAirports";
            this.dataSet_SelectAllDestinationAirports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(618, 434);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 26);
            this.label9.TabIndex = 63;
            this.label9.Text = "Бортовой номер\r\nсамолета";
            // 
            // planeBoardNumberComboBox
            // 
            this.planeBoardNumberComboBox.DataSource = this.selectallplaneBindingSource;
            this.planeBoardNumberComboBox.DisplayMember = "board_number";
            this.planeBoardNumberComboBox.FormattingEnabled = true;
            this.planeBoardNumberComboBox.Location = new System.Drawing.Point(621, 462);
            this.planeBoardNumberComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.planeBoardNumberComboBox.Name = "planeBoardNumberComboBox";
            this.planeBoardNumberComboBox.Size = new System.Drawing.Size(101, 21);
            this.planeBoardNumberComboBox.TabIndex = 62;
            this.planeBoardNumberComboBox.ValueMember = "board_number";
            // 
            // selectallplaneBindingSource
            // 
            this.selectallplaneBindingSource.DataMember = "select_all_plane";
            this.selectallplaneBindingSource.DataSource = this.dataSet_SelectAllPlanes;
            // 
            // dataSet_SelectAllPlanes
            // 
            this.dataSet_SelectAllPlanes.DataSetName = "DataSet_SelectAllPlanes";
            this.dataSet_SelectAllPlanes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // select_all_planeTableAdapter
            // 
            this.select_all_planeTableAdapter.ClearBeforeFill = true;
            // 
            // select_all_airportTableAdapter
            // 
            this.select_all_airportTableAdapter.ClearBeforeFill = true;
            // 
            // select_all_airportTableAdapter1
            // 
            this.select_all_airportTableAdapter1.ClearBeforeFill = true;
            // 
            // Flights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 561);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.planeBoardNumberComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.arrivalAirportIdComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.arrivalDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.departureDateTimePicker);
            this.Controls.Add(this.updateFlightButton);
            this.Controls.Add(this.findFlightButton);
            this.Controls.Add(this.deleteFlightButton);
            this.Controls.Add(this.flightIdTextBox);
            this.Controls.Add(this.flightsDataGridView);
            this.Controls.Add(this.addFlightButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.departureAirportIdComboBox);
            this.Controls.Add(this.flightNumberTextBox);
            this.Name = "Flights";
            this.Text = "Авиарейсы";
            this.Deactivate += new System.EventHandler(this.Flights_Deactivate);
            this.Load += new System.EventHandler(this.Flights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flightsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectallflightBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SelectAllFlights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectallairportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SelectAllDepartureAirports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectallairportBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SelectAllDestinationAirports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectallplaneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SelectAllPlanes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button updateFlightButton;
        private System.Windows.Forms.Button findFlightButton;
        private System.Windows.Forms.Button deleteFlightButton;
        private System.Windows.Forms.MaskedTextBox flightIdTextBox;
        private System.Data.SqlClient.SqlDataAdapter airportDataAdapter;
        private System.Data.SqlClient.SqlCommand selectAllAirports;
        private System.Data.SqlClient.SqlConnection sqlConnection;
        private System.Data.SqlClient.SqlDataAdapter flightDataAdapter;
        private System.Data.SqlClient.SqlCommand deleteFlightCommand;
        private System.Data.SqlClient.SqlCommand insertFlightCommand;
        private System.Data.SqlClient.SqlCommand selectFlightCommand;
        private System.Data.SqlClient.SqlCommand updateFlightCommand;
        private System.Windows.Forms.DataGridView flightsDataGridView;
        private System.Windows.Forms.Button addFlightButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox departureAirportIdComboBox;
        private System.Windows.Forms.TextBox flightNumberTextBox;
        private System.Data.SqlClient.SqlDataAdapter planeDataAdapter;
        private System.Data.SqlClient.SqlCommand selectAllPlanes;
        private DataSet__SelectAllFlights dataSet_SelectAllFlights;
        private System.Windows.Forms.BindingSource selectallflightBindingSource;
        private DataSet__SelectAllFlightsTableAdapters.select_all_flightTableAdapter select_all_flightTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departuredateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivaldateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureairportidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationairportidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planeboardnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker departureDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker arrivalDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox arrivalAirportIdComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox planeBoardNumberComboBox;
        private DataSet__SelectAllPlanes dataSet_SelectAllPlanes;
        private System.Windows.Forms.BindingSource selectallplaneBindingSource;
        private DataSet__SelectAllPlanesTableAdapters.select_all_planeTableAdapter select_all_planeTableAdapter;
        private DataSet_SelectAllDepartureAirports dataSet_SelectAllDepartureAirports;
        private System.Windows.Forms.BindingSource selectallairportBindingSource;
        private DataSet_SelectAllDepartureAirportsTableAdapters.select_all_airportTableAdapter select_all_airportTableAdapter;
        private DataSet_SelectAllDestinationAirports dataSet_SelectAllDestinationAirports;
        private System.Windows.Forms.BindingSource selectallairportBindingSource1;
        private DataSet_SelectAllDestinationAirportsTableAdapters.select_all_airportTableAdapter select_all_airportTableAdapter1;
    }
}