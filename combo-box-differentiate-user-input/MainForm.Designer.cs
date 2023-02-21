namespace combo_box_differentiate_user_input
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(12, 14);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(182, 36);
            this.comboBox.TabIndex = 4;
            this.comboBox.TabStop = false;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown.Location = new System.Drawing.Point(12, 108);
            this.numericUpDown.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(85, 39);
            this.numericUpDown.TabIndex = 1;
            this.numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(212, 14);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(225, 222);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 244);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.comboBox);
            this.Name = "MainForm";
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.NumericUpDown numericUpDown;
    }
}
