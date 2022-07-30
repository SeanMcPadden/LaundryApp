namespace LaundryUI
{
    partial class InventoryAndAdmin
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
            this.clothFormLabel = new System.Windows.Forms.Label();
            this.clothStatisticsButton = new System.Windows.Forms.Button();
            this.inventoryButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clothFormLabel
            // 
            this.clothFormLabel.AutoSize = true;
            this.clothFormLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clothFormLabel.Location = new System.Drawing.Point(299, 56);
            this.clothFormLabel.Name = "clothFormLabel";
            this.clothFormLabel.Size = new System.Drawing.Size(203, 48);
            this.clothFormLabel.TabIndex = 14;
            this.clothFormLabel.Text = "Cloth form";
            // 
            // clothStatisticsButton
            // 
            this.clothStatisticsButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clothStatisticsButton.Location = new System.Drawing.Point(511, 213);
            this.clothStatisticsButton.Name = "clothStatisticsButton";
            this.clothStatisticsButton.Size = new System.Drawing.Size(254, 51);
            this.clothStatisticsButton.TabIndex = 15;
            this.clothStatisticsButton.Text = "Cloth Statistics";
            this.clothStatisticsButton.UseVisualStyleBackColor = true;
            this.clothStatisticsButton.Click += new System.EventHandler(this.clothStatisticsButton_Click);
            // 
            // inventoryButton
            // 
            this.inventoryButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inventoryButton.Location = new System.Drawing.Point(231, 213);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new System.Drawing.Size(162, 51);
            this.inventoryButton.TabIndex = 16;
            this.inventoryButton.Text = "Inventory";
            this.inventoryButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(750, 500);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(111, 47);
            this.backButton.TabIndex = 17;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // InventoryAndAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 584);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.inventoryButton);
            this.Controls.Add(this.clothStatisticsButton);
            this.Controls.Add(this.clothFormLabel);
            this.Name = "InventoryAndAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryAndAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label clothFormLabel;
        private Button clothStatisticsButton;
        private Button inventoryButton;
        private Button backButton;
    }
}