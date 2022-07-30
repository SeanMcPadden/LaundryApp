namespace LaundryUI.AnalysisDataGrids
{
    partial class RestaurantDetails
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
            this.restaurantDetailsLabel = new System.Windows.Forms.Label();
            this.restaurantDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.restaurantModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backButton = new System.Windows.Forms.Button();
            this.dayModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Restaurant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Driver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bagColourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayOfWeekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDetailsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // restaurantDetailsLabel
            // 
            this.restaurantDetailsLabel.AutoSize = true;
            this.restaurantDetailsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.restaurantDetailsLabel.Location = new System.Drawing.Point(459, 9);
            this.restaurantDetailsLabel.Name = "restaurantDetailsLabel";
            this.restaurantDetailsLabel.Size = new System.Drawing.Size(327, 48);
            this.restaurantDetailsLabel.TabIndex = 1;
            this.restaurantDetailsLabel.Text = "Restaurant Details";
            // 
            // restaurantDetailsDataGridView
            // 
            this.restaurantDetailsDataGridView.AutoGenerateColumns = false;
            this.restaurantDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.restaurantDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Restaurant,
            this.addressDataGridViewTextBoxColumn,
            this.Driver,
            this.bagColourDataGridViewTextBoxColumn,
            this.Location,
            this.dayOfWeekDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.Notes});
            this.restaurantDetailsDataGridView.DataSource = this.dayModelBindingSource;
            this.restaurantDetailsDataGridView.Location = new System.Drawing.Point(12, 60);
            this.restaurantDetailsDataGridView.Name = "restaurantDetailsDataGridView";
            this.restaurantDetailsDataGridView.RowHeadersWidth = 62;
            this.restaurantDetailsDataGridView.RowTemplate.Height = 33;
            this.restaurantDetailsDataGridView.Size = new System.Drawing.Size(1245, 582);
            this.restaurantDetailsDataGridView.TabIndex = 2;
            // 
            // restaurantModelBindingSource
            // 
            this.restaurantModelBindingSource.DataSource = typeof(LaundryLibrary.Models.RestaurantModel);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(1146, 648);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(111, 47);
            this.backButton.TabIndex = 17;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // dayModelBindingSource
            // 
            this.dayModelBindingSource.DataSource = typeof(LaundryLibrary.Models.DayModel);
            // 
            // Restaurant
            // 
            this.Restaurant.DataPropertyName = "Restaurant";
            this.Restaurant.HeaderText = "Restaurant";
            this.Restaurant.MinimumWidth = 8;
            this.Restaurant.Name = "Restaurant";
            this.Restaurant.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 150;
            // 
            // Driver
            // 
            this.Driver.DataPropertyName = "Driver";
            this.Driver.HeaderText = "Driver";
            this.Driver.MinimumWidth = 8;
            this.Driver.Name = "Driver";
            this.Driver.Width = 150;
            // 
            // bagColourDataGridViewTextBoxColumn
            // 
            this.bagColourDataGridViewTextBoxColumn.DataPropertyName = "BagColour";
            this.bagColourDataGridViewTextBoxColumn.HeaderText = "BagColour";
            this.bagColourDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bagColourDataGridViewTextBoxColumn.Name = "bagColourDataGridViewTextBoxColumn";
            this.bagColourDataGridViewTextBoxColumn.Width = 150;
            // 
            // Location
            // 
            this.Location.DataPropertyName = "Location";
            this.Location.HeaderText = "Location";
            this.Location.MinimumWidth = 8;
            this.Location.Name = "Location";
            this.Location.Width = 150;
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
            // Notes
            // 
            this.Notes.DataPropertyName = "Notes";
            this.Notes.HeaderText = "Notes";
            this.Notes.MinimumWidth = 8;
            this.Notes.Name = "Notes";
            this.Notes.Width = 150;
            // 
            // RestaurantDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 700);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.restaurantDetailsDataGridView);
            this.Controls.Add(this.restaurantDetailsLabel);
            this.Name = "RestaurantDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RestaurantDetails";
            this.Load += new System.EventHandler(this.RestaurantDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDetailsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label restaurantDetailsLabel;
        private DataGridView restaurantDetailsDataGridView;
        private Button backButton;
        private BindingSource restaurantModelBindingSource;
        private DataGridViewTextBoxColumn Restaurant;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Driver;
        private DataGridViewTextBoxColumn bagColourDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Location;
        private DataGridViewTextBoxColumn dayOfWeekDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Notes;
        private BindingSource dayModelBindingSource;
    }
}