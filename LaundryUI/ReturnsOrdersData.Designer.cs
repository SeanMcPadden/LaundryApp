namespace LaundryUI.Orders.Monday
{
    partial class ReturnsOrdersData
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
            this.label1 = new System.Windows.Forms.Label();
            this.mondaysReturnsDataGridView = new System.Windows.Forms.DataGridView();
            this.restaurantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napkinBrownDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brown54DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brown70DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barClothDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayOfWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentWeekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weekNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clothModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mondaysReturnsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(441, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Today\'s Returns";
            // 
            // mondaysReturnsDataGridView
            // 
            this.mondaysReturnsDataGridView.AutoGenerateColumns = false;
            this.mondaysReturnsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mondaysReturnsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.restaurantDataGridViewTextBoxColumn,
            this.napkinBrownDataGridViewTextBoxColumn,
            this.whiteDataGridViewTextBoxColumn,
            this.brown54DataGridViewTextBoxColumn,
            this.brown70DataGridViewTextBoxColumn,
            this.barClothDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.dateTimeDataGridViewTextBoxColumn,
            this.DayOfWeek,
            this.currentWeekDataGridViewTextBoxColumn,
            this.weekNumberDataGridViewTextBoxColumn});
            this.mondaysReturnsDataGridView.DataSource = this.clothModelBindingSource;
            this.mondaysReturnsDataGridView.Location = new System.Drawing.Point(12, 76);
            this.mondaysReturnsDataGridView.Name = "mondaysReturnsDataGridView";
            this.mondaysReturnsDataGridView.RowHeadersWidth = 62;
            this.mondaysReturnsDataGridView.RowTemplate.Height = 33;
            this.mondaysReturnsDataGridView.Size = new System.Drawing.Size(1236, 583);
            this.mondaysReturnsDataGridView.TabIndex = 2;
            // 
            // restaurantDataGridViewTextBoxColumn
            // 
            this.restaurantDataGridViewTextBoxColumn.DataPropertyName = "Restaurant";
            this.restaurantDataGridViewTextBoxColumn.HeaderText = "Restaurant";
            this.restaurantDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.restaurantDataGridViewTextBoxColumn.Name = "restaurantDataGridViewTextBoxColumn";
            this.restaurantDataGridViewTextBoxColumn.Width = 150;
            // 
            // napkinBrownDataGridViewTextBoxColumn
            // 
            this.napkinBrownDataGridViewTextBoxColumn.DataPropertyName = "NapkinBrown";
            this.napkinBrownDataGridViewTextBoxColumn.HeaderText = "NapkinBrown";
            this.napkinBrownDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.napkinBrownDataGridViewTextBoxColumn.Name = "napkinBrownDataGridViewTextBoxColumn";
            this.napkinBrownDataGridViewTextBoxColumn.Width = 150;
            // 
            // whiteDataGridViewTextBoxColumn
            // 
            this.whiteDataGridViewTextBoxColumn.DataPropertyName = "White";
            this.whiteDataGridViewTextBoxColumn.HeaderText = "White";
            this.whiteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.whiteDataGridViewTextBoxColumn.Name = "whiteDataGridViewTextBoxColumn";
            this.whiteDataGridViewTextBoxColumn.Width = 150;
            // 
            // brown54DataGridViewTextBoxColumn
            // 
            this.brown54DataGridViewTextBoxColumn.DataPropertyName = "Brown54";
            this.brown54DataGridViewTextBoxColumn.HeaderText = "Brown54";
            this.brown54DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.brown54DataGridViewTextBoxColumn.Name = "brown54DataGridViewTextBoxColumn";
            this.brown54DataGridViewTextBoxColumn.Width = 150;
            // 
            // brown70DataGridViewTextBoxColumn
            // 
            this.brown70DataGridViewTextBoxColumn.DataPropertyName = "Brown70";
            this.brown70DataGridViewTextBoxColumn.HeaderText = "Brown70";
            this.brown70DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.brown70DataGridViewTextBoxColumn.Name = "brown70DataGridViewTextBoxColumn";
            this.brown70DataGridViewTextBoxColumn.Width = 150;
            // 
            // barClothDataGridViewTextBoxColumn
            // 
            this.barClothDataGridViewTextBoxColumn.DataPropertyName = "BarCloth";
            this.barClothDataGridViewTextBoxColumn.HeaderText = "BarCloth";
            this.barClothDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.barClothDataGridViewTextBoxColumn.Name = "barClothDataGridViewTextBoxColumn";
            this.barClothDataGridViewTextBoxColumn.Width = 150;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            this.dateTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // DayOfWeek
            // 
            this.DayOfWeek.DataPropertyName = "DayOfWeek";
            this.DayOfWeek.HeaderText = "DayOfWeek";
            this.DayOfWeek.MinimumWidth = 8;
            this.DayOfWeek.Name = "DayOfWeek";
            this.DayOfWeek.Width = 150;
            // 
            // currentWeekDataGridViewTextBoxColumn
            // 
            this.currentWeekDataGridViewTextBoxColumn.DataPropertyName = "CurrentWeek";
            this.currentWeekDataGridViewTextBoxColumn.HeaderText = "CurrentWeek";
            this.currentWeekDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.currentWeekDataGridViewTextBoxColumn.Name = "currentWeekDataGridViewTextBoxColumn";
            this.currentWeekDataGridViewTextBoxColumn.Width = 150;
            // 
            // weekNumberDataGridViewTextBoxColumn
            // 
            this.weekNumberDataGridViewTextBoxColumn.DataPropertyName = "WeekNumber";
            this.weekNumberDataGridViewTextBoxColumn.HeaderText = "WeekNumber";
            this.weekNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.weekNumberDataGridViewTextBoxColumn.Name = "weekNumberDataGridViewTextBoxColumn";
            this.weekNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // clothModelBindingSource
            // 
            this.clothModelBindingSource.DataSource = typeof(LaundryLibrary.Models.ClothModel);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(1135, 665);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(113, 42);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.homeButton.Location = new System.Drawing.Point(12, 665);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(122, 42);
            this.homeButton.TabIndex = 41;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // ReturnsOrdersData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 718);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.mondaysReturnsDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "ReturnsOrdersData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders Returned";
            this.Load += new System.EventHandler(this.MondaysReturnsOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mondaysReturnsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView mondaysReturnsDataGridView;
        private BindingSource clothModelBindingSource;
        private Button backButton;
        private DataGridViewTextBoxColumn restaurantDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn napkinBrownDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn whiteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brown54DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brown70DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn barClothDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn DayOfWeek;
        private DataGridViewTextBoxColumn currentWeekDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn weekNumberDataGridViewTextBoxColumn;
        private Button homeButton;
    }
}