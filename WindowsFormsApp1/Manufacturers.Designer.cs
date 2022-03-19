
namespace WindowsFormsApp1
{
    partial class Manufacturers
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
            this.deleteManufacturerCommand = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.updateManufacturerCommand = new System.Data.SqlClient.SqlCommand();
            this.insertManufacturerCommand = new System.Data.SqlClient.SqlCommand();
            this.selectManufacturerCommand = new System.Data.SqlClient.SqlCommand();
            this.updateManufacturerButton = new System.Windows.Forms.Button();
            this.findManufacturerButton = new System.Windows.Forms.Button();
            this.deleteManufacturerButton = new System.Windows.Forms.Button();
            this.addManufacturerButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.manufacturerNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.manufacturersDataGridView = new System.Windows.Forms.DataGridView();
            this.selectallmanufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_SelectAllManufacturers = new WindowsFormsApp1.DataSet_SelectAllManufacturers();
            this.select_all_manufacturerTableAdapter = new WindowsFormsApp1.DataSet_SelectAllManufacturersTableAdapters.select_all_manufacturerTableAdapter();
            this.manufacturerIdTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectallmanufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SelectAllManufacturers)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteManufacturerCommand
            // 
            this.deleteManufacturerCommand.CommandText = "dbo.delete_manufacturer";
            this.deleteManufacturerCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.deleteManufacturerCommand.Connection = this.sqlConnection;
            this.deleteManufacturerCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.TinyInt, 1, "id")});
            // 
            // sqlConnection
            // 
            this.sqlConnection.ConnectionString = "Data Source=DESKTOP-3SOCJMQ;Initial Catalog=my_database;Integrated Security=True";
            this.sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // updateManufacturerCommand
            // 
            this.updateManufacturerCommand.CommandText = "dbo.update_manufacturer";
            this.updateManufacturerCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.updateManufacturerCommand.Connection = this.sqlConnection;
            this.updateManufacturerCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.TinyInt, 1, "id"),
            new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.VarChar, 100, "name")});
            // 
            // insertManufacturerCommand
            // 
            this.insertManufacturerCommand.CommandText = "dbo.add_manufacturer";
            this.insertManufacturerCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.insertManufacturerCommand.Connection = this.sqlConnection;
            this.insertManufacturerCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.TinyInt, 1, "id"),
            new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.VarChar, 100, "name")});
            // 
            // selectManufacturerCommand
            // 
            this.selectManufacturerCommand.CommandText = "dbo.select_all_manufacturer";
            this.selectManufacturerCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.selectManufacturerCommand.Connection = this.sqlConnection;
            this.selectManufacturerCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // updateManufacturerButton
            // 
            this.updateManufacturerButton.Location = new System.Drawing.Point(433, 79);
            this.updateManufacturerButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateManufacturerButton.Name = "updateManufacturerButton";
            this.updateManufacturerButton.Size = new System.Drawing.Size(80, 30);
            this.updateManufacturerButton.TabIndex = 23;
            this.updateManufacturerButton.Text = "Изменить";
            this.updateManufacturerButton.UseVisualStyleBackColor = true;
            this.updateManufacturerButton.Click += new System.EventHandler(this.updateManufacturerButton_Click);
            // 
            // findManufacturerButton
            // 
            this.findManufacturerButton.Location = new System.Drawing.Point(433, 113);
            this.findManufacturerButton.Margin = new System.Windows.Forms.Padding(2);
            this.findManufacturerButton.Name = "findManufacturerButton";
            this.findManufacturerButton.Size = new System.Drawing.Size(80, 30);
            this.findManufacturerButton.TabIndex = 22;
            this.findManufacturerButton.Text = "Найти";
            this.findManufacturerButton.UseVisualStyleBackColor = true;
            this.findManufacturerButton.Click += new System.EventHandler(this.findManufacturerButton_Click);
            // 
            // deleteManufacturerButton
            // 
            this.deleteManufacturerButton.Location = new System.Drawing.Point(433, 45);
            this.deleteManufacturerButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteManufacturerButton.Name = "deleteManufacturerButton";
            this.deleteManufacturerButton.Size = new System.Drawing.Size(80, 30);
            this.deleteManufacturerButton.TabIndex = 21;
            this.deleteManufacturerButton.Text = "Удалить";
            this.deleteManufacturerButton.UseVisualStyleBackColor = true;
            this.deleteManufacturerButton.Click += new System.EventHandler(this.deleteManufacturerButton_Click);
            // 
            // addManufacturerButton
            // 
            this.addManufacturerButton.Location = new System.Drawing.Point(433, 11);
            this.addManufacturerButton.Margin = new System.Windows.Forms.Padding(2);
            this.addManufacturerButton.Name = "addManufacturerButton";
            this.addManufacturerButton.Size = new System.Drawing.Size(80, 30);
            this.addManufacturerButton.TabIndex = 20;
            this.addManufacturerButton.Text = "Добавить";
            this.addManufacturerButton.UseVisualStyleBackColor = true;
            this.addManufacturerButton.Click += new System.EventHandler(this.addManufacturerButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 262);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 26);
            this.label2.TabIndex = 19;
            this.label2.Text = "Название \rпроизводителя";
            // 
            // manufacturerNameTextBox
            // 
            this.manufacturerNameTextBox.Location = new System.Drawing.Point(129, 290);
            this.manufacturerNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.manufacturerNameTextBox.Name = "manufacturerNameTextBox";
            this.manufacturerNameTextBox.Size = new System.Drawing.Size(149, 20);
            this.manufacturerNameTextBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 262);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "Идентификатор \r\nпроизводителя";
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
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.Frozen = true;
            this.idDataGridViewTextBoxColumn.HeaderText = "Идентификатор";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 112;
            // 
            // manufacturerDataAdapter
            // 
            this.manufacturerDataAdapter.DeleteCommand = this.deleteManufacturerCommand;
            this.manufacturerDataAdapter.InsertCommand = this.insertManufacturerCommand;
            this.manufacturerDataAdapter.SelectCommand = this.selectManufacturerCommand;
            this.manufacturerDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "select_all_manufacturer", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("id", "id"),
                        new System.Data.Common.DataColumnMapping("name", "name")})});
            this.manufacturerDataAdapter.UpdateCommand = this.updateManufacturerCommand;
            // 
            // manufacturersDataGridView
            // 
            this.manufacturersDataGridView.AutoGenerateColumns = false;
            this.manufacturersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.manufacturersDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.manufacturersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manufacturersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.manufacturersDataGridView.DataSource = this.selectallmanufacturerBindingSource;
            this.manufacturersDataGridView.Location = new System.Drawing.Point(11, 11);
            this.manufacturersDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.manufacturersDataGridView.Name = "manufacturersDataGridView";
            this.manufacturersDataGridView.ReadOnly = true;
            this.manufacturersDataGridView.RowHeadersWidth = 62;
            this.manufacturersDataGridView.RowTemplate.Height = 28;
            this.manufacturersDataGridView.Size = new System.Drawing.Size(379, 234);
            this.manufacturersDataGridView.TabIndex = 15;
            // 
            // selectallmanufacturerBindingSource
            // 
            this.selectallmanufacturerBindingSource.DataMember = "select_all_manufacturer";
            this.selectallmanufacturerBindingSource.DataSource = this.dataSet_SelectAllManufacturers;
            // 
            // dataSet_SelectAllManufacturers
            // 
            this.dataSet_SelectAllManufacturers.DataSetName = "DataSet_SelectAllManufacturers";
            this.dataSet_SelectAllManufacturers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // select_all_manufacturerTableAdapter
            // 
            this.select_all_manufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // manufacturerIdTextBox
            // 
            this.manufacturerIdTextBox.Location = new System.Drawing.Point(14, 290);
            this.manufacturerIdTextBox.Mask = "00000";
            this.manufacturerIdTextBox.Name = "manufacturerIdTextBox";
            this.manufacturerIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.manufacturerIdTextBox.TabIndex = 24;
            // 
            // Manufacturers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 321);
            this.Controls.Add(this.manufacturerIdTextBox);
            this.Controls.Add(this.updateManufacturerButton);
            this.Controls.Add(this.findManufacturerButton);
            this.Controls.Add(this.deleteManufacturerButton);
            this.Controls.Add(this.addManufacturerButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.manufacturerNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.manufacturersDataGridView);
            this.Name = "Manufacturers";
            this.Text = "Производители";
            this.Deactivate += new System.EventHandler(this.ManufacturersForm_Deactivate);
            this.Load += new System.EventHandler(this.Manufacturers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.manufacturersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectallmanufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_SelectAllManufacturers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Data.SqlClient.SqlCommand deleteManufacturerCommand;
        private System.Data.SqlClient.SqlConnection sqlConnection;
        private System.Data.SqlClient.SqlCommand updateManufacturerCommand;
        private System.Data.SqlClient.SqlCommand insertManufacturerCommand;
        private System.Data.SqlClient.SqlCommand selectManufacturerCommand;
        private System.Windows.Forms.Button updateManufacturerButton;
        private System.Windows.Forms.Button findManufacturerButton;
        private System.Windows.Forms.Button deleteManufacturerButton;
        private System.Windows.Forms.Button addManufacturerButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox manufacturerNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Data.SqlClient.SqlDataAdapter manufacturerDataAdapter;
        private System.Windows.Forms.DataGridView manufacturersDataGridView;
        private DataSet_SelectAllManufacturers dataSet_SelectAllManufacturers;
        private System.Windows.Forms.BindingSource selectallmanufacturerBindingSource;
        private DataSet_SelectAllManufacturersTableAdapters.select_all_manufacturerTableAdapter select_all_manufacturerTableAdapter;
        private System.Windows.Forms.MaskedTextBox manufacturerIdTextBox;
    }
}