namespace LaundryUI
{
    partial class ClothOrKitchenwear
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
            this.clothFormButton = new System.Windows.Forms.Button();
            this.kitchenwearFormButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clothFormButton
            // 
            this.clothFormButton.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clothFormButton.Location = new System.Drawing.Point(171, 168);
            this.clothFormButton.Name = "clothFormButton";
            this.clothFormButton.Size = new System.Drawing.Size(229, 142);
            this.clothFormButton.TabIndex = 2;
            this.clothFormButton.Text = "Cloth Form";
            this.clothFormButton.UseVisualStyleBackColor = true;
            this.clothFormButton.Click += new System.EventHandler(this.clothFormButton_Click);
            // 
            // kitchenwearFormButton
            // 
            this.kitchenwearFormButton.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kitchenwearFormButton.Location = new System.Drawing.Point(456, 168);
            this.kitchenwearFormButton.Name = "kitchenwearFormButton";
            this.kitchenwearFormButton.Size = new System.Drawing.Size(250, 142);
            this.kitchenwearFormButton.TabIndex = 3;
            this.kitchenwearFormButton.Text = "Kitchenwear Form";
            this.kitchenwearFormButton.UseVisualStyleBackColor = true;
            this.kitchenwearFormButton.Click += new System.EventHandler(this.kitchenwearFormButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(583, 442);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(123, 51);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.homeButton.Location = new System.Drawing.Point(171, 442);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(104, 51);
            this.homeButton.TabIndex = 39;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // ClothOrKitchenwear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 584);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.kitchenwearFormButton);
            this.Controls.Add(this.clothFormButton);
            this.Name = "ClothOrKitchenwear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClothOrKitchenwear";
            this.ResumeLayout(false);

        }

        #endregion

        private Button clothFormButton;
        private Button kitchenwearFormButton;
        private Button backButton;
        private Button homeButton;
    }
}