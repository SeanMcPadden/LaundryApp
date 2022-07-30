namespace LaundryUI.Orders.Friday
{
    partial class FridaysOrders
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
            this.moveButton = new System.Windows.Forms.Button();
            this.moveSelectedBackButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.viewFridaysOrdersButton = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.ordersPlacedListBox = new System.Windows.Forms.ListBox();
            this.ordersPlacedLabel = new System.Windows.Forms.Label();
            this.placeOrderButton = new System.Windows.Forms.Button();
            this.ordersNotYetPlacedListBox = new System.Windows.Forms.ListBox();
            this.ordersNotYetPlacedLabel = new System.Windows.Forms.Label();
            this.FridayLabel = new System.Windows.Forms.Label();
            this.homeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // moveButton
            // 
            this.moveButton.Location = new System.Drawing.Point(391, 239);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(72, 34);
            this.moveButton.TabIndex = 36;
            this.moveButton.Text = "Move";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // moveSelectedBackButton
            // 
            this.moveSelectedBackButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.moveSelectedBackButton.Location = new System.Drawing.Point(503, 405);
            this.moveSelectedBackButton.Name = "moveSelectedBackButton";
            this.moveSelectedBackButton.Size = new System.Drawing.Size(157, 115);
            this.moveSelectedBackButton.TabIndex = 35;
            this.moveSelectedBackButton.Text = "Move selected to not yet placed";
            this.moveSelectedBackButton.UseVisualStyleBackColor = true;
            this.moveSelectedBackButton.Click += new System.EventHandler(this.moveSelectedBackButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editButton.Location = new System.Drawing.Point(50, 429);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(124, 40);
            this.editButton.TabIndex = 34;
            this.editButton.Text = "Edit Day";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // viewFridaysOrdersButton
            // 
            this.viewFridaysOrdersButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.viewFridaysOrdersButton.Location = new System.Drawing.Point(669, 405);
            this.viewFridaysOrdersButton.Name = "viewFridaysOrdersButton";
            this.viewFridaysOrdersButton.Size = new System.Drawing.Size(142, 115);
            this.viewFridaysOrdersButton.TabIndex = 33;
            this.viewFridaysOrdersButton.Text = "View Fridays Orders";
            this.viewFridaysOrdersButton.UseVisualStyleBackColor = true;
            this.viewFridaysOrdersButton.Click += new System.EventHandler(this.viewFridaysOrdersButton_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBack.Location = new System.Drawing.Point(803, 530);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(113, 42);
            this.buttonBack.TabIndex = 32;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // ordersPlacedListBox
            // 
            this.ordersPlacedListBox.FormattingEnabled = true;
            this.ordersPlacedListBox.ItemHeight = 25;
            this.ordersPlacedListBox.Location = new System.Drawing.Point(503, 124);
            this.ordersPlacedListBox.Name = "ordersPlacedListBox";
            this.ordersPlacedListBox.Size = new System.Drawing.Size(308, 279);
            this.ordersPlacedListBox.TabIndex = 31;
            // 
            // ordersPlacedLabel
            // 
            this.ordersPlacedLabel.AutoSize = true;
            this.ordersPlacedLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ordersPlacedLabel.Location = new System.Drawing.Point(503, 83);
            this.ordersPlacedLabel.Name = "ordersPlacedLabel";
            this.ordersPlacedLabel.Size = new System.Drawing.Size(190, 38);
            this.ordersPlacedLabel.TabIndex = 30;
            this.ordersPlacedLabel.Text = "Orders Placed";
            // 
            // placeOrderButton
            // 
            this.placeOrderButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.placeOrderButton.Location = new System.Drawing.Point(201, 429);
            this.placeOrderButton.Name = "placeOrderButton";
            this.placeOrderButton.Size = new System.Drawing.Size(157, 42);
            this.placeOrderButton.TabIndex = 29;
            this.placeOrderButton.Text = "Place Order";
            this.placeOrderButton.UseVisualStyleBackColor = true;
            this.placeOrderButton.Click += new System.EventHandler(this.placeOrderButton_Click);
            // 
            // ordersNotYetPlacedListBox
            // 
            this.ordersNotYetPlacedListBox.FormattingEnabled = true;
            this.ordersNotYetPlacedListBox.ItemHeight = 25;
            this.ordersNotYetPlacedListBox.Location = new System.Drawing.Point(50, 129);
            this.ordersNotYetPlacedListBox.Name = "ordersNotYetPlacedListBox";
            this.ordersNotYetPlacedListBox.Size = new System.Drawing.Size(308, 279);
            this.ordersNotYetPlacedListBox.TabIndex = 28;
            // 
            // ordersNotYetPlacedLabel
            // 
            this.ordersNotYetPlacedLabel.AutoSize = true;
            this.ordersNotYetPlacedLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ordersNotYetPlacedLabel.Location = new System.Drawing.Point(63, 88);
            this.ordersNotYetPlacedLabel.Name = "ordersNotYetPlacedLabel";
            this.ordersNotYetPlacedLabel.Size = new System.Drawing.Size(285, 38);
            this.ordersNotYetPlacedLabel.TabIndex = 27;
            this.ordersNotYetPlacedLabel.Text = "Orders not yet placed";
            // 
            // FridayLabel
            // 
            this.FridayLabel.AutoSize = true;
            this.FridayLabel.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.FridayLabel.Location = new System.Drawing.Point(232, 26);
            this.FridayLabel.Name = "FridayLabel";
            this.FridayLabel.Size = new System.Drawing.Size(347, 48);
            this.FridayLabel.TabIndex = 26;
            this.FridayLabel.Text = "Friday Cloth Orders";
            // 
            // homeButton
            // 
            this.homeButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.homeButton.Location = new System.Drawing.Point(50, 530);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(113, 42);
            this.homeButton.TabIndex = 38;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // FridaysOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 584);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.moveButton);
            this.Controls.Add(this.moveSelectedBackButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.viewFridaysOrdersButton);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.ordersPlacedListBox);
            this.Controls.Add(this.ordersPlacedLabel);
            this.Controls.Add(this.placeOrderButton);
            this.Controls.Add(this.ordersNotYetPlacedListBox);
            this.Controls.Add(this.ordersNotYetPlacedLabel);
            this.Controls.Add(this.FridayLabel);
            this.Name = "FridaysOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FridaysOrders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button moveButton;
        private Button moveSelectedBackButton;
        private Button editButton;
        private Button viewFridaysOrdersButton;
        private Button buttonBack;
        private ListBox ordersPlacedListBox;
        private Label ordersPlacedLabel;
        private Button placeOrderButton;
        public ListBox ordersNotYetPlacedListBox;
        private Label ordersNotYetPlacedLabel;
        private Label FridayLabel;
        private Button homeButton;
    }
}