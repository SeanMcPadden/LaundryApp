namespace LaundryUI.AnalysisDataGrids
{
    partial class kitchenwearOrders
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
            this.kitchenwearOrdersLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.kitchenwearOrdersDataGridView = new System.Windows.Forms.DataGridView();
            this.kitchenwearModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restaurantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jacketReturnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jacketSentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bibApronReturnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bibApronSentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kClothReturnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kClothSentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ovenClothDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trouserBlackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polishClothDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenwearOrdersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenwearModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kitchenwearOrdersLabel
            // 
            this.kitchenwearOrdersLabel.AutoSize = true;
            this.kitchenwearOrdersLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kitchenwearOrdersLabel.Location = new System.Drawing.Point(443, 9);
            this.kitchenwearOrdersLabel.Name = "kitchenwearOrdersLabel";
            this.kitchenwearOrdersLabel.Size = new System.Drawing.Size(350, 48);
            this.kitchenwearOrdersLabel.TabIndex = 1;
            this.kitchenwearOrdersLabel.Text = "Kitchenwear Orders";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(1141, 692);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(111, 47);
            this.backButton.TabIndex = 17;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // kitchenwearOrdersDataGridView
            // 
            this.kitchenwearOrdersDataGridView.AutoGenerateColumns = false;
            this.kitchenwearOrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitchenwearOrdersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.restaurantDataGridViewTextBoxColumn,
            this.jacketReturnDataGridViewTextBoxColumn,
            this.jacketSentDataGridViewTextBoxColumn,
            this.bibApronReturnDataGridViewTextBoxColumn,
            this.bibApronSentDataGridViewTextBoxColumn,
            this.kClothReturnDataGridViewTextBoxColumn,
            this.kClothSentDataGridViewTextBoxColumn,
            this.ovenClothDataGridViewTextBoxColumn,
            this.trouserBlackDataGridViewTextBoxColumn,
            this.polishClothDataGridViewTextBoxColumn,
            this.otherDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.kitchenwearOrdersDataGridView.DataSource = this.kitchenwearModelBindingSource;
            this.kitchenwearOrdersDataGridView.Location = new System.Drawing.Point(12, 60);
            this.kitchenwearOrdersDataGridView.Name = "kitchenwearOrdersDataGridView";
            this.kitchenwearOrdersDataGridView.RowHeadersWidth = 62;
            this.kitchenwearOrdersDataGridView.RowTemplate.Height = 33;
            this.kitchenwearOrdersDataGridView.Size = new System.Drawing.Size(1240, 617);
            this.kitchenwearOrdersDataGridView.TabIndex = 18;
            // 
            // kitchenwearModelBindingSource
            // 
            this.kitchenwearModelBindingSource.DataSource = typeof(LaundryLibrary.Models.KitchenwearModel);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // restaurantDataGridViewTextBoxColumn
            // 
            this.restaurantDataGridViewTextBoxColumn.DataPropertyName = "Restaurant";
            this.restaurantDataGridViewTextBoxColumn.HeaderText = "Restaurant";
            this.restaurantDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.restaurantDataGridViewTextBoxColumn.Name = "restaurantDataGridViewTextBoxColumn";
            this.restaurantDataGridViewTextBoxColumn.Width = 150;
            // 
            // jacketReturnDataGridViewTextBoxColumn
            // 
            this.jacketReturnDataGridViewTextBoxColumn.DataPropertyName = "JacketReturn";
            this.jacketReturnDataGridViewTextBoxColumn.HeaderText = "JacketReturn";
            this.jacketReturnDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.jacketReturnDataGridViewTextBoxColumn.Name = "jacketReturnDataGridViewTextBoxColumn";
            this.jacketReturnDataGridViewTextBoxColumn.Width = 150;
            // 
            // jacketSentDataGridViewTextBoxColumn
            // 
            this.jacketSentDataGridViewTextBoxColumn.DataPropertyName = "JacketSent";
            this.jacketSentDataGridViewTextBoxColumn.HeaderText = "JacketSent";
            this.jacketSentDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.jacketSentDataGridViewTextBoxColumn.Name = "jacketSentDataGridViewTextBoxColumn";
            this.jacketSentDataGridViewTextBoxColumn.Width = 150;
            // 
            // bibApronReturnDataGridViewTextBoxColumn
            // 
            this.bibApronReturnDataGridViewTextBoxColumn.DataPropertyName = "BibApronReturn";
            this.bibApronReturnDataGridViewTextBoxColumn.HeaderText = "BibApronReturn";
            this.bibApronReturnDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bibApronReturnDataGridViewTextBoxColumn.Name = "bibApronReturnDataGridViewTextBoxColumn";
            this.bibApronReturnDataGridViewTextBoxColumn.Width = 150;
            // 
            // bibApronSentDataGridViewTextBoxColumn
            // 
            this.bibApronSentDataGridViewTextBoxColumn.DataPropertyName = "BibApronSent";
            this.bibApronSentDataGridViewTextBoxColumn.HeaderText = "BibApronSent";
            this.bibApronSentDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bibApronSentDataGridViewTextBoxColumn.Name = "bibApronSentDataGridViewTextBoxColumn";
            this.bibApronSentDataGridViewTextBoxColumn.Width = 150;
            // 
            // kClothReturnDataGridViewTextBoxColumn
            // 
            this.kClothReturnDataGridViewTextBoxColumn.DataPropertyName = "KClothReturn";
            this.kClothReturnDataGridViewTextBoxColumn.HeaderText = "KClothReturn";
            this.kClothReturnDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kClothReturnDataGridViewTextBoxColumn.Name = "kClothReturnDataGridViewTextBoxColumn";
            this.kClothReturnDataGridViewTextBoxColumn.Width = 150;
            // 
            // kClothSentDataGridViewTextBoxColumn
            // 
            this.kClothSentDataGridViewTextBoxColumn.DataPropertyName = "KClothSent";
            this.kClothSentDataGridViewTextBoxColumn.HeaderText = "KClothSent";
            this.kClothSentDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kClothSentDataGridViewTextBoxColumn.Name = "kClothSentDataGridViewTextBoxColumn";
            this.kClothSentDataGridViewTextBoxColumn.Width = 150;
            // 
            // ovenClothDataGridViewTextBoxColumn
            // 
            this.ovenClothDataGridViewTextBoxColumn.DataPropertyName = "OvenCloth";
            this.ovenClothDataGridViewTextBoxColumn.HeaderText = "OvenCloth";
            this.ovenClothDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ovenClothDataGridViewTextBoxColumn.Name = "ovenClothDataGridViewTextBoxColumn";
            this.ovenClothDataGridViewTextBoxColumn.Width = 150;
            // 
            // trouserBlackDataGridViewTextBoxColumn
            // 
            this.trouserBlackDataGridViewTextBoxColumn.DataPropertyName = "TrouserBlack";
            this.trouserBlackDataGridViewTextBoxColumn.HeaderText = "TrouserBlack";
            this.trouserBlackDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.trouserBlackDataGridViewTextBoxColumn.Name = "trouserBlackDataGridViewTextBoxColumn";
            this.trouserBlackDataGridViewTextBoxColumn.Width = 150;
            // 
            // polishClothDataGridViewTextBoxColumn
            // 
            this.polishClothDataGridViewTextBoxColumn.DataPropertyName = "PolishCloth";
            this.polishClothDataGridViewTextBoxColumn.HeaderText = "PolishCloth";
            this.polishClothDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.polishClothDataGridViewTextBoxColumn.Name = "polishClothDataGridViewTextBoxColumn";
            this.polishClothDataGridViewTextBoxColumn.Width = 150;
            // 
            // otherDataGridViewTextBoxColumn
            // 
            this.otherDataGridViewTextBoxColumn.DataPropertyName = "Other";
            this.otherDataGridViewTextBoxColumn.HeaderText = "Other";
            this.otherDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.otherDataGridViewTextBoxColumn.Name = "otherDataGridViewTextBoxColumn";
            this.otherDataGridViewTextBoxColumn.Width = 150;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // kitchenwearOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 751);
            this.Controls.Add(this.kitchenwearOrdersDataGridView);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.kitchenwearOrdersLabel);
            this.Name = "kitchenwearOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kitchenwearOrders";
            this.Load += new System.EventHandler(this.kitchenwearOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kitchenwearOrdersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenwearModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label kitchenwearOrdersLabel;
        private Button backButton;
        private DataGridView kitchenwearOrdersDataGridView;
        private BindingSource kitchenwearModelBindingSource;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn restaurantDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn jacketReturnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn jacketSentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bibApronReturnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bibApronSentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kClothReturnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kClothSentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ovenClothDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn trouserBlackDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn polishClothDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn otherDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}