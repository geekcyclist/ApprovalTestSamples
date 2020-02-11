namespace Collatz.WinForms
{
    partial class SeriesCalculator
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
            this.InitalValueTextBox = new System.Windows.Forms.TextBox();
            this.InitialValueLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SeriesGridView = new System.Windows.Forms.DataGridView();
            this.ErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SeriesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // InitalValueTextBox
            // 
            this.InitalValueTextBox.Location = new System.Drawing.Point(105, 3);
            this.InitalValueTextBox.Name = "InitalValueTextBox";
            this.InitalValueTextBox.Size = new System.Drawing.Size(100, 26);
            this.InitalValueTextBox.TabIndex = 0;
            // 
            // InitialValueLabel
            // 
            this.InitialValueLabel.AutoSize = true;
            this.InitialValueLabel.Location = new System.Drawing.Point(12, 9);
            this.InitialValueLabel.Name = "InitialValueLabel";
            this.InitialValueLabel.Size = new System.Drawing.Size(87, 20);
            this.InitialValueLabel.TabIndex = 1;
            this.InitialValueLabel.Text = "InitialValue";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(211, 1);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(90, 32);
            this.CalculateButton.TabIndex = 2;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(308, 1);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(82, 32);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SeriesGridView
            // 
            this.SeriesGridView.AllowUserToAddRows = false;
            this.SeriesGridView.AllowUserToDeleteRows = false;
            this.SeriesGridView.AllowUserToOrderColumns = true;
            this.SeriesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SeriesGridView.Location = new System.Drawing.Point(16, 39);
            this.SeriesGridView.Name = "SeriesGridView";
            this.SeriesGridView.ReadOnly = true;
            this.SeriesGridView.RowTemplate.Height = 28;
            this.SeriesGridView.Size = new System.Drawing.Size(476, 635);
            this.SeriesGridView.TabIndex = 5;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ErrorLabel.Location = new System.Drawing.Point(8, 42);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(85, 22);
            this.ErrorLabel.TabIndex = 6;
            this.ErrorLabel.Text = "ErrorLabel";
            this.ErrorLabel.Visible = false;
            // 
            // SeriesCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 686);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.SeriesGridView);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.InitialValueLabel);
            this.Controls.Add(this.InitalValueTextBox);
            this.MinimumSize = new System.Drawing.Size(520, 725);
            this.Name = "SeriesCalculator";
            this.Text = "Collatz Series Calculator";
            this.Load += new System.EventHandler(this.SeriesCalculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SeriesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InitalValueTextBox;
        private System.Windows.Forms.Label InitialValueLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.DataGridView SeriesGridView;
        private System.Windows.Forms.Label ErrorLabel;
    }
}

