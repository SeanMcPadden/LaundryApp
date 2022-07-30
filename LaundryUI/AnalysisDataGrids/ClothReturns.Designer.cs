namespace LaundryUI.AnalysisDataGrids
{
    partial class ClothReturns
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
            this.clothReturnsLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.ClothReturnsDataGridView = new System.Windows.Forms.DataGridView();
            this.clothModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restaurantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayOfWeekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napkinBrownDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brown54DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brown70DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barClothDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ClothReturnsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clothReturnsLabel
            // 
            this.clothReturnsLabel.AutoSize = true;
            this.clothReturnsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clothReturnsLabel.Location = new System.Drawing.Point(480, 9);
            this.clothReturnsLabel.Name = "clothReturnsLabel";
            this.clothReturnsLabel.Size = new System.Drawing.Size(250, 48);
            this.clothReturnsLabel.TabIndex = 2;
            this.clothReturnsLabel.Text = "Cloth Returns";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(1125, 681);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(111, 47);
            this.backButton.TabIndex = 18;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ClothReturnsDataGridView
            // 
            this.ClothReturnsDataGridView.AutoGenerateColumns = false;
            this.ClothReturnsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClothReturnsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateTimeDataGridViewTextBoxColumn,
            this.restaurantDataGridViewTextBoxColumn,
            this.dayOfWeekDataGridViewTextBoxColumn,
            this.napkinBrownDataGridViewTextBoxColumn,
            this.whiteDataGridViewTextBoxColumn,
            this.brown54DataGridViewTextBoxColumn,
            this.brown70DataGridViewTextBoxColumn,
            this.barClothDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.ClothReturnsDataGridView.DataSource = this.clothModelBindingSource;
            this.ClothReturnsDataGridView.Location = new System.Drawing.Point(12, 64);
            this.ClothReturnsDataGridView.Name = "ClothReturnsDataGridView";
            this.ClothReturnsDataGridView.RowHeadersWidth = 62;
            this.ClothReturnsDataGridView.RowTemplate.Height = 33;
            this.ClothReturnsDataGridView.Size = new System.Drawing.Size(1224, 600);
            this.ClothReturnsDataGridView.TabIndex = 19;
            // 
            // clothModelBindingSource
            // 
            this.clothModelBindingSource.DataSource = typeof(LaundryLibrary.Models.ClothModel);
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            this.dateTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // restaurantDataGridViewTextBoxColumn
            // 
            this.restaurantDataGridViewTextBoxColumn.DataPropertyName = "Restaurant";
            this.restaurantDataGridViewTextBoxColumn.HeaderText = "Restaurant";
            this.restaurantDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.restaurantDataGridViewTextBoxColumn.Name = "restaurantDataGridViewTextBoxColumn";
            this.restaurantDataGridViewTextBoxColumn.Width = 150;
            // 
            // dayOfWeekDataGridViewTextBoxColumn
            // 
            this.dayOfWeekDataGridViewTextBoxColumn.DataPropertyName = "DayOfWeek";
            this.dayOfWeekDataGridViewTextBoxColumn.HeaderText = "DayOfWeek";
            this.dayOfWeekDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dayOfWeekDataGridViewTextBoxColumn.Name = "dayOfWeekDataGridViewTextBoxColumn";
            this.dayOfWeekDataGridViewTextBoxColumn.Width = 150;
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
            // ClothReturns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 740);
            this.Controls.Add(this.ClothReturnsDataGridView);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.clothReturnsLabel);
            this.Name = "ClothReturns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClothReturns";
            this.Load += new System.EventHandler(this.ClothReturns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClothReturnsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label clothReturnsLabel;
        private Button backButton;
        private DataGridView ClothReturnsDataGridView;
        private DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn restaurantDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dayOfWeekDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn napkinBrownDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn whiteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brown54DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brown70DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn barClothDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private BindingSource clothModelBindingSource;
    }
}