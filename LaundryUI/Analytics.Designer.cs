namespace LaundryUI
{
    partial class Analytics
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
            this.button1 = new System.Windows.Forms.Button();
            this.restaurantsKitchenwearOrdersButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.restaurantListbox = new System.Windows.Forms.ListBox();
            this.restaurantReturnsButton = new System.Windows.Forms.Button();
            this.restaurantsOrdersButton = new System.Windows.Forms.Button();
            this.restaurantDetailsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(607, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(302, 85);
            this.button1.TabIndex = 18;
            this.button1.Text = "Kitchenwear Returns";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // restaurantsKitchenwearOrdersButton
            // 
            this.restaurantsKitchenwearOrdersButton.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.restaurantsKitchenwearOrdersButton.Location = new System.Drawing.Point(607, 150);
            this.restaurantsKitchenwearOrdersButton.Name = "restaurantsKitchenwearOrdersButton";
            this.restaurantsKitchenwearOrdersButton.Size = new System.Drawing.Size(302, 72);
            this.restaurantsKitchenwearOrdersButton.TabIndex = 17;
            this.restaurantsKitchenwearOrdersButton.Text = "Kitchenwear Orders";
            this.restaurantsKitchenwearOrdersButton.UseVisualStyleBackColor = true;
            this.restaurantsKitchenwearOrdersButton.Click += new System.EventHandler(this.restaurantsKitchenwearOrdersButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(331, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 54);
            this.label1.TabIndex = 16;
            this.label1.Text = "Analysis";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(798, 525);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(111, 47);
            this.backButton.TabIndex = 15;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // restaurantListbox
            // 
            this.restaurantListbox.FormattingEnabled = true;
            this.restaurantListbox.ItemHeight = 25;
            this.restaurantListbox.Location = new System.Drawing.Point(28, 68);
            this.restaurantListbox.Name = "restaurantListbox";
            this.restaurantListbox.Size = new System.Drawing.Size(556, 429);
            this.restaurantListbox.TabIndex = 14;
            // 
            // restaurantReturnsButton
            // 
            this.restaurantReturnsButton.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.restaurantReturnsButton.Location = new System.Drawing.Point(607, 239);
            this.restaurantReturnsButton.Name = "restaurantReturnsButton";
            this.restaurantReturnsButton.Size = new System.Drawing.Size(302, 65);
            this.restaurantReturnsButton.TabIndex = 13;
            this.restaurantReturnsButton.Text = "Cloth Returns";
            this.restaurantReturnsButton.UseVisualStyleBackColor = true;
            this.restaurantReturnsButton.Click += new System.EventHandler(this.restaurantReturnsButton_Click);
            // 
            // restaurantsOrdersButton
            // 
            this.restaurantsOrdersButton.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.restaurantsOrdersButton.Location = new System.Drawing.Point(607, 68);
            this.restaurantsOrdersButton.Name = "restaurantsOrdersButton";
            this.restaurantsOrdersButton.Size = new System.Drawing.Size(302, 66);
            this.restaurantsOrdersButton.TabIndex = 12;
            this.restaurantsOrdersButton.Text = "Cloth Orders";
            this.restaurantsOrdersButton.UseVisualStyleBackColor = true;
            this.restaurantsOrdersButton.Click += new System.EventHandler(this.restaurantsOrdersButton_Click);
            // 
            // restaurantDetailsButton
            // 
            this.restaurantDetailsButton.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.restaurantDetailsButton.Location = new System.Drawing.Point(607, 429);
            this.restaurantDetailsButton.Name = "restaurantDetailsButton";
            this.restaurantDetailsButton.Size = new System.Drawing.Size(302, 68);
            this.restaurantDetailsButton.TabIndex = 11;
            this.restaurantDetailsButton.Text = "Restaurant Details";
            this.restaurantDetailsButton.UseVisualStyleBackColor = true;
            this.restaurantDetailsButton.Click += new System.EventHandler(this.restaurantDetailsButton_Click);
            // 
            // Analytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 584);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.restaurantsKitchenwearOrdersButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.restaurantListbox);
            this.Controls.Add(this.restaurantReturnsButton);
            this.Controls.Add(this.restaurantsOrdersButton);
            this.Controls.Add(this.restaurantDetailsButton);
            this.Name = "Analytics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analytics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button restaurantsKitchenwearOrdersButton;
        private Label label1;
        private Button backButton;
        private ListBox restaurantListbox;
        private Button restaurantReturnsButton;
        private Button restaurantsOrdersButton;
        private Button restaurantDetailsButton;
    }
}