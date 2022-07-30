namespace LaundryUI
{
    partial class AddRestaurantToDay
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
            this.backButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.locationValue = new System.Windows.Forms.TextBox();
            this.bagColourValue = new System.Windows.Forms.TextBox();
            this.restaurantValue = new System.Windows.Forms.TextBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.bagColourLabel = new System.Windows.Forms.Label();
            this.restaurantLabel = new System.Windows.Forms.Label();
            this.dayOfWeekInput = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.driverLabel = new System.Windows.Forms.Label();
            this.notesLabel = new System.Windows.Forms.Label();
            this.addressValue = new System.Windows.Forms.TextBox();
            this.driverValue = new System.Windows.Forms.TextBox();
            this.notesValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(765, 515);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(125, 47);
            this.backButton.TabIndex = 29;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(205, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(445, 45);
            this.headerLabel.TabIndex = 28;
            this.headerLabel.Text = "Create a new Restaurant log";
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submitButton.Location = new System.Drawing.Point(761, 452);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(129, 51);
            this.submitButton.TabIndex = 27;
            this.submitButton.Text = "Create";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // locationValue
            // 
            this.locationValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.locationValue.Location = new System.Drawing.Point(372, 205);
            this.locationValue.Name = "locationValue";
            this.locationValue.Size = new System.Drawing.Size(337, 45);
            this.locationValue.TabIndex = 23;
            // 
            // bagColourValue
            // 
            this.bagColourValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bagColourValue.Location = new System.Drawing.Point(372, 138);
            this.bagColourValue.Name = "bagColourValue";
            this.bagColourValue.Size = new System.Drawing.Size(337, 45);
            this.bagColourValue.TabIndex = 22;
            // 
            // restaurantValue
            // 
            this.restaurantValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.restaurantValue.Location = new System.Drawing.Point(372, 68);
            this.restaurantValue.Name = "restaurantValue";
            this.restaurantValue.Size = new System.Drawing.Size(337, 45);
            this.restaurantValue.TabIndex = 21;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.locationLabel.Location = new System.Drawing.Point(153, 208);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(121, 38);
            this.locationLabel.TabIndex = 17;
            this.locationLabel.Text = "Location";
            // 
            // bagColourLabel
            // 
            this.bagColourLabel.AutoSize = true;
            this.bagColourLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bagColourLabel.Location = new System.Drawing.Point(153, 141);
            this.bagColourLabel.Name = "bagColourLabel";
            this.bagColourLabel.Size = new System.Drawing.Size(153, 38);
            this.bagColourLabel.TabIndex = 16;
            this.bagColourLabel.Text = "Bag Colour";
            // 
            // restaurantLabel
            // 
            this.restaurantLabel.AutoSize = true;
            this.restaurantLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.restaurantLabel.Location = new System.Drawing.Point(153, 71);
            this.restaurantLabel.Name = "restaurantLabel";
            this.restaurantLabel.Size = new System.Drawing.Size(148, 38);
            this.restaurantLabel.TabIndex = 15;
            this.restaurantLabel.Text = "Restaurant";
            // 
            // dayOfWeekInput
            // 
            this.dayOfWeekInput.AutoSize = true;
            this.dayOfWeekInput.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dayOfWeekInput.Location = new System.Drawing.Point(255, 412);
            this.dayOfWeekInput.Name = "dayOfWeekInput";
            this.dayOfWeekInput.Size = new System.Drawing.Size(0, 45);
            this.dayOfWeekInput.TabIndex = 30;
            this.dayOfWeekInput.Visible = false;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addressLabel.Location = new System.Drawing.Point(153, 279);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(116, 38);
            this.addressLabel.TabIndex = 31;
            this.addressLabel.Text = "Address";
            // 
            // driverLabel
            // 
            this.driverLabel.AutoSize = true;
            this.driverLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.driverLabel.Location = new System.Drawing.Point(153, 402);
            this.driverLabel.Name = "driverLabel";
            this.driverLabel.Size = new System.Drawing.Size(92, 38);
            this.driverLabel.TabIndex = 32;
            this.driverLabel.Text = "Driver";
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.notesLabel.Location = new System.Drawing.Point(153, 465);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(90, 38);
            this.notesLabel.TabIndex = 33;
            this.notesLabel.Text = "Notes";
            // 
            // addressValue
            // 
            this.addressValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addressValue.Location = new System.Drawing.Point(372, 276);
            this.addressValue.MinimumSize = new System.Drawing.Size(2, 100);
            this.addressValue.Name = "addressValue";
            this.addressValue.Size = new System.Drawing.Size(337, 100);
            this.addressValue.TabIndex = 34;
            // 
            // driverValue
            // 
            this.driverValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.driverValue.Location = new System.Drawing.Point(372, 399);
            this.driverValue.Name = "driverValue";
            this.driverValue.Size = new System.Drawing.Size(337, 45);
            this.driverValue.TabIndex = 35;
            // 
            // notesValue
            // 
            this.notesValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.notesValue.Location = new System.Drawing.Point(372, 462);
            this.notesValue.MinimumSize = new System.Drawing.Size(2, 100);
            this.notesValue.Name = "notesValue";
            this.notesValue.Size = new System.Drawing.Size(337, 100);
            this.notesValue.TabIndex = 36;
            // 
            // AddRestaurantToDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 584);
            this.Controls.Add(this.notesValue);
            this.Controls.Add(this.driverValue);
            this.Controls.Add(this.addressValue);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.driverLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.dayOfWeekInput);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.locationValue);
            this.Controls.Add(this.bagColourValue);
            this.Controls.Add(this.restaurantValue);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.bagColourLabel);
            this.Controls.Add(this.restaurantLabel);
            this.Name = "AddRestaurantToDay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DayForm";
            this.Load += new System.EventHandler(this.AddRestaurantToDay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button backButton;
        private Label headerLabel;
        private Button submitButton;
        private TextBox locationValue;
        private TextBox bagColourValue;
        private TextBox restaurantValue;
        private Label locationLabel;
        private Label bagColourLabel;
        private Label restaurantLabel;
        private Label dayOfWeekInput;
        private Label addressLabel;
        private Label driverLabel;
        private Label notesLabel;
        private TextBox addressValue;
        private TextBox driverValue;
        private TextBox notesValue;
    }
}