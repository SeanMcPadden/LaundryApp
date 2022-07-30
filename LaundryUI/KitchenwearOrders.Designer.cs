namespace LaundryUI
{
    partial class KitchenwearOrders
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
            this.kitchenwearOrdersGridView = new System.Windows.Forms.DataGridView();
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
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeekNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitchenwearModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenwearOrdersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenwearModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(341, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Today\'s Kitchenwear Orders";
            // 
            // kitchenwearOrdersGridView
            // 
            this.kitchenwearOrdersGridView.AutoGenerateColumns = false;
            this.kitchenwearOrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitchenwearOrdersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.WeekNumber,
            this.CurrentWeek});
            this.kitchenwearOrdersGridView.DataSource = this.kitchenwearModelBindingSource;
            this.kitchenwearOrdersGridView.Location = new System.Drawing.Point(12, 76);
            this.kitchenwearOrdersGridView.Name = "kitchenwearOrdersGridView";
            this.kitchenwearOrdersGridView.RowHeadersWidth = 62;
            this.kitchenwearOrdersGridView.RowTemplate.Height = 33;
            this.kitchenwearOrdersGridView.Size = new System.Drawing.Size(1205, 571);
            this.kitchenwearOrdersGridView.TabIndex = 2;
            this.kitchenwearOrdersGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // WeekNumber
            // 
            this.WeekNumber.DataPropertyName = "WeekNumber";
            this.WeekNumber.HeaderText = "WeekNumber";
            this.WeekNumber.MinimumWidth = 8;
            this.WeekNumber.Name = "WeekNumber";
            this.WeekNumber.Width = 150;
            // 
            // CurrentWeek
            // 
            this.CurrentWeek.DataPropertyName = "CurrentWeek";
            this.CurrentWeek.HeaderText = "CurrentWeek";
            this.CurrentWeek.MinimumWidth = 8;
            this.CurrentWeek.Name = "CurrentWeek";
            this.CurrentWeek.Width = 150;
            // 
            // kitchenwearModelBindingSource
            // 
            this.kitchenwearModelBindingSource.DataSource = typeof(LaundryLibrary.Models.KitchenwearModel);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(1104, 653);
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
            this.homeButton.Location = new System.Drawing.Point(12, 653);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(122, 42);
            this.homeButton.TabIndex = 40;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // KitchenwearOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 705);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.kitchenwearOrdersGridView);
            this.Controls.Add(this.label1);
            this.Name = "KitchenwearOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitchenwear Orders";
            this.Load += new System.EventHandler(this.kitchenwearOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kitchenwearOrdersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitchenwearModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView kitchenwearOrdersGridView;
        private BindingSource kitchenwearModelBindingSource;
        private Button backButton;
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
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn WeekNumber;
        private DataGridViewTextBoxColumn CurrentWeek;
        private Button homeButton;
    }
}