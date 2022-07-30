namespace LaundryUI
{
    partial class  MondaysOrders 
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MondayLabel = new System.Windows.Forms.Label();
            this.ordersNotYetPlacedLabel = new System.Windows.Forms.Label();
            this.ordersNotYetPlacedListBox = new System.Windows.Forms.ListBox();
            this.placeOrderButton = new System.Windows.Forms.Button();
            this.ordersPlacedLabel = new System.Windows.Forms.Label();
            this.ordersPlacedListBox = new System.Windows.Forms.ListBox();
            this.backButton = new System.Windows.Forms.Button();
            this.mondaysOrdersButton = new System.Windows.Forms.Button();
            this.editDayButton = new System.Windows.Forms.Button();
            this.moveSelectedBackButton = new System.Windows.Forms.Button();
            this.moveButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MondayLabel
            // 
            this.MondayLabel.AutoSize = true;
            this.MondayLabel.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.MondayLabel.Location = new System.Drawing.Point(244, 9);
            this.MondayLabel.Name = "MondayLabel";
            this.MondayLabel.Size = new System.Drawing.Size(393, 48);
            this.MondayLabel.TabIndex = 0;
            this.MondayLabel.Text = "Mondays Cloth Orders";
            // 
            // ordersNotYetPlacedLabel
            // 
            this.ordersNotYetPlacedLabel.AutoSize = true;
            this.ordersNotYetPlacedLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ordersNotYetPlacedLabel.Location = new System.Drawing.Point(68, 70);
            this.ordersNotYetPlacedLabel.Name = "ordersNotYetPlacedLabel";
            this.ordersNotYetPlacedLabel.Size = new System.Drawing.Size(285, 38);
            this.ordersNotYetPlacedLabel.TabIndex = 1;
            this.ordersNotYetPlacedLabel.Text = "Orders not yet placed";
            // 
            // ordersNotYetPlacedListBox
            // 
            this.ordersNotYetPlacedListBox.FormattingEnabled = true;
            this.ordersNotYetPlacedListBox.ItemHeight = 25;
            this.ordersNotYetPlacedListBox.Location = new System.Drawing.Point(55, 111);
            this.ordersNotYetPlacedListBox.Name = "ordersNotYetPlacedListBox";
            this.ordersNotYetPlacedListBox.Size = new System.Drawing.Size(308, 279);
            this.ordersNotYetPlacedListBox.TabIndex = 3;
            // 
            // placeOrderButton
            // 
            this.placeOrderButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.placeOrderButton.Location = new System.Drawing.Point(206, 411);
            this.placeOrderButton.Name = "placeOrderButton";
            this.placeOrderButton.Size = new System.Drawing.Size(157, 42);
            this.placeOrderButton.TabIndex = 4;
            this.placeOrderButton.Text = "Place Order";
            this.placeOrderButton.UseVisualStyleBackColor = true;
            this.placeOrderButton.Click += new System.EventHandler(this.placeOrderButton_Click);
            // 
            // ordersPlacedLabel
            // 
            this.ordersPlacedLabel.AutoSize = true;
            this.ordersPlacedLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ordersPlacedLabel.Location = new System.Drawing.Point(519, 70);
            this.ordersPlacedLabel.Name = "ordersPlacedLabel";
            this.ordersPlacedLabel.Size = new System.Drawing.Size(190, 38);
            this.ordersPlacedLabel.TabIndex = 5;
            this.ordersPlacedLabel.Text = "Orders Placed";
            // 
            // ordersPlacedListBox
            // 
            this.ordersPlacedListBox.FormattingEnabled = true;
            this.ordersPlacedListBox.ItemHeight = 25;
            this.ordersPlacedListBox.Location = new System.Drawing.Point(470, 111);
            this.ordersPlacedListBox.Name = "ordersPlacedListBox";
            this.ordersPlacedListBox.Size = new System.Drawing.Size(308, 279);
            this.ordersPlacedListBox.TabIndex = 6;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(780, 515);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(113, 42);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // mondaysOrdersButton
            // 
            this.mondaysOrdersButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mondaysOrdersButton.Location = new System.Drawing.Point(636, 392);
            this.mondaysOrdersButton.Name = "mondaysOrdersButton";
            this.mondaysOrdersButton.Size = new System.Drawing.Size(142, 115);
            this.mondaysOrdersButton.TabIndex = 11;
            this.mondaysOrdersButton.Text = "View Mondays Orders";
            this.mondaysOrdersButton.UseVisualStyleBackColor = true;
            this.mondaysOrdersButton.Click += new System.EventHandler(this.mondaysOrdersButton_Click);
            // 
            // editDayButton
            // 
            this.editDayButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editDayButton.Location = new System.Drawing.Point(55, 411);
            this.editDayButton.Name = "editDayButton";
            this.editDayButton.Size = new System.Drawing.Size(124, 40);
            this.editDayButton.TabIndex = 12;
            this.editDayButton.Text = "Edit Day";
            this.editDayButton.UseVisualStyleBackColor = true;
            this.editDayButton.Click += new System.EventHandler(this.editDayButton_Click);
            // 
            // moveSelectedBackButton
            // 
            this.moveSelectedBackButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.moveSelectedBackButton.Location = new System.Drawing.Point(470, 392);
            this.moveSelectedBackButton.Name = "moveSelectedBackButton";
            this.moveSelectedBackButton.Size = new System.Drawing.Size(157, 115);
            this.moveSelectedBackButton.TabIndex = 13;
            this.moveSelectedBackButton.Text = "Move selected to not yet placed";
            this.moveSelectedBackButton.UseVisualStyleBackColor = true;
            this.moveSelectedBackButton.Click += new System.EventHandler(this.moveSelectedBackButton_Click);
            // 
            // moveButton
            // 
            this.moveButton.Location = new System.Drawing.Point(379, 226);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(72, 34);
            this.moveButton.TabIndex = 14;
            this.moveButton.Text = "Move";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.homeButton.Location = new System.Drawing.Point(55, 515);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(113, 42);
            this.homeButton.TabIndex = 39;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // Monday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 584);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.moveButton);
            this.Controls.Add(this.moveSelectedBackButton);
            this.Controls.Add(this.editDayButton);
            this.Controls.Add(this.mondaysOrdersButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.ordersPlacedListBox);
            this.Controls.Add(this.ordersPlacedLabel);
            this.Controls.Add(this.placeOrderButton);
            this.Controls.Add(this.ordersNotYetPlacedListBox);
            this.Controls.Add(this.ordersNotYetPlacedLabel);
            this.Controls.Add(this.MondayLabel);
            this.Name = "Monday";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monday";
            //this.Load += new System.EventHandler(this.Monday_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label MondayLabel;
        private Label ordersNotYetPlacedLabel;
        public ListBox ordersNotYetPlacedListBox;
        private Button placeOrderButton;
        private Label ordersPlacedLabel;
        private ListBox ordersPlacedListBox;
        private Button backButton;
        private Button mondaysOrdersButton;
        private Button editDayButton;
        private Button moveSelectedBackButton;
        private Button moveButton;
        private Button homeButton;
    }
}