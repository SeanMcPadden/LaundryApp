namespace LaundryUI.Orders.Wednesday
{
    partial class WednesdaysOrders
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
            this.viewWednesdaysOrdersButton = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.ordersPlacedListBox = new System.Windows.Forms.ListBox();
            this.ordersPlacedLabel = new System.Windows.Forms.Label();
            this.placeOrderButton = new System.Windows.Forms.Button();
            this.ordersNotYetPlacedListBox = new System.Windows.Forms.ListBox();
            this.ordersNotYetPlacedLabel = new System.Windows.Forms.Label();
            this.SundayLabel = new System.Windows.Forms.Label();
            this.homeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // moveButton
            // 
            this.moveButton.Location = new System.Drawing.Point(381, 246);
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
            this.moveSelectedBackButton.Location = new System.Drawing.Point(459, 414);
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
            this.editButton.Location = new System.Drawing.Point(67, 433);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(124, 40);
            this.editButton.TabIndex = 34;
            this.editButton.Text = "Edit Day";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // viewWednesdaysOrdersButton
            // 
            this.viewWednesdaysOrdersButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.viewWednesdaysOrdersButton.Location = new System.Drawing.Point(625, 414);
            this.viewWednesdaysOrdersButton.Name = "viewWednesdaysOrdersButton";
            this.viewWednesdaysOrdersButton.Size = new System.Drawing.Size(142, 115);
            this.viewWednesdaysOrdersButton.TabIndex = 33;
            this.viewWednesdaysOrdersButton.Text = "View Wednesdays Orders";
            this.viewWednesdaysOrdersButton.UseVisualStyleBackColor = true;
            this.viewWednesdaysOrdersButton.Click += new System.EventHandler(this.viewWednesdaysOrdersButton_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBack.Location = new System.Drawing.Point(780, 520);
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
            this.ordersPlacedListBox.Location = new System.Drawing.Point(459, 133);
            this.ordersPlacedListBox.Name = "ordersPlacedListBox";
            this.ordersPlacedListBox.Size = new System.Drawing.Size(308, 279);
            this.ordersPlacedListBox.TabIndex = 31;
            // 
            // ordersPlacedLabel
            // 
            this.ordersPlacedLabel.AutoSize = true;
            this.ordersPlacedLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ordersPlacedLabel.Location = new System.Drawing.Point(459, 92);
            this.ordersPlacedLabel.Name = "ordersPlacedLabel";
            this.ordersPlacedLabel.Size = new System.Drawing.Size(190, 38);
            this.ordersPlacedLabel.TabIndex = 30;
            this.ordersPlacedLabel.Text = "Orders Placed";
            // 
            // placeOrderButton
            // 
            this.placeOrderButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.placeOrderButton.Location = new System.Drawing.Point(218, 433);
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
            this.ordersNotYetPlacedListBox.Location = new System.Drawing.Point(67, 133);
            this.ordersNotYetPlacedListBox.Name = "ordersNotYetPlacedListBox";
            this.ordersNotYetPlacedListBox.Size = new System.Drawing.Size(308, 279);
            this.ordersNotYetPlacedListBox.TabIndex = 28;
            // 
            // ordersNotYetPlacedLabel
            // 
            this.ordersNotYetPlacedLabel.AutoSize = true;
            this.ordersNotYetPlacedLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ordersNotYetPlacedLabel.Location = new System.Drawing.Point(80, 92);
            this.ordersNotYetPlacedLabel.Name = "ordersNotYetPlacedLabel";
            this.ordersNotYetPlacedLabel.Size = new System.Drawing.Size(285, 38);
            this.ordersNotYetPlacedLabel.TabIndex = 27;
            this.ordersNotYetPlacedLabel.Text = "Orders not yet placed";
            // 
            // SundayLabel
            // 
            this.SundayLabel.AutoSize = true;
            this.SundayLabel.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.SundayLabel.Location = new System.Drawing.Point(197, 27);
            this.SundayLabel.Name = "SundayLabel";
            this.SundayLabel.Size = new System.Drawing.Size(452, 48);
            this.SundayLabel.TabIndex = 26;
            this.SundayLabel.Text = "Wednesdays Cloth Orders";
            // 
            // homeButton
            // 
            this.homeButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.homeButton.Location = new System.Drawing.Point(67, 520);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(113, 42);
            this.homeButton.TabIndex = 38;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // WednesdaysOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 584);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.moveButton);
            this.Controls.Add(this.moveSelectedBackButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.viewWednesdaysOrdersButton);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.ordersPlacedListBox);
            this.Controls.Add(this.ordersPlacedLabel);
            this.Controls.Add(this.placeOrderButton);
            this.Controls.Add(this.ordersNotYetPlacedListBox);
            this.Controls.Add(this.ordersNotYetPlacedLabel);
            this.Controls.Add(this.SundayLabel);
            this.Name = "WednesdaysOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WednesdaysOrders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button moveButton;
        private Button moveSelectedBackButton;
        private Button editButton;
        private Button viewWednesdaysOrdersButton;
        private Button buttonBack;
        private ListBox ordersPlacedListBox;
        private Label ordersPlacedLabel;
        private Button placeOrderButton;
        public ListBox ordersNotYetPlacedListBox;
        private Label ordersNotYetPlacedLabel;
        private Label SundayLabel;
        private Button homeButton;
    }
}