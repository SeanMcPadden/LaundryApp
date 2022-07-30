namespace LaundryUI.AnalysisDataGrids
{
    partial class RestaurantsDetails
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
            this.restaurantDetailsLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.forRestaurantLabel = new System.Windows.Forms.Label();
            this.restaurantInput = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressInput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // restaurantDetailsLabel
            // 
            this.restaurantDetailsLabel.AutoSize = true;
            this.restaurantDetailsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.restaurantDetailsLabel.Location = new System.Drawing.Point(261, 9);
            this.restaurantDetailsLabel.Name = "restaurantDetailsLabel";
            this.restaurantDetailsLabel.Size = new System.Drawing.Size(327, 48);
            this.restaurantDetailsLabel.TabIndex = 2;
            this.restaurantDetailsLabel.Text = "Restaurant Details";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(795, 525);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(111, 47);
            this.backButton.TabIndex = 18;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // forRestaurantLabel
            // 
            this.forRestaurantLabel.AutoSize = true;
            this.forRestaurantLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.forRestaurantLabel.Location = new System.Drawing.Point(26, 86);
            this.forRestaurantLabel.Name = "forRestaurantLabel";
            this.forRestaurantLabel.Size = new System.Drawing.Size(186, 45);
            this.forRestaurantLabel.TabIndex = 19;
            this.forRestaurantLabel.Text = "Restaurant:";
            // 
            // restaurantInput
            // 
            this.restaurantInput.AutoSize = true;
            this.restaurantInput.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.restaurantInput.Location = new System.Drawing.Point(227, 86);
            this.restaurantInput.Name = "restaurantInput";
            this.restaurantInput.Size = new System.Drawing.Size(0, 45);
            this.restaurantInput.TabIndex = 20;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addressLabel.Location = new System.Drawing.Point(432, 86);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(144, 45);
            this.addressLabel.TabIndex = 21;
            this.addressLabel.Text = "Address:";
            // 
            // addressInput
            // 
            this.addressInput.AutoSize = true;
            this.addressInput.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addressInput.Location = new System.Drawing.Point(582, 86);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(0, 45);
            this.addressInput.TabIndex = 22;
            // 
            // RestaurantsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 584);
            this.Controls.Add(this.addressInput);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.restaurantInput);
            this.Controls.Add(this.forRestaurantLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.restaurantDetailsLabel);
            this.Name = "RestaurantsDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RestaurantsDetails";
            this.Load += new System.EventHandler(this.RestaurantsDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label restaurantDetailsLabel;
        private Button backButton;
        private Label forRestaurantLabel;
        private Label restaurantInput;
        private Label addressLabel;
        private Label addressInput;
    }
}