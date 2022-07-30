namespace LaundryUI.Analysis
{
    partial class ClothOrders
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
            this.clothOrdersLabel = new System.Windows.Forms.Label();
            this.clothOrdersGridView = new System.Windows.Forms.DataGridView();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restaurantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napkinBrownDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brown54DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brown70DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barClothDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clothModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clothOrdersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clothOrdersLabel
            // 
            this.clothOrdersLabel.AutoSize = true;
            this.clothOrdersLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clothOrdersLabel.Location = new System.Drawing.Point(480, 18);
            this.clothOrdersLabel.Name = "clothOrdersLabel";
            this.clothOrdersLabel.Size = new System.Drawing.Size(232, 48);
            this.clothOrdersLabel.TabIndex = 0;
            this.clothOrdersLabel.Text = "Cloth Orders";
            // 
            // clothOrdersGridView
            // 
            this.clothOrdersGridView.AutoGenerateColumns = false;
            this.clothOrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clothOrdersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateTimeDataGridViewTextBoxColumn,
            this.restaurantDataGridViewTextBoxColumn,
            this.napkinBrownDataGridViewTextBoxColumn,
            this.whiteDataGridViewTextBoxColumn,
            this.brown54DataGridViewTextBoxColumn,
            this.brown70DataGridViewTextBoxColumn,
            this.barClothDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.clothOrdersGridView.DataSource = this.clothModelBindingSource;
            this.clothOrdersGridView.Location = new System.Drawing.Point(12, 79);
            this.clothOrdersGridView.Name = "clothOrdersGridView";
            this.clothOrdersGridView.RowHeadersWidth = 62;
            this.clothOrdersGridView.RowTemplate.Height = 33;
            this.clothOrdersGridView.Size = new System.Drawing.Size(1224, 577);
            this.clothOrdersGridView.TabIndex = 1;
            this.clothOrdersGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clothOrdersGridView_CellContentClick);
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
            // clothModelBindingSource
            // 
            this.clothModelBindingSource.DataSource = typeof(LaundryLibrary.Models.ClothModel);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(1125, 669);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(111, 47);
            this.backButton.TabIndex = 16;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ClothOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 728);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.clothOrdersGridView);
            this.Controls.Add(this.clothOrdersLabel);
            this.Name = "ClothOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClothOrders";
            this.Load += new System.EventHandler(this.ClothOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clothOrdersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label clothOrdersLabel;
        private DataGridView clothOrdersGridView;
        private BindingSource clothModelBindingSource;
        private Button backButton;
        private DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn restaurantDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn napkinBrownDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn whiteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brown54DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brown70DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn barClothDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}