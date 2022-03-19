
namespace WindowsFormsApp1
{
    partial class Airports
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
            this.cityIdComboBox = new System.Windows.Forms.ComboBox();
            this.airportNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.airportsDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminalsamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.runwaysamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectallairportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_SelectAllAirports = new WindowsFormsApp1.DataSet_SelectAllAirports();
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.selectAirportCommand = new System.Data.SqlClient.SqlCommand();
            this.insertAirportCommand = new System.Data.SqlClient.SqlCommand();
            this.updateAirportCommand = new System.Data.SqlClient.SqlCommand();
            this.deleteAirportCommand = new System.Data.SqlClient.SqlCommand();
            this.airportDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.selectAllCities = new System.Data.SqlClient.SqlCommand();
            this.cityDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.select_all_airportTableAdapter = new WindowsFormsApp1.DataSet_SelectAllAirportsTableAdapters.select_all_airportTableAdapter();
            this.airportIdTextBox = new System.Windows.Forms.MaskedTextBox();
            this.terminalsAmountTextBox = new System.Windows.Forms.MaskedTextBox();
            this.runwaysAmountTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.updateAirportButton = new System.Windows.Forms.Button();
            this.findAirportButton = new System.Windows.Forms.Button();
            this.deleteAirportButton = new System.Windows.Forms.Button();
            this.addAirportButton = new System.Windows.Forms.Button();
            this.dataSet__SelectCitiesForAirports = new WindowsFormsApp1.DataSet_SelectCitiesForAirports();
            this.selectallcityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.select_all_cityTableAdapter = new WindowsFormsApp1.DataSet__SelectCitiesForAirportsTableAdapters.select_all_cityTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.airportsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectallairportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SelectAllAirports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet__SelectCitiesForAirports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectallcityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cityIdComboBox
            // 
            this.cityIdComboBox.DataSource = this.selectallcityBindingSource;
            this.cityIdComboBox.DisplayMember = "id";
            this.cityIdComboBox.FormattingEnabled = true;
            this.cityIdComboBox.Location = new System.Drawing.Point(612, 278);
            this.cityIdComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.cityIdComboBox.Name = "cityIdComboBox";
            this.cityIdComboBox.Size = new System.Drawing.Size(84, 21);
            this.cityIdComboBox.TabIndex = 23;
            this.cityIdComboBox.ValueMember = "id";
            // 
            // airportNameTextBox
            // 
            this.airportNameTextBox.Location = new System.Drawing.Point(132, 279);
            this.airportNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.airportNameTextBox.Name = "airportNameTextBox";
            this.airportNameTextBox.Size = new System.Drawing.Size(212, 20);
            this.airportNameTextBox.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(609, 250);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 26);
            this.label5.TabIndex = 28;
            this.label5.Text = "Идентификатор\r\nгорода";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 250);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 26);
            this.label2.TabIndex = 25;
            this.label2.Text = "Название\r\nаэропорта";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 250);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 26);
            this.label1.TabIndex = 24;
            this.label1.Text = "Идентификатор\r\nаэропорта";
            // 
            // airportsDataGridView
            // 
            this.airportsDataGridView.AutoGenerateColumns = false;
            this.airportsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.airportsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.airportsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.airportsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.terminalsamountDataGridViewTextBoxColumn,
            this.runwaysamountDataGridViewTextBoxColumn,
            this.cityidDataGridViewTextBoxColumn});
            this.airportsDataGridView.DataSource = this.selectallairportBindingSource;
            this.airportsDataGridView.Location = new System.Drawing.Point(14, 11);
            this.airportsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.airportsDataGridView.Name = "airportsDataGridView";
            this.airportsDataGridView.ReadOnly = true;
            this.airportsDataGridView.RowHeadersWidth = 62;
            this.airportsDataGridView.RowTemplate.Height = 28;
            this.airportsDataGridView.Size = new System.Drawing.Size(765, 208);
            this.airportsDataGridView.TabIndex = 31;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Идентификатор";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 112;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // terminalsamountDataGridViewTextBoxColumn
            // 
            this.terminalsamountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.terminalsamountDataGridViewTextBoxColumn.DataPropertyName = "terminals_amount";
            this.terminalsamountDataGridViewTextBoxColumn.HeaderText = "Количество терминалов";
            this.terminalsamountDataGridViewTextBoxColumn.Name = "terminalsamountDataGridViewTextBoxColumn";
            this.terminalsamountDataGridViewTextBoxColumn.ReadOnly = true;
            this.terminalsamountDataGridViewTextBoxColumn.Width = 80;
            // 
            // runwaysamountDataGridViewTextBoxColumn
            // 
            this.runwaysamountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.runwaysamountDataGridViewTextBoxColumn.DataPropertyName = "runways_amount";
            this.runwaysamountDataGridViewTextBoxColumn.HeaderText = "Количество взлетно-посадочных полос";
            this.runwaysamountDataGridViewTextBoxColumn.Name = "runwaysamountDataGridViewTextBoxColumn";
            this.runwaysamountDataGridViewTextBoxColumn.ReadOnly = true;
            this.runwaysamountDataGridViewTextBoxColumn.Width = 170;
            // 
            // cityidDataGridViewTextBoxColumn
            // 
            this.cityidDataGridViewTextBoxColumn.DataPropertyName = "city_id";
            this.cityidDataGridViewTextBoxColumn.HeaderText = "Идентификатор города";
            this.cityidDataGridViewTextBoxColumn.Name = "cityidDataGridViewTextBoxColumn";
            this.cityidDataGridViewTextBoxColumn.ReadOnly = true;
            this.cityidDataGridViewTextBoxColumn.Width = 137;
            // 
            // selectallairportBindingSource
            // 
            this.selectallairportBindingSource.DataMember = "select_all_airport";
            this.selectallairportBindingSource.DataSource = this.dataSet_SelectAllAirports;
            // 
            // dataSet_SelectAllAirports
            // 
            this.dataSet_SelectAllAirports.DataSetName = "DataSet_SelectAllAirports";
            this.dataSet_SelectAllAirports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlConnection
            // 
            this.sqlConnection.ConnectionString = "Data Source=DESKTOP-3SOCJMQ;Initial Catalog=my_database;Integrated Security=True";
            this.sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // selectAirportCommand
            // 
            this.selectAirportCommand.CommandText = "dbo.select_all_airport";
            this.selectAirportCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.selectAirportCommand.Connection = this.sqlConnection;
            this.selectAirportCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // insertAirportCommand
            // 
            this.insertAirportCommand.CommandText = "dbo.add_airport";
            this.insertAirportCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.insertAirportCommand.Connection = this.sqlConnection;
            this.insertAirportCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.SmallInt, 2, "id"),
            new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.VarChar, 100, "name"),
            new System.Data.SqlClient.SqlParameter("@terminals_amount", System.Data.SqlDbType.TinyInt, 1, "terminals_amount"),
            new System.Data.SqlClient.SqlParameter("@runways_amount", System.Data.SqlDbType.TinyInt, 1, "runways_amount"),
            new System.Data.SqlClient.SqlParameter("@city_id", System.Data.SqlDbType.Int, 4, "city_id")});
            // 
            // updateAirportCommand
            // 
            this.updateAirportCommand.CommandText = "dbo.update_airport";
            this.updateAirportCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.updateAirportCommand.Connection = this.sqlConnection;
            this.updateAirportCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.SmallInt, 2, "id"),
            new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.VarChar, 100, "name"),
            new System.Data.SqlClient.SqlParameter("@terminals_amount", System.Data.SqlDbType.Int, 4, "terminals_amount"),
            new System.Data.SqlClient.SqlParameter("@runways_amount", System.Data.SqlDbType.Int, 4, "runways_amount"),
            new System.Data.SqlClient.SqlParameter("@city_id", System.Data.SqlDbType.Int, 4, "city_id")});
            // 
            // deleteAirportCommand
            // 
            this.deleteAirportCommand.CommandText = "dbo.delete_airport";
            this.deleteAirportCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.deleteAirportCommand.Connection = this.sqlConnection;
            this.deleteAirportCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.SmallInt, 2, "id")});
            // 
            // airportDataAdapter
            // 
            this.airportDataAdapter.DeleteCommand = this.deleteAirportCommand;
            this.airportDataAdapter.InsertCommand = this.insertAirportCommand;
            this.airportDataAdapter.SelectCommand = this.selectAirportCommand;
            this.airportDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "select_all_airport", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("id", "id"),
                        new System.Data.Common.DataColumnMapping("name", "name"),
                        new System.Data.Common.DataColumnMapping("terminals_amount", "terminals_amount"),
                        new System.Data.Common.DataColumnMapping("runways_amount", "runways_amount"),
                        new System.Data.Common.DataColumnMapping("city_id", "city_id")})});
            this.airportDataAdapter.UpdateCommand = this.updateAirportCommand;
            // 
            // selectAllCities
            // 
            this.selectAllCities.CommandText = "dbo.select_all_city";
            this.selectAllCities.CommandType = System.Data.CommandType.StoredProcedure;
            this.selectAllCities.Connection = this.sqlConnection;
            this.selectAllCities.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // cityDataAdapter
            // 
            this.cityDataAdapter.SelectCommand = this.selectAllCities;
            this.cityDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "select_all_city", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("id", "id"),
                        new System.Data.Common.DataColumnMapping("name", "name")})});
            // 
            // select_all_airportTableAdapter
            // 
            this.select_all_airportTableAdapter.ClearBeforeFill = true;
            // 
            // airportIdTextBox
            // 
            this.airportIdTextBox.Location = new System.Drawing.Point(12, 279);
            this.airportIdTextBox.Mask = "00000";
            this.airportIdTextBox.Name = "airportIdTextBox";
            this.airportIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.airportIdTextBox.TabIndex = 32;
            // 
            // terminalsAmountTextBox
            // 
            this.terminalsAmountTextBox.Location = new System.Drawing.Point(363, 279);
            this.terminalsAmountTextBox.Mask = "00";
            this.terminalsAmountTextBox.Name = "terminalsAmountTextBox";
            this.terminalsAmountTextBox.Size = new System.Drawing.Size(65, 20);
            this.terminalsAmountTextBox.TabIndex = 33;
            // 
            // runwaysAmountTextBox
            // 
            this.runwaysAmountTextBox.Location = new System.Drawing.Point(448, 279);
            this.runwaysAmountTextBox.Mask = "00";
            this.runwaysAmountTextBox.Name = "runwaysAmountTextBox";
            this.runwaysAmountTextBox.Size = new System.Drawing.Size(61, 20);
            this.runwaysAmountTextBox.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 250);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 26);
            this.label7.TabIndex = 35;
            this.label7.Text = "Количество\r\nтерминалов";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(445, 250);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 26);
            this.label8.TabIndex = 36;
            this.label8.Text = "Количество\r\nвзлетно-посадочных полос";
            // 
            // updateAirportButton
            // 
            this.updateAirportButton.Location = new System.Drawing.Point(813, 79);
            this.updateAirportButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateAirportButton.Name = "updateAirportButton";
            this.updateAirportButton.Size = new System.Drawing.Size(80, 30);
            this.updateAirportButton.TabIndex = 40;
            this.updateAirportButton.Text = "Изменить";
            this.updateAirportButton.UseVisualStyleBackColor = true;
            this.updateAirportButton.Click += new System.EventHandler(this.updateAirportButton_Click);
            // 
            // findAirportButton
            // 
            this.findAirportButton.Location = new System.Drawing.Point(813, 113);
            this.findAirportButton.Margin = new System.Windows.Forms.Padding(2);
            this.findAirportButton.Name = "findAirportButton";
            this.findAirportButton.Size = new System.Drawing.Size(80, 30);
            this.findAirportButton.TabIndex = 39;
            this.findAirportButton.Text = "Найти";
            this.findAirportButton.UseVisualStyleBackColor = true;
            this.findAirportButton.Click += new System.EventHandler(this.findAirportButton_Click);
            // 
            // deleteAirportButton
            // 
            this.deleteAirportButton.Location = new System.Drawing.Point(813, 45);
            this.deleteAirportButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteAirportButton.Name = "deleteAirportButton";
            this.deleteAirportButton.Size = new System.Drawing.Size(80, 30);
            this.deleteAirportButton.TabIndex = 38;
            this.deleteAirportButton.Text = "Удалить";
            this.deleteAirportButton.UseVisualStyleBackColor = true;
            this.deleteAirportButton.Click += new System.EventHandler(this.deleteAirportButton_Click);
            // 
            // addAirportButton
            // 
            this.addAirportButton.Location = new System.Drawing.Point(813, 11);
            this.addAirportButton.Margin = new System.Windows.Forms.Padding(2);
            this.addAirportButton.Name = "addAirportButton";
            this.addAirportButton.Size = new System.Drawing.Size(80, 30);
            this.addAirportButton.TabIndex = 37;
            this.addAirportButton.Text = "Добавить";
            this.addAirportButton.UseVisualStyleBackColor = true;
            this.addAirportButton.Click += new System.EventHandler(this.addAirportButton_Click);
            // 
            // dataSet__SelectCitiesForAirports
            // 
            this.dataSet__SelectCitiesForAirports.DataSetName = "DataSet__SelectCitiesForAirports";
            this.dataSet__SelectCitiesForAirports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectallcityBindingSource
            // 
            this.selectallcityBindingSource.DataMember = "select_all_city";
            this.selectallcityBindingSource.DataSource = this.dataSet__SelectCitiesForAirports;
            // 
            // select_all_cityTableAdapter
            // 
            this.select_all_cityTableAdapter.ClearBeforeFill = true;
            // 
            // Airports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 311);
            this.Controls.Add(this.updateAirportButton);
            this.Controls.Add(this.findAirportButton);
            this.Controls.Add(this.deleteAirportButton);
            this.Controls.Add(this.addAirportButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.runwaysAmountTextBox);
            this.Controls.Add(this.terminalsAmountTextBox);
            this.Controls.Add(this.airportIdTextBox);
            this.Controls.Add(this.airportsDataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cityIdComboBox);
            this.Controls.Add(this.airportNameTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Airports";
            this.Text = "Аэропорты";
            this.Deactivate += new System.EventHandler(this.Airports_Deactivate);
            this.Load += new System.EventHandler(this.Airports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airportsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectallairportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SelectAllAirports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet__SelectCitiesForAirports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectallcityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cityIdComboBox;
        private System.Windows.Forms.TextBox airportNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView airportsDataGridView;
        private System.Data.SqlClient.SqlConnection sqlConnection;
        private System.Data.SqlClient.SqlCommand selectAirportCommand;
        private System.Data.SqlClient.SqlCommand insertAirportCommand;
        private System.Data.SqlClient.SqlCommand updateAirportCommand;
        private System.Data.SqlClient.SqlCommand deleteAirportCommand;
        private System.Data.SqlClient.SqlDataAdapter airportDataAdapter;
        private System.Data.SqlClient.SqlCommand selectAllCities;
        private System.Data.SqlClient.SqlDataAdapter cityDataAdapter;
        private DataSet_SelectAllAirports dataSet_SelectAllAirports;
        private System.Windows.Forms.BindingSource selectallairportBindingSource;
        private DataSet_SelectAllAirportsTableAdapters.select_all_airportTableAdapter select_all_airportTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminalsamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn runwaysamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityidDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox airportIdTextBox;
        private System.Windows.Forms.MaskedTextBox terminalsAmountTextBox;
        private System.Windows.Forms.MaskedTextBox runwaysAmountTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button updateAirportButton;
        private System.Windows.Forms.Button findAirportButton;
        private System.Windows.Forms.Button deleteAirportButton;
        private System.Windows.Forms.Button addAirportButton;
        private DataSet_SelectCitiesForAirports dataSet__SelectCitiesForAirports;
        private System.Windows.Forms.BindingSource selectallcityBindingSource;
        private DataSet__SelectCitiesForAirportsTableAdapters.select_all_cityTableAdapter select_all_cityTableAdapter;
    }
}