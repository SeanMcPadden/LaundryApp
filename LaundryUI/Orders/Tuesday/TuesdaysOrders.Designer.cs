namespace LaundryUI.Orders
{
    partial class TuesdaysOrders
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
            this.viewTuesdaysOrdersButton = new System.Windows.Forms.Button();
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
            this.moveButton.Location = new System.Drawing.Point(357, 236);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(72, 34);
            this.moveButton.TabIndex = 25;
            this.moveButton.Text = "Move";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // moveSelectedBackButton
            // 
            this.moveSelectedBackButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.moveSelectedBackButton.Location = new System.Drawing.Point(435, 404);
            this.moveSelectedBackButton.Name = "moveSelectedBackButton";
            this.moveSelectedBackButton.Size = new System.Drawing.Size(157, 115);
            this.moveSelectedBackButton.TabIndex = 24;
            this.moveSelectedBackButton.Text = "Move selected to not yet placed";
            this.moveSelectedBackButton.UseVisualStyleBackColor = true;
            this.moveSelectedBackButton.Click += new System.EventHandler(this.moveSelectedBackButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editButton.Location = new System.Drawing.Point(43, 423);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(124, 40);
            this.editButton.TabIndex = 23;
            this.editButton.Text = "Edit Day";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // viewTuesdaysOrdersButton
            // 
            this.viewTuesdaysOrdersButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.viewTuesdaysOrdersButton.Location = new System.Drawing.Point(601, 404);
            this.viewTuesdaysOrdersButton.Name = "viewTuesdaysOrdersButton";
            this.viewTuesdaysOrdersButton.Size = new System.Drawing.Size(142, 115);
            this.viewTuesdaysOrdersButton.TabIndex = 22;
            this.viewTuesdaysOrdersButton.Text = "View Tuesdays Orders";
            this.viewTuesdaysOrdersButton.UseVisualStyleBackColor = true;
            this.viewTuesdaysOrdersButton.Click += new System.EventHandler(this.viewTuesdaysOrdersButton_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBack.Location = new System.Drawing.Point(756, 510);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(113, 42);
            this.buttonBack.TabIndex = 21;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // ordersPlacedListBox
            // 
            this.ordersPlacedListBox.FormattingEnabled = true;
            this.ordersPlacedListBox.ItemHeight = 25;
            this.ordersPlacedListBox.Location = new System.Drawing.Point(435, 123);
            this.ordersPlacedListBox.Name = "ordersPlacedListBox";
            this.ordersPlacedListBox.Size = new System.Drawing.Size(308, 279);
            this.ordersPlacedListBox.TabIndex = 20;
            // 
            // ordersPlacedLabel
            // 
            this.ordersPlacedLabel.AutoSize = true;
            this.ordersPlacedLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ordersPlacedLabel.Location = new System.Drawing.Point(435, 82);
            this.ordersPlacedLabel.Name = "ordersPlacedLabel";
            this.ordersPlacedLabel.Size = new System.Drawing.Size(190, 38);
            this.ordersPlacedLabel.TabIndex = 19;
            this.ordersPlacedLabel.Text = "Orders Placed";
            // 
            // placeOrderButton
            // 
            this.placeOrderButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.placeOrderButton.Location = new System.Drawing.Point(194, 423);
            this.placeOrderButton.Name = "placeOrderButton";
            this.placeOrderButton.Size = new System.Drawing.Size(157, 42);
            this.placeOrderButton.TabIndex = 18;
            this.placeOrderButton.Text = "Place Order";
            this.placeOrderButton.UseVisualStyleBackColor = true;
            this.placeOrderButton.Click += new System.EventHandler(this.placeOrderButton_Click);
            // 
            // ordersNotYetPlacedListBox
            // 
            this.ordersNotYetPlacedListBox.FormattingEnabled = true;
            this.ordersNotYetPlacedListBox.ItemHeight = 25;
            this.ordersNotYetPlacedListBox.Location = new System.Drawing.Point(43, 123);
            this.ordersNotYetPlacedListBox.Name = "ordersNotYetPlacedListBox";
            this.ordersNotYetPlacedListBox.Size = new System.Drawing.Size(308, 279);
            this.ordersNotYetPlacedListBox.TabIndex = 17;
            // 
            // ordersNotYetPlacedLabel
            // 
            this.ordersNotYetPlacedLabel.AutoSize = true;
            this.ordersNotYetPlacedLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ordersNotYetPlacedLabel.Location = new System.Drawing.Point(56, 82);
            this.ordersNotYetPlacedLabel.Name = "ordersNotYetPlacedLabel";
            this.ordersNotYetPlacedLabel.Size = new System.Drawing.Size(285, 38);
            this.ordersNotYetPlacedLabel.TabIndex = 16;
            this.ordersNotYetPlacedLabel.Text = "Orders not yet placed";
            // 
            // SundayLabel
            // 
            this.SundayLabel.AutoSize = true;
            this.SundayLabel.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.SundayLabel.Location = new System.Drawing.Point(214, 20);
            this.SundayLabel.Name = "SundayLabel";
            this.SundayLabel.Size = new System.Drawing.Size(397, 48);
            this.SundayLabel.TabIndex = 15;
            this.SundayLabel.Text = "Tuesdays Cloth Orders";
            // 
            // homeButton
            // 
            this.homeButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.homeButton.Location = new System.Drawing.Point(43, 510);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(113, 42);
            this.homeButton.TabIndex = 38;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // TuesdaysOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 584);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.moveButton);
            this.Controls.Add(this.moveSelectedBackButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.viewTuesdaysOrdersButton);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.ordersPlacedListBox);
            this.Controls.Add(this.ordersPlacedLabel);
            this.Controls.Add(this.placeOrderButton);
            this.Controls.Add(this.ordersNotYetPlacedListBox);
            this.Controls.Add(this.ordersNotYetPlacedLabel);
            this.Controls.Add(this.SundayLabel);
            this.Name = "TuesdaysOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TuesdaysOrders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button moveButton;
        private Button moveSelectedBackButton;
        private Button editButton;
        private Button viewTuesdaysOrdersButton;
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