
namespace WindowsFormsApp1
{
    partial class Planes
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
            this.updatePlaneButton = new System.Windows.Forms.Button();
            this.findPlaneButton = new System.Windows.Forms.Button();
            this.deletePlaneButton = new System.Windows.Forms.Button();
            this.addPlaneButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.capacityTextBox = new System.Windows.Forms.MaskedTextBox();
            this.manufacturerDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.selectAllManufacturers = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.planeDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.deletePlaneCommand = new System.Data.SqlClient.SqlCommand();
            this.insertPlaneCommand = new System.Data.SqlClient.SqlCommand();
            this.selectPlaneCommand = new System.Data.SqlClient.SqlCommand();
            this.updatePlaneCommand = new System.Data.SqlClient.SqlCommand();
            this.planesDataGridView = new System.Windows.Forms.DataGridView();
            this.boardnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufactureridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectallplaneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_SelectAllPlanes = new WindowsFormsApp1.DataSet_SelectAllPlanes();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.manufacturerIdComboBox = new System.Windows.Forms.ComboBox();
            this.selectallmanufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_SelectManufacturerNames = new WindowsFormsApp1.DataSet_SelectManufacturerNames();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.select_all_planeTableAdapter = new WindowsFormsApp1.DataSet_SelectAllPlanesTableAdapters.select_all_planeTableAdapter();
            this.boardNumberTextBox = new System.Windows.Forms.TextBox();
            this.select_all_manufacturerTableAdapter = new WindowsFormsApp1.DataSet_SelectManufacturerNamesTableAdapters.select_all_manufacturerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.planesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectallplaneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SelectAllPlanes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectallmanufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SelectManufacturerNames)).BeginInit();
            this.SuspendLayout();
            // 
            // updatePlaneButton
            // 
            this.updatePlaneButton.Location = new System.Drawing.Point(639, 79);
            this.updatePlaneButton.Margin = new System.Windows.Forms.Padding(2);
            this.updatePlaneButton.Name = "updatePlaneButton";
            this.updatePlaneButton.Size = new System.Drawing.Size(80, 30);
            this.updatePlaneButton.TabIndex = 55;
            this.updatePlaneButton.Text = "Изменить";
            this.updatePlaneButton.UseVisualStyleBackColor = true;
            this.updatePlaneButton.Click += new System.EventHandler(this.updatePlaneButton_Click);
            // 
            // findPlaneButton
            // 
            this.findPlaneButton.Location = new System.Drawing.Point(639, 113);
            this.findPlaneButton.Margin = new System.Windows.Forms.Padding(2);
            this.findPlaneButton.Name = "findPlaneButton";
            this.findPlaneButton.Size = new System.Drawing.Size(80, 30);
            this.findPlaneButton.TabIndex = 54;
            this.findPlaneButton.Text = "Найти";
            this.findPlaneButton.UseVisualStyleBackColor = true;
            this.findPlaneButton.Click += new System.EventHandler(this.findPlaneButton_Click);
            // 
            // deletePlaneButton
            // 
            this.deletePlaneButton.Location = new System.Drawing.Point(639, 45);
            this.deletePlaneButton.Margin = new System.Windows.Forms.Padding(2);
            this.deletePlaneButton.Name = "deletePlaneButton";
            this.deletePlaneButton.Size = new System.Drawing.Size(80, 30);
            this.deletePlaneButton.TabIndex = 53;
            this.deletePlaneButton.Text = "Удалить";
            this.deletePlaneButton.UseVisualStyleBackColor = true;
            this.deletePlaneButton.Click += new System.EventHandler(this.deletePlaneButton_Click);
            // 
            // addPlaneButton
            // 
            this.addPlaneButton.Location = new System.Drawing.Point(639, 11);
            this.addPlaneButton.Margin = new System.Windows.Forms.Padding(2);
            this.addPlaneButton.Name = "addPlaneButton";
            this.addPlaneButton.Size = new System.Drawing.Size(80, 30);
            this.addPlaneButton.TabIndex = 52;
            this.addPlaneButton.Text = "Добавить";
            this.addPlaneButton.UseVisualStyleBackColor = true;
            this.addPlaneButton.Click += new System.EventHandler(this.addPlaneButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 257);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Пассажировместимость";
            // 
            // capacityTextBox
            // 
            this.capacityTextBox.Location = new System.Drawing.Point(421, 273);
            this.capacityTextBox.Mask = "0000";
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.Size = new System.Drawing.Size(65, 20);
            this.capacityTextBox.TabIndex = 48;
            // 
            // manufacturerDataAdapter
            // 
            this.manufacturerDataAdapter.SelectCommand = this.selectAllManufacturers;
            this.manufacturerDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "select_all_manufacturer", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("id", "id"),
                        new System.Data.Common.DataColumnMapping("name", "name")})});
            // 
            // selectAllManufacturers
            // 
            this.selectAllManufacturers.CommandText = "dbo.select_all_manufacturer";
            this.selectAllManufacturers.CommandType = System.Data.CommandType.StoredProcedure;
            this.selectAllManufacturers.Connection = this.sqlConnection;
            this.selectAllManufacturers.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlConnection
            // 
            this.sqlConnection.ConnectionString = "Data Source=DESKTOP-3SOCJMQ;Initial Catalog=my_database;Integrated Security=True";
            this.sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // planeDataAdapter
            // 
            this.planeDataAdapter.DeleteCommand = this.deletePlaneCommand;
            this.planeDataAdapter.InsertCommand = this.insertPlaneCommand;
            this.planeDataAdapter.SelectCommand = this.selectPlaneCommand;
            this.planeDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "select_all_plane", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("board_number", "board_number"),
                        new System.Data.Common.DataColumnMapping("manufacturer_id", "manufacturer_id"),
                        new System.Data.Common.DataColumnMapping("model", "model"),
                        new System.Data.Common.DataColumnMapping("capacity", "capacity")})});
            this.planeDataAdapter.UpdateCommand = this.updatePlaneCommand;
            // 
            // deletePlaneCommand
            // 
            this.deletePlaneCommand.CommandText = "dbo.delete_plane";
            this.deletePlaneCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.deletePlaneCommand.Connection = this.sqlConnection;
            this.deletePlaneCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@board_number", System.Data.SqlDbType.VarChar, 10, "board_number")});
            // 
            // insertPlaneCommand
            // 
            this.insertPlaneCommand.CommandText = "dbo.add_plane";
            this.insertPlaneCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.insertPlaneCommand.Connection = this.sqlConnection;
            this.insertPlaneCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@board_number", System.Data.SqlDbType.VarChar, 10, "board_number"),
            new System.Data.SqlClient.SqlParameter("@manufacturer_id", System.Data.SqlDbType.Int, 4, "manufacturer_id"),
            new System.Data.SqlClient.SqlParameter("@model", System.Data.SqlDbType.VarChar, 50, "model"),
            new System.Data.SqlClient.SqlParameter("@capacity", System.Data.SqlDbType.Int, 4, "capacity")});
            // 
            // selectPlaneCommand
            // 
            this.selectPlaneCommand.CommandText = "dbo.select_all_plane";
            this.selectPlaneCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.selectPlaneCommand.Connection = this.sqlConnection;
            this.selectPlaneCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // updatePlaneCommand
            // 
            this.updatePlaneCommand.CommandText = "dbo.update_plane";
            this.updatePlaneCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.updatePlaneCommand.Connection = this.sqlConnection;
            this.updatePlaneCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@board_number", System.Data.SqlDbType.VarChar, 10, "board_number"),
            new System.Data.SqlClient.SqlParameter("@manufacturer_id", System.Data.SqlDbType.Int, 4, "manufacturer_id"),
            new System.Data.SqlClient.SqlParameter("@model", System.Data.SqlDbType.VarChar, 50, "model"),
            new System.Data.SqlClient.SqlParameter("@capacity", System.Data.SqlDbType.Int, 4, "capacity")});
            // 
            // planesDataGridView
            // 
            this.planesDataGridView.AutoGenerateColumns = false;
            this.planesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.planesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.planesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.planesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.boardnumberDataGridViewTextBoxColumn,
            this.manufactureridDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn});
            this.planesDataGridView.DataSource = this.selectallplaneBindingSource;
            this.planesDataGridView.Location = new System.Drawing.Point(11, 11);
            this.planesDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.planesDataGridView.Name = "planesDataGridView";
            this.planesDataGridView.ReadOnly = true;
            this.planesDataGridView.RowHeadersWidth = 62;
            this.planesDataGridView.RowTemplate.Height = 28;
            this.planesDataGridView.Size = new System.Drawing.Size(578, 208);
            this.planesDataGridView.TabIndex = 46;
            // 
            // boardnumberDataGridViewTextBoxColumn
            // 
            this.boardnumberDataGridViewTextBoxColumn.DataPropertyName = "board_number";
            this.boardnumberDataGridViewTextBoxColumn.HeaderText = "Бортовой номер";
            this.boardnumberDataGridViewTextBoxColumn.Name = "boardnumberDataGridViewTextBoxColumn";
            this.boardnumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.boardnumberDataGridViewTextBoxColumn.Width = 105;
            // 
            // manufactureridDataGridViewTextBoxColumn
            // 
            this.manufactureridDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.manufactureridDataGridViewTextBoxColumn.DataPropertyName = "manufacturer_id";
            this.manufactureridDataGridViewTextBoxColumn.HeaderText = "Идентификатор производителя";
            this.manufactureridDataGridViewTextBoxColumn.Name = "manufactureridDataGridViewTextBoxColumn";
            this.manufactureridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Модель";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            this.modelDataGridViewTextBoxColumn.Width = 150;
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "Пассажировместимость";
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            this.capacityDataGridViewTextBoxColumn.ReadOnly = true;
            this.capacityDataGridViewTextBoxColumn.Width = 158;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 245);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 26);
            this.label5.TabIndex = 45;
            this.label5.Text = "Идентификатор\r\nпроизводителя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 257);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Модель самолета";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 246);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 26);
            this.label1.TabIndex = 43;
            this.label1.Text = "Бортовой номер\r\nсамолета";
            // 
            // manufacturerIdComboBox
            // 
            this.manufacturerIdComboBox.DataSource = this.selectallmanufacturerBindingSource;
            this.manufacturerIdComboBox.DisplayMember = "id";
            this.manufacturerIdComboBox.FormattingEnabled = true;
            this.manufacturerIdComboBox.Location = new System.Drawing.Point(158, 273);
            this.manufacturerIdComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.manufacturerIdComboBox.Name = "manufacturerIdComboBox";
            this.manufacturerIdComboBox.Size = new System.Drawing.Size(84, 21);
            this.manufacturerIdComboBox.TabIndex = 42;
            this.manufacturerIdComboBox.ValueMember = "id";
            // 
            // selectallmanufacturerBindingSource
            // 
            this.selectallmanufacturerBindingSource.DataMember = "select_all_manufacturer";
            this.selectallmanufacturerBindingSource.DataSource = this.dataSet_SelectManufacturerNames;
            // 
            // dataSet_SelectManufacturerNames
            // 
            this.dataSet_SelectManufacturerNames.DataSetName = "DataSet_SelectManufacturerNames";
            this.dataSet_SelectManufacturerNames.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(262, 273);
            this.modelTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(141, 20);
            this.modelTextBox.TabIndex = 41;
            // 
            // select_all_planeTableAdapter
            // 
            this.select_all_planeTableAdapter.ClearBeforeFill = true;
            // 
            // boardNumberTextBox
            // 
            this.boardNumberTextBox.Location = new System.Drawing.Point(36, 274);
            this.boardNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.boardNumberTextBox.Name = "boardNumberTextBox";
            this.boardNumberTextBox.Size = new System.Drawing.Size(102, 20);
            this.boardNumberTextBox.TabIndex = 56;
            // 
            // select_all_manufacturerTableAdapter
            // 
            this.select_all_manufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // Planes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 311);
            this.Controls.Add(this.boardNumberTextBox);
            this.Controls.Add(this.updatePlaneButton);
            this.Controls.Add(this.findPlaneButton);
            this.Controls.Add(this.deletePlaneButton);
            this.Controls.Add(this.addPlaneButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.capacityTextBox);
            this.Controls.Add(this.planesDataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.manufacturerIdComboBox);
            this.Controls.Add(this.modelTextBox);
            this.Name = "Planes";
            this.Text = "Самолеты";
            this.Load += new System.EventHandler(this.Planes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.planesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectallplaneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SelectAllPlanes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectallmanufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SelectManufacturerNames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button updatePlaneButton;
        private System.Windows.Forms.Button findPlaneButton;
        private System.Windows.Forms.Button deletePlaneButton;
        private System.Windows.Forms.Button addPlaneButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox capacityTextBox;
        private System.Data.SqlClient.SqlDataAdapter manufacturerDataAdapter;
        private System.Data.SqlClient.SqlCommand selectAllManufacturers;
        private System.Data.SqlClient.SqlConnection sqlConnection;
        private System.Data.SqlClient.SqlDataAdapter planeDataAdapter;
        private System.Data.SqlClient.SqlCommand deletePlaneCommand;
        private System.Data.SqlClient.SqlCommand insertPlaneCommand;
        private System.Data.SqlClient.SqlCommand selectPlaneCommand;
        private System.Data.SqlClient.SqlCommand updatePlaneCommand;
        private System.Windows.Forms.DataGridView planesDataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox manufacturerIdComboBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private DataSet_SelectAllPlanes dataSet_SelectAllPlanes;
        private System.Windows.Forms.BindingSource selectallplaneBindingSource;
        private DataSet_SelectAllPlanesTableAdapters.select_all_planeTableAdapter select_all_planeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn boardnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufactureridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox boardNumberTextBox;
        private DataSet_SelectManufacturerNames dataSet_SelectManufacturerNames;
        private System.Windows.Forms.BindingSource selectallmanufacturerBindingSource;
        private DataSet_SelectManufacturerNamesTableAdapters.select_all_manufacturerTableAdapter select_all_manufacturerTableAdapter;
    }
}