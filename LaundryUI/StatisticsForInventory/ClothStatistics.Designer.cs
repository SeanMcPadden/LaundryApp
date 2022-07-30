namespace LaundryUI.Inventory
{
    partial class ClothStatistics
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
            this.components = new System.ComponentModel.Container();
            this.clothStatisticsLabel = new System.Windows.Forms.Label();
            this.clothStatisticsDataGridView = new System.Windows.Forms.DataGridView();
            this.napkinBrownDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brown54DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brown70DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barClothDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clothModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.previousWeekDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button8 = new System.Windows.Forms.Button();
            this.sendEmailButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clothStatisticsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousWeekDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // clothStatisticsLabel
            // 
            this.clothStatisticsLabel.AutoSize = true;
            this.clothStatisticsLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clothStatisticsLabel.Location = new System.Drawing.Point(278, 18);
            this.clothStatisticsLabel.Name = "clothStatisticsLabel";
            this.clothStatisticsLabel.Size = new System.Drawing.Size(302, 54);
            this.clothStatisticsLabel.TabIndex = 20;
            this.clothStatisticsLabel.Text = "Cloth Statistics";
            // 
            // clothStatisticsDataGridView
            // 
            this.clothStatisticsDataGridView.AutoGenerateColumns = false;
            this.clothStatisticsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clothStatisticsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.napkinBrownDataGridViewTextBoxColumn,
            this.whiteDataGridViewTextBoxColumn,
            this.brown54DataGridViewTextBoxColumn,
            this.brown70DataGridViewTextBoxColumn,
            this.barClothDataGridViewTextBoxColumn});
            this.clothStatisticsDataGridView.DataSource = this.clothModelBindingSource;
            this.clothStatisticsDataGridView.Location = new System.Drawing.Point(52, 138);
            this.clothStatisticsDataGridView.Name = "clothStatisticsDataGridView";
            this.clothStatisticsDataGridView.RowHeadersWidth = 62;
            this.clothStatisticsDataGridView.RowTemplate.Height = 33;
            this.clothStatisticsDataGridView.Size = new System.Drawing.Size(815, 69);
            this.clothStatisticsDataGridView.TabIndex = 23;
            // 
            // napkinBrownDataGridViewTextBoxColumn
            // 
            this.napkinBrownDataGridViewTextBoxColumn.DataPropertyName = "NapkinBrown";
            this.napkinBrownDataGridViewTextBoxColumn.HeaderText = "NapkinBrown";
            this.napkinBrownDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.napkinBrownDataGridViewTextBoxColumn.Name = "napkinBrownDataGridViewTextBoxColumn";
            this.napkinBrownDataGridViewTextBoxColumn.Width = 150;
            // 
            // whiteDataGridViewTextBoxColumn
            // 
            this.whiteDataGridViewTextBoxColumn.DataPropertyName = "White";
            this.whiteDataGridViewTextBoxColumn.HeaderText = "White";
            this.whiteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.whiteDataGridViewTextBoxColumn.Name = "whiteDataGridViewTextBoxColumn";
            this.whiteDataGridViewTextBoxColumn.Width = 150;
            // 
            // brown54DataGridViewTextBoxColumn
            // 
            this.brown54DataGridViewTextBoxColumn.DataPropertyName = "Brown54";
            this.brown54DataGridViewTextBoxColumn.HeaderText = "Brown54";
            this.brown54DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.brown54DataGridViewTextBoxColumn.Name = "brown54DataGridViewTextBoxColumn";
            this.brown54DataGridViewTextBoxColumn.Width = 150;
            // 
            // brown70DataGridViewTextBoxColumn
            // 
            this.brown70DataGridViewTextBoxColumn.DataPropertyName = "Brown70";
            this.brown70DataGridViewTextBoxColumn.HeaderText = "Brown70";
            this.brown70DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.brown70DataGridViewTextBoxColumn.Name = "brown70DataGridViewTextBoxColumn";
            this.brown70DataGridViewTextBoxColumn.Width = 150;
            // 
            // barClothDataGridViewTextBoxColumn
            // 
            this.barClothDataGridViewTextBoxColumn.DataPropertyName = "BarCloth";
            this.barClothDataGridViewTextBoxColumn.HeaderText = "BarCloth";
            this.barClothDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.barClothDataGridViewTextBoxColumn.Name = "barClothDataGridViewTextBoxColumn";
            this.barClothDataGridViewTextBoxColumn.Width = 150;
            // 
            // clothModelBindingSource
            // 
            this.clothModelBindingSource.DataSource = typeof(LaundryLibrary.Models.ClothModel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(52, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 32);
            this.label1.TabIndex = 24;
            this.label1.Text = "Cloth Processed For Current Week So Far";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(52, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(419, 32);
            this.label2.TabIndex = 25;
            this.label2.Text = "Cloth Processed The Previous Week";
            // 
            // previousWeekDataGridView
            // 
            this.previousWeekDataGridView.AutoGenerateColumns = false;
            this.previousWeekDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.previousWeekDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.previousWeekDataGridView.DataSource = this.clothModelBindingSource;
            this.previousWeekDataGridView.Location = new System.Drawing.Point(52, 271);
            this.previousWeekDataGridView.Name = "previousWeekDataGridView";
            this.previousWeekDataGridView.RowHeadersWidth = 62;
            this.previousWeekDataGridView.RowTemplate.Height = 33;
            this.previousWeekDataGridView.Size = new System.Drawing.Size(815, 69);
            this.previousWeekDataGridView.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NapkinBrown";
            this.dataGridViewTextBoxColumn1.HeaderText = "NapkinBrown";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "White";
            this.dataGridViewTextBoxColumn2.HeaderText = "White";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Brown54";
            this.dataGridViewTextBoxColumn3.HeaderText = "Brown54";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Brown70";
            this.dataGridViewTextBoxColumn4.HeaderText = "Brown70";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "BarCloth";
            this.dataGridViewTextBoxColumn5.HeaderText = "BarCloth";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(777, 515);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(125, 47);
            this.button8.TabIndex = 27;
            this.button8.Text = "Back";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // sendEmailButton
            // 
            this.sendEmailButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sendEmailButton.Location = new System.Drawing.Point(406, 505);
            this.sendEmailButton.Name = "sendEmailButton";
            this.sendEmailButton.Size = new System.Drawing.Size(150, 47);
            this.sendEmailButton.TabIndex = 28;
            this.sendEmailButton.Text = "Send Email";
            this.sendEmailButton.UseVisualStyleBackColor = true;
            this.sendEmailButton.Click += new System.EventHandler(this.sendEmailButton_Click);
            // 
            // ClothStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 584);
            this.Controls.Add(this.sendEmailButton);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.previousWeekDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clothStatisticsDataGridView);
            this.Controls.Add(this.clothStatisticsLabel);
            this.Name = "ClothStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClothStatistics";
            this.Load += new System.EventHandler(this.ClothStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clothStatisticsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousWeekDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label clothStatisticsLabel;
        private DataGridView clothStatisticsDataGridView;
        private BindingSource clothModelBindingSource;
        private DataGridViewTextBoxColumn napkinBrownDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn whiteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brown54DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brown70DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn barClothDataGridViewTextBoxColumn;
        private Label label1;
        private Label label2;
        private DataGridView previousWeekDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Button button8;
        private Button sendEmailButton;
    }
}