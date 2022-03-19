
namespace WindowsFormsApp1
{
    partial class Cities
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.citiesDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectallcityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_SelectAllCities = new WindowsFormsApp1.DataSet_SelectAllCities();
            this.label1 = new System.Windows.Forms.Label();
            this.cityNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addCityButton = new System.Windows.Forms.Button();
            this.deleteCityButton = new System.Windows.Forms.Button();
            this.findCityButton = new System.Windows.Forms.Button();
            this.updateCityButton = new System.Windows.Forms.Button();
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.selectCityCommand = new System.Data.SqlClient.SqlCommand();
            this.insertCityCommand = new System.Data.SqlClient.SqlCommand();
            this.updateCityCommand = new System.Data.SqlClient.SqlCommand();
            this.deleteCityCommand = new System.Data.SqlClient.SqlCommand();
            this.cityDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.select_all_cityTableAdapter = new WindowsFormsApp1.DataSet_SelectAllCitiesTableAdapters.select_all_cityTableAdapter();
            this.cityIdTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.citiesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectallcityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SelectAllCities)).BeginInit();
            this.SuspendLayout();
            // 
            // citiesDataGridView
            // 
            this.citiesDataGridView.AutoGenerateColumns = false;
            this.citiesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.citiesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.citiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.citiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.citiesDataGridView.DataSource = this.selectallcityBindingSource;
            this.citiesDataGridView.Location = new System.Drawing.Point(8, 8);
            this.citiesDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.citiesDataGridView.Name = "citiesDataGridView";
            this.citiesDataGridView.ReadOnly = true;
            this.citiesDataGridView.RowHeadersWidth = 62;
            this.citiesDataGridView.RowTemplate.Height = 28;
            this.citiesDataGridView.Size = new System.Drawing.Size(379, 234);
            this.citiesDataGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.Frozen = true;
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
            // selectallcityBindingSource
            // 
            this.selectallcityBindingSource.DataMember = "select_all_city";
            this.selectallcityBindingSource.DataSource = this.dataSet_SelectAllCities;
            // 
            // dataSet_SelectAllCities
            // 
            this.dataSet_SelectAllCities.DataSetName = "DataSet_SelectAllCities";
            this.dataSet_SelectAllCities.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 259);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Идентификатор \r\nгорода";
            // 
            // cityNameTextBox
            // 
            this.cityNameTextBox.Location = new System.Drawing.Point(126, 287);
            this.cityNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cityNameTextBox.Name = "cityNameTextBox";
            this.cityNameTextBox.Size = new System.Drawing.Size(149, 20);
            this.cityNameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 259);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Название \r\nгорода";
            // 
            // addCityButton
            // 
            this.addCityButton.Location = new System.Drawing.Point(433, 11);
            this.addCityButton.Margin = new System.Windows.Forms.Padding(2);
            this.addCityButton.Name = "addCityButton";
            this.addCityButton.Size = new System.Drawing.Size(80, 30);
            this.addCityButton.TabIndex = 11;
            this.addCityButton.Text = "Добавить";
            this.addCityButton.UseVisualStyleBackColor = true;
            this.addCityButton.Click += new System.EventHandler(this.addCityButton_Click);
            // 
            // deleteCityButton
            // 
            this.deleteCityButton.Location = new System.Drawing.Point(433, 45);
            this.deleteCityButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteCityButton.Name = "deleteCityButton";
            this.deleteCityButton.Size = new System.Drawing.Size(80, 30);
            this.deleteCityButton.TabIndex = 12;
            this.deleteCityButton.Text = "Удалить";
            this.deleteCityButton.UseVisualStyleBackColor = true;
            this.deleteCityButton.Click += new System.EventHandler(this.deleteCityButton_Click);
            // 
            // findCityButton
            // 
            this.findCityButton.Location = new System.Drawing.Point(433, 113);
            this.findCityButton.Margin = new System.Windows.Forms.Padding(2);
            this.findCityButton.Name = "findCityButton";
            this.findCityButton.Size = new System.Drawing.Size(80, 30);
            this.findCityButton.TabIndex = 13;
            this.findCityButton.Text = "Найти";
            this.findCityButton.UseVisualStyleBackColor = true;
            this.findCityButton.Click += new System.EventHandler(this.findCityButton_Click);
            // 
            // updateCityButton
            // 
            this.updateCityButton.Location = new System.Drawing.Point(433, 79);
            this.updateCityButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateCityButton.Name = "updateCityButton";
            this.updateCityButton.Size = new System.Drawing.Size(80, 30);
            this.updateCityButton.TabIndex = 14;
            this.updateCityButton.Text = "Изменить";
            this.updateCityButton.UseVisualStyleBackColor = true;
            this.updateCityButton.Click += new System.EventHandler(this.updateCityButton_Click);
            // 
            // sqlConnection
            // 
            this.sqlConnection.ConnectionString = "Data Source=DESKTOP-3SOCJMQ;Initial Catalog=my_database;Integrated Security=True";
            this.sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // selectCityCommand
            // 
            this.selectCityCommand.CommandText = "dbo.select_all_city";
            this.selectCityCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.selectCityCommand.Connection = this.sqlConnection;
            this.selectCityCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // insertCityCommand
            // 
            this.insertCityCommand.CommandText = "dbo.add_city";
            this.insertCityCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.insertCityCommand.Connection = this.sqlConnection;
            this.insertCityCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.SmallInt, 2, "id"),
            new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.VarChar, 100, "name")});
            // 
            // updateCityCommand
            // 
            this.updateCityCommand.CommandText = "dbo.update_city";
            this.updateCityCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.updateCityCommand.Connection = this.sqlConnection;
            this.updateCityCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.SmallInt, 2, "id"),
            new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.VarChar, 100, "name")});
            // 
            // deleteCityCommand
            // 
            this.deleteCityCommand.CommandText = "dbo.delete_city";
            this.deleteCityCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.deleteCityCommand.Connection = this.sqlConnection;
            this.deleteCityCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.SmallInt, 2, "id")});
            // 
            // cityDataAdapter
            // 
            this.cityDataAdapter.DeleteCommand = this.deleteCityCommand;
            this.cityDataAdapter.InsertCommand = this.insertCityCommand;
            this.cityDataAdapter.SelectCommand = this.selectCityCommand;
            this.cityDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "select_all_city", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("id", "id"),
                        new System.Data.Common.DataColumnMapping("name", "name")})});
            this.cityDataAdapter.UpdateCommand = this.updateCityCommand;
            // 
            // select_all_cityTableAdapter
            // 
            this.select_all_cityTableAdapter.ClearBeforeFill = true;
            // 
            // cityIdTextBox
            // 
            this.cityIdTextBox.Location = new System.Drawing.Point(8, 287);
            this.cityIdTextBox.Mask = "00000";
            this.cityIdTextBox.Name = "cityIdTextBox";
            this.cityIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityIdTextBox.TabIndex = 15;
            // 
            // Cities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(524, 321);
            this.Controls.Add(this.cityIdTextBox);
            this.Controls.Add(this.updateCityButton);
            this.Controls.Add(this.findCityButton);
            this.Controls.Add(this.deleteCityButton);
            this.Controls.Add(this.addCityButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cityNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.citiesDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Cities";
            this.Text = "Города";
            this.Deactivate += new System.EventHandler(this.CitiesForm_Deactivate);
            this.Load += new System.EventHandler(this.CitiesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.citiesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectallcityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SelectAllCities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView citiesDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cityNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addCityButton;
        private System.Windows.Forms.Button deleteCityButton;
        private System.Windows.Forms.Button findCityButton;
        private System.Windows.Forms.Button updateCityButton;
        private System.Data.SqlClient.SqlConnection sqlConnection;
        private System.Data.SqlClient.SqlCommand selectCityCommand;
        private System.Data.SqlClient.SqlCommand insertCityCommand;
        private System.Data.SqlClient.SqlCommand updateCityCommand;
        private System.Data.SqlClient.SqlCommand deleteCityCommand;
        private System.Data.SqlClient.SqlDataAdapter cityDataAdapter;
        private DataSet_SelectAllCities dataSet_SelectAllCities;
        private System.Windows.Forms.BindingSource selectallcityBindingSource;
        private DataSet_SelectAllCitiesTableAdapters.select_all_cityTableAdapter select_all_cityTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox cityIdTextBox;
    }
}

