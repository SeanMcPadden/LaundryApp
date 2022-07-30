namespace LaundryUI
{
    partial class MondayKitchenwear
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
            this.mondayLabel = new System.Windows.Forms.Label();
            this.ordersNotYetPlacedLabel = new System.Windows.Forms.Label();
            this.ordersNotYetPlacedListBox = new System.Windows.Forms.ListBox();
            this.ordersPlacedLabel = new System.Windows.Forms.Label();
            this.ordersPlacedListBox = new System.Windows.Forms.ListBox();
            this.moveButton = new System.Windows.Forms.Button();
            this.editDayButton = new System.Windows.Forms.Button();
            this.placeOrderButton = new System.Windows.Forms.Button();
            this.moveSelectedBackButton = new System.Windows.Forms.Button();
            this.viewMondaysOrderButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mondayLabel
            // 
            this.mondayLabel.AutoSize = true;
            this.mondayLabel.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.mondayLabel.Location = new System.Drawing.Point(234, 33);
            this.mondayLabel.Name = "mondayLabel";
            this.mondayLabel.Size = new System.Drawing.Size(392, 48);
            this.mondayLabel.TabIndex = 1;
            this.mondayLabel.Text = "Mondays Kitchenwear";
            // 
            // ordersNotYetPlacedLabel
            // 
            this.ordersNotYetPlacedLabel.AutoSize = true;
            this.ordersNotYetPlacedLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ordersNotYetPlacedLabel.Location = new System.Drawing.Point(40, 102);
            this.ordersNotYetPlacedLabel.Name = "ordersNotYetPlacedLabel";
            this.ordersNotYetPlacedLabel.Size = new System.Drawing.Size(285, 38);
            this.ordersNotYetPlacedLabel.TabIndex = 2;
            this.ordersNotYetPlacedLabel.Text = "Orders not yet placed";
            // 
            // ordersNotYetPlacedListBox
            // 
            this.ordersNotYetPlacedListBox.FormattingEnabled = true;
            this.ordersNotYetPlacedListBox.ItemHeight = 25;
            this.ordersNotYetPlacedListBox.Location = new System.Drawing.Point(40, 153);
            this.ordersNotYetPlacedListBox.Name = "ordersNotYetPlacedListBox";
            this.ordersNotYetPlacedListBox.Size = new System.Drawing.Size(308, 279);
            this.ordersNotYetPlacedListBox.TabIndex = 4;
            // 
            // ordersPlacedLabel
            // 
            this.ordersPlacedLabel.AutoSize = true;
            this.ordersPlacedLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ordersPlacedLabel.Location = new System.Drawing.Point(512, 102);
            this.ordersPlacedLabel.Name = "ordersPlacedLabel";
            this.ordersPlacedLabel.Size = new System.Drawing.Size(190, 38);
            this.ordersPlacedLabel.TabIndex = 6;
            this.ordersPlacedLabel.Text = "Orders Placed";
            // 
            // ordersPlacedListBox
            // 
            this.ordersPlacedListBox.FormattingEnabled = true;
            this.ordersPlacedListBox.ItemHeight = 25;
            this.ordersPlacedListBox.Location = new System.Drawing.Point(467, 153);
            this.ordersPlacedListBox.Name = "ordersPlacedListBox";
            this.ordersPlacedListBox.Size = new System.Drawing.Size(308, 279);
            this.ordersPlacedListBox.TabIndex = 7;
            // 
            // moveButton
            // 
            this.moveButton.Location = new System.Drawing.Point(373, 254);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(58, 34);
            this.moveButton.TabIndex = 15;
            this.moveButton.Text = "Move";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // editDayButton
            // 
            this.editDayButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editDayButton.Location = new System.Drawing.Point(40, 455);
            this.editDayButton.Name = "editDayButton";
            this.editDayButton.Size = new System.Drawing.Size(124, 40);
            this.editDayButton.TabIndex = 16;
            this.editDayButton.Text = "Edit Day";
            this.editDayButton.UseVisualStyleBackColor = true;
            this.editDayButton.Click += new System.EventHandler(this.editDayButton_Click);
            // 
            // placeOrderButton
            // 
            this.placeOrderButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.placeOrderButton.Location = new System.Drawing.Point(187, 453);
            this.placeOrderButton.Name = "placeOrderButton";
            this.placeOrderButton.Size = new System.Drawing.Size(157, 42);
            this.placeOrderButton.TabIndex = 17;
            this.placeOrderButton.Text = "Place Order";
            this.placeOrderButton.UseVisualStyleBackColor = true;
            this.placeOrderButton.Click += new System.EventHandler(this.placeOrderButton_Click);
            // 
            // moveSelectedBackButton
            // 
            this.moveSelectedBackButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.moveSelectedBackButton.Location = new System.Drawing.Point(467, 438);
            this.moveSelectedBackButton.Name = "moveSelectedBackButton";
            this.moveSelectedBackButton.Size = new System.Drawing.Size(157, 115);
            this.moveSelectedBackButton.TabIndex = 18;
            this.moveSelectedBackButton.Text = "Move selected to not yet placed";
            this.moveSelectedBackButton.UseVisualStyleBackColor = true;
            this.moveSelectedBackButton.Click += new System.EventHandler(this.moveSelectedBackButton_Click);
            // 
            // viewMondaysOrderButton
            // 
            this.viewMondaysOrderButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.viewMondaysOrderButton.Location = new System.Drawing.Point(633, 438);
            this.viewMondaysOrderButton.Name = "viewMondaysOrderButton";
            this.viewMondaysOrderButton.Size = new System.Drawing.Size(142, 115);
            this.viewMondaysOrderButton.TabIndex = 19;
            this.viewMondaysOrderButton.Text = "View Mondays Orders";
            this.viewMondaysOrderButton.UseVisualStyleBackColor = true;
            this.viewMondaysOrderButton.Click += new System.EventHandler(this.viewMondaysOrderButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(798, 511);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(113, 42);
            this.backButton.TabIndex = 20;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.homeButton.Location = new System.Drawing.Point(40, 511);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(113, 42);
            this.homeButton.TabIndex = 40;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // MondayKitchenwear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 584);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.viewMondaysOrderButton);
            this.Controls.Add(this.moveSelectedBackButton);
            this.Controls.Add(this.placeOrderButton);
            this.Controls.Add(this.editDayButton);
            this.Controls.Add(this.moveButton);
            this.Controls.Add(this.ordersPlacedListBox);
            this.Controls.Add(this.ordersPlacedLabel);
            this.Controls.Add(this.ordersNotYetPlacedListBox);
            this.Controls.Add(this.ordersNotYetPlacedLabel);
            this.Controls.Add(this.mondayLabel);
            this.Name = "MondayKitchenwear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MondayKitchenwear";
            this.Load += new System.EventHandler(this.MondayKitchenwear_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label mondayLabel;
        private Label ordersNotYetPlacedLabel;
        public ListBox ordersNotYetPlacedListBox;
        private Label ordersPlacedLabel;
        private ListBox ordersPlacedListBox;
        private Button moveButton;
        private Button editDayButton;
        private Button placeOrderButton;
        private Button moveSelectedBackButton;
        private Button viewMondaysOrderButton;
        private Button backButton;
        private Button homeButton;
    }
}