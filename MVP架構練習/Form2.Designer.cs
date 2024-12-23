namespace MVP架構練習
{
    partial class Form2
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
            this.empComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.overTimeGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.overTimeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // empComboBox
            // 
            this.empComboBox.FormattingEnabled = true;
            this.empComboBox.Location = new System.Drawing.Point(162, 43);
            this.empComboBox.Name = "empComboBox";
            this.empComboBox.Size = new System.Drawing.Size(121, 23);
            this.empComboBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "查詢";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // overTimeGridView
            // 
            this.overTimeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.overTimeGridView.Location = new System.Drawing.Point(162, 84);
            this.overTimeGridView.Name = "overTimeGridView";
            this.overTimeGridView.RowHeadersWidth = 51;
            this.overTimeGridView.RowTemplate.Height = 27;
            this.overTimeGridView.Size = new System.Drawing.Size(314, 150);
            this.overTimeGridView.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.overTimeGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.empComboBox);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.overTimeGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox empComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView overTimeGridView;
    }
}