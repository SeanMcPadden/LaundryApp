namespace LaundryUI
{
    partial class Home
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
            this.ordersButton = new System.Windows.Forms.Button();
            this.returnsButton = new System.Windows.Forms.Button();
            this.inventoryButton = new System.Windows.Forms.Button();
            this.analysisButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(297, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Laundry Factory ";
            // 
            // ordersButton
            // 
            this.ordersButton.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ordersButton.Location = new System.Drawing.Point(242, 161);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(184, 142);
            this.ordersButton.TabIndex = 1;
            this.ordersButton.Text = "Orders";
            this.ordersButton.UseVisualStyleBackColor = true;
            this.ordersButton.Click += new System.EventHandler(this.ordersButton_Click);
            // 
            // returnsButton
            // 
            this.returnsButton.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.returnsButton.Location = new System.Drawing.Point(519, 161);
            this.returnsButton.Name = "returnsButton";
            this.returnsButton.Size = new System.Drawing.Size(186, 142);
            this.returnsButton.TabIndex = 2;
            this.returnsButton.Text = "Returns";
            this.returnsButton.UseVisualStyleBackColor = true;
            this.returnsButton.Click += new System.EventHandler(this.returnsButton_Click);
            // 
            // inventoryButton
            // 
            this.inventoryButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inventoryButton.Location = new System.Drawing.Point(257, 393);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new System.Drawing.Size(151, 53);
            this.inventoryButton.TabIndex = 3;
            this.inventoryButton.Text = "Inventory";
            this.inventoryButton.UseVisualStyleBackColor = true;
            this.inventoryButton.Click += new System.EventHandler(this.inventoryButton_Click);
            // 
            // analysisButton
            // 
            this.analysisButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.analysisButton.Location = new System.Drawing.Point(537, 393);
            this.analysisButton.Name = "analysisButton";
            this.analysisButton.Size = new System.Drawing.Size(151, 53);
            this.analysisButton.TabIndex = 4;
            this.analysisButton.Text = "Analysis";
            this.analysisButton.UseVisualStyleBackColor = true;
            this.analysisButton.Click += new System.EventHandler(this.analysisButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 584);
            this.Controls.Add(this.analysisButton);
            this.Controls.Add(this.inventoryButton);
            this.Controls.Add(this.returnsButton);
            this.Controls.Add(this.ordersButton);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button ordersButton;
        private Button returnsButton;
        private Button inventoryButton;
        private Button analysisButton;
    }
}