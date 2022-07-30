namespace LaundryUI
{
    partial class OrdersData
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
            this.clothModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backButton = new System.Windows.Forms.Button();
            this.clothModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clothModelBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mondaysOrdersGridView = new System.Windows.Forms.DataGridView();
            this.restaurantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napkinBrownDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brown54DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brown70DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barClothDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayOfWeekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentWeekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weekNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clothModelBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.homeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clothModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothModelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothModelBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mondaysOrdersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothModelBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(430, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Today\'s Orders";
            // 
            // clothModelBindingSource
            // 
            this.clothModelBindingSource.DataSource = typeof(LaundryLibrary.Models.ClothModel);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(1096, 628);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(113, 42);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // clothModelBindingSource1
            // 
            this.clothModelBindingSource1.DataSource = typeof(LaundryLibrary.Models.ClothModel);
            // 
            // clothModelBindingSource2
            // 
            this.clothModelBindingSource2.DataSource = typeof(LaundryLibrary.Models.ClothModel);
            // 
            // mondaysOrdersGridView
            // 
            this.mondaysOrdersGridView.AutoGenerateColumns = false;
            this.mondaysOrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mondaysOrdersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.restaurantDataGridViewTextBoxColumn,
            this.napkinBrownDataGridViewTextBoxColumn,
            this.whiteDataGridViewTextBoxColumn,
            this.brown54DataGridViewTextBoxColumn,
            this.brown70DataGridViewTextBoxColumn,
            this.barClothDataGridViewTextBoxColumn,
            this.dayOfWeekDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.dateTimeDataGridViewTextBoxColumn,
            this.currentWeekDataGridViewTextBoxColumn,
            this.weekNumberDataGridViewTextBoxColumn});
            this.mondaysOrdersGridView.DataSource = this.clothModelBindingSource3;
            this.mondaysOrdersGridView.Location = new System.Drawing.Point(12, 62);
            this.mondaysOrdersGridView.Name = "mondaysOrdersGridView";
            this.mondaysOrdersGridView.RowHeadersWidth = 62;
            this.mondaysOrdersGridView.RowTemplate.Height = 33;
            this.mondaysOrdersGridView.Size = new System.Drawing.Size(1197, 560);
            this.mondaysOrdersGridView.TabIndex = 12;
            this.mondaysOrdersGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mondaysOrdersDataGridView_CellContentClick);
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
            // dayOfWeekDataGridViewTextBoxColumn
            // 
            this.dayOfWeekDataGridViewTextBoxColumn.DataPropertyName = "DayOfWeek";
            this.dayOfWeekDataGridViewTextBoxColumn.HeaderText = "DayOfWeek";
            this.dayOfWeekDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dayOfWeekDataGridViewTextBoxColumn.Name = "dayOfWeekDataGridViewTextBoxColumn";
            this.dayOfWeekDataGridViewTextBoxColumn.Width = 150;
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
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            this.dateTimeDataGridViewTextBoxColumn.Width = 150;
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
            // clothModelBindingSource3
            // 
            this.clothModelBindingSource3.DataSource = typeof(LaundryLibrary.Models.ClothModel);
            // 
            // homeButton
            // 
            this.homeButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.homeButton.Location = new System.Drawing.Point(12, 639);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(122, 42);
            this.homeButton.TabIndex = 41;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // OrdersData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 693);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.mondaysOrdersGridView);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Name = "OrdersData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MondaysOrders";
            this.Load += new System.EventHandler(this.MondaysOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clothModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothModelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothModelBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mondaysOrdersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothModelBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private BindingSource clothModelBindingSource;
        private Button backButton;
        private BindingSource clothModelBindingSource1;
        private BindingSource clothModelBindingSource2;
        private DataGridView mondaysOrdersGridView;
        private BindingSource clothModelBindingSource3;
        private DataGridViewTextBoxColumn restaurantDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn napkinBrownDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn whiteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brown54DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brown70DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn barClothDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dayOfWeekDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn currentWeekDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn weekNumberDataGridViewTextBoxColumn;
        private Button homeButton;
    }
}