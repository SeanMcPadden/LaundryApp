namespace LaundryUI.Orders.Monday
{
    partial class MondaysKitchenwearReturns
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
            this.MondayLabel = new System.Windows.Forms.Label();
            this.returnsNotYetProcessedLabel = new System.Windows.Forms.Label();
            this.processedReturnsLabel = new System.Windows.Forms.Label();
            this.returnsNotYetProcessedListBox = new System.Windows.Forms.ListBox();
            this.processedReturnsListBox = new System.Windows.Forms.ListBox();
            this.moveButton = new System.Windows.Forms.Button();
            this.editDayButton = new System.Windows.Forms.Button();
            this.placeOrderButton = new System.Windows.Forms.Button();
            this.moveSelectedBackButton = new System.Windows.Forms.Button();
            this.viewMondaysReturnsButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MondayLabel
            // 
            this.MondayLabel.AutoSize = true;
            this.MondayLabel.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.MondayLabel.Location = new System.Drawing.Point(160, 26);
            this.MondayLabel.Name = "MondayLabel";
            this.MondayLabel.Size = new System.Drawing.Size(532, 48);
            this.MondayLabel.TabIndex = 2;
            this.MondayLabel.Text = "Mondays Kitchenwear Returns";
            // 
            // returnsNotYetProcessedLabel
            // 
            this.returnsNotYetProcessedLabel.AutoSize = true;
            this.returnsNotYetProcessedLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.returnsNotYetProcessedLabel.Location = new System.Drawing.Point(38, 108);
            this.returnsNotYetProcessedLabel.Name = "returnsNotYetProcessedLabel";
            this.returnsNotYetProcessedLabel.Size = new System.Drawing.Size(339, 38);
            this.returnsNotYetProcessedLabel.TabIndex = 3;
            this.returnsNotYetProcessedLabel.Text = "Returns not yet processed";
            // 
            // processedReturnsLabel
            // 
            this.processedReturnsLabel.AutoSize = true;
            this.processedReturnsLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.processedReturnsLabel.Location = new System.Drawing.Point(513, 108);
            this.processedReturnsLabel.Name = "processedReturnsLabel";
            this.processedReturnsLabel.Size = new System.Drawing.Size(244, 38);
            this.processedReturnsLabel.TabIndex = 7;
            this.processedReturnsLabel.Text = "Processed Returns";
            // 
            // returnsNotYetProcessedListBox
            // 
            this.returnsNotYetProcessedListBox.FormattingEnabled = true;
            this.returnsNotYetProcessedListBox.ItemHeight = 25;
            this.returnsNotYetProcessedListBox.Location = new System.Drawing.Point(55, 164);
            this.returnsNotYetProcessedListBox.Name = "returnsNotYetProcessedListBox";
            this.returnsNotYetProcessedListBox.Size = new System.Drawing.Size(308, 279);
            this.returnsNotYetProcessedListBox.TabIndex = 8;
            // 
            // processedReturnsListBox
            // 
            this.processedReturnsListBox.FormattingEnabled = true;
            this.processedReturnsListBox.ItemHeight = 25;
            this.processedReturnsListBox.Location = new System.Drawing.Point(476, 164);
            this.processedReturnsListBox.Name = "processedReturnsListBox";
            this.processedReturnsListBox.Size = new System.Drawing.Size(308, 279);
            this.processedReturnsListBox.TabIndex = 9;
            // 
            // moveButton
            // 
            this.moveButton.Location = new System.Drawing.Point(382, 267);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(68, 34);
            this.moveButton.TabIndex = 16;
            this.moveButton.Text = "Move";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // editDayButton
            // 
            this.editDayButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editDayButton.Location = new System.Drawing.Point(55, 474);
            this.editDayButton.Name = "editDayButton";
            this.editDayButton.Size = new System.Drawing.Size(124, 40);
            this.editDayButton.TabIndex = 17;
            this.editDayButton.Text = "Edit Day";
            this.editDayButton.UseVisualStyleBackColor = true;
            this.editDayButton.Click += new System.EventHandler(this.editDayButton_Click);
            // 
            // placeOrderButton
            // 
            this.placeOrderButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.placeOrderButton.Location = new System.Drawing.Point(206, 474);
            this.placeOrderButton.Name = "placeOrderButton";
            this.placeOrderButton.Size = new System.Drawing.Size(157, 42);
            this.placeOrderButton.TabIndex = 18;
            this.placeOrderButton.Text = "Place Order";
            this.placeOrderButton.UseVisualStyleBackColor = true;
            this.placeOrderButton.Click += new System.EventHandler(this.placeOrderButton_Click);
            // 
            // moveSelectedBackButton
            // 
            this.moveSelectedBackButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.moveSelectedBackButton.Location = new System.Drawing.Point(476, 449);
            this.moveSelectedBackButton.Name = "moveSelectedBackButton";
            this.moveSelectedBackButton.Size = new System.Drawing.Size(157, 115);
            this.moveSelectedBackButton.TabIndex = 19;
            this.moveSelectedBackButton.Text = "Move selected to Returns not yet processed";
            this.moveSelectedBackButton.UseVisualStyleBackColor = true;
            this.moveSelectedBackButton.Click += new System.EventHandler(this.moveSelectedBackButton_Click);
            // 
            // viewMondaysReturnsButton
            // 
            this.viewMondaysReturnsButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.viewMondaysReturnsButton.Location = new System.Drawing.Point(642, 449);
            this.viewMondaysReturnsButton.Name = "viewMondaysReturnsButton";
            this.viewMondaysReturnsButton.Size = new System.Drawing.Size(142, 115);
            this.viewMondaysReturnsButton.TabIndex = 20;
            this.viewMondaysReturnsButton.Text = "View Mondays Returns";
            this.viewMondaysReturnsButton.UseVisualStyleBackColor = true;
            this.viewMondaysReturnsButton.Click += new System.EventHandler(this.viewMondaysReturnsButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(803, 522);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(113, 42);
            this.backButton.TabIndex = 21;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // MondaysKitchenwearReturns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 584);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.viewMondaysReturnsButton);
            this.Controls.Add(this.moveSelectedBackButton);
            this.Controls.Add(this.placeOrderButton);
            this.Controls.Add(this.editDayButton);
            this.Controls.Add(this.moveButton);
            this.Controls.Add(this.processedReturnsListBox);
            this.Controls.Add(this.returnsNotYetProcessedListBox);
            this.Controls.Add(this.processedReturnsLabel);
            this.Controls.Add(this.returnsNotYetProcessedLabel);
            this.Controls.Add(this.MondayLabel);
            this.Name = "MondaysKitchenwearReturns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MondaysKitchenwearReturns";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label MondayLabel;
        private Label returnsNotYetProcessedLabel;
        private Label processedReturnsLabel;
        public ListBox returnsNotYetProcessedListBox;
        private ListBox processedReturnsListBox;
        private Button moveButton;
        private Button editDayButton;
        private Button placeOrderButton;
        private Button moveSelectedBackButton;
        private Button viewMondaysReturnsButton;
        private Button backButton;
    }
}