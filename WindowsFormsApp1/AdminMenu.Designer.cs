
namespace WindowsFormsApp1
{
    partial class AdminMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.citiesButton = new System.Windows.Forms.Button();
            this.manufacturersButton = new System.Windows.Forms.Button();
            this.airportsButton = new System.Windows.Forms.Button();
            this.planesButton = new System.Windows.Forms.Button();
            this.flightsButton = new System.Windows.Forms.Button();
            this.ticketsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите форму, которую хотите открыть:";
            // 
            // citiesButton
            // 
            this.citiesButton.Location = new System.Drawing.Point(11, 40);
            this.citiesButton.Margin = new System.Windows.Forms.Padding(2);
            this.citiesButton.Name = "citiesButton";
            this.citiesButton.Size = new System.Drawing.Size(117, 37);
            this.citiesButton.TabIndex = 1;
            this.citiesButton.Text = "Города";
            this.citiesButton.UseVisualStyleBackColor = true;
            this.citiesButton.Click += new System.EventHandler(this.citiesButton_Click);
            // 
            // manufacturersButton
            // 
            this.manufacturersButton.Location = new System.Drawing.Point(11, 81);
            this.manufacturersButton.Margin = new System.Windows.Forms.Padding(2);
            this.manufacturersButton.Name = "manufacturersButton";
            this.manufacturersButton.Size = new System.Drawing.Size(117, 37);
            this.manufacturersButton.TabIndex = 5;
            this.manufacturersButton.Text = "Производители";
            this.manufacturersButton.UseVisualStyleBackColor = true;
            this.manufacturersButton.Click += new System.EventHandler(this.manufacturersButton_Click);
            // 
            // airportsButton
            // 
            this.airportsButton.Location = new System.Drawing.Point(132, 40);
            this.airportsButton.Margin = new System.Windows.Forms.Padding(2);
            this.airportsButton.Name = "airportsButton";
            this.airportsButton.Size = new System.Drawing.Size(117, 37);
            this.airportsButton.TabIndex = 6;
            this.airportsButton.Text = "Аэропорты";
            this.airportsButton.UseVisualStyleBackColor = true;
            this.airportsButton.Click += new System.EventHandler(this.airportsButton_Click);
            // 
            // planesButton
            // 
            this.planesButton.Location = new System.Drawing.Point(132, 81);
            this.planesButton.Margin = new System.Windows.Forms.Padding(2);
            this.planesButton.Name = "planesButton";
            this.planesButton.Size = new System.Drawing.Size(117, 37);
            this.planesButton.TabIndex = 7;
            this.planesButton.Text = "Самолеты";
            this.planesButton.UseVisualStyleBackColor = true;
            this.planesButton.Click += new System.EventHandler(this.planesButton_Click);
            // 
            // flightsButton
            // 
            this.flightsButton.Location = new System.Drawing.Point(253, 40);
            this.flightsButton.Margin = new System.Windows.Forms.Padding(2);
            this.flightsButton.Name = "flightsButton";
            this.flightsButton.Size = new System.Drawing.Size(117, 37);
            this.flightsButton.TabIndex = 8;
            this.flightsButton.Text = "Авиарейсы";
            this.flightsButton.UseVisualStyleBackColor = true;
            this.flightsButton.Click += new System.EventHandler(this.flightsButton_Click);
            // 
            // ticketsButton
            // 
            this.ticketsButton.Location = new System.Drawing.Point(253, 81);
            this.ticketsButton.Margin = new System.Windows.Forms.Padding(2);
            this.ticketsButton.Name = "ticketsButton";
            this.ticketsButton.Size = new System.Drawing.Size(117, 37);
            this.ticketsButton.TabIndex = 9;
            this.ticketsButton.Text = "Билеты";
            this.ticketsButton.UseVisualStyleBackColor = true;
            this.ticketsButton.Click += new System.EventHandler(this.ticketsButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 129);
            this.Controls.Add(this.ticketsButton);
            this.Controls.Add(this.flightsButton);
            this.Controls.Add(this.planesButton);
            this.Controls.Add(this.airportsButton);
            this.Controls.Add(this.manufacturersButton);
            this.Controls.Add(this.citiesButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.Text = "Меню администратора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button citiesButton;
        private System.Windows.Forms.Button manufacturersButton;
        private System.Windows.Forms.Button airportsButton;
        private System.Windows.Forms.Button planesButton;
        private System.Windows.Forms.Button flightsButton;
        private System.Windows.Forms.Button ticketsButton;
    }
}