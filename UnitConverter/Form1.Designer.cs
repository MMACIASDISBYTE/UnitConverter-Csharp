namespace UnitConverter
{
    partial class Form1
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
            label1 = new Label();
            txtAmount = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            cmbType = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            lstFrom = new ListBox();
            lstTo = new ListBox();
            convert = new Button();
            panel2 = new Panel();
            txtConvertedAmount = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 37);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Amount";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(131, 34);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(196, 27);
            txtAmount.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtAmount);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(67, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(386, 106);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 163);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 3;
            label2.Text = "Type";
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(146, 160);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(304, 28);
            cmbType.TabIndex = 4;
            cmbType.SelectedIndexChanged += cmbType_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 226);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 3;
            label3.Text = "From";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(413, 226);
            label4.Name = "label4";
            label4.Size = new Size(25, 20);
            label4.TabIndex = 5;
            label4.Text = "To";
            // 
            // lstFrom
            // 
            lstFrom.FormattingEnabled = true;
            lstFrom.ItemHeight = 20;
            lstFrom.Location = new Point(67, 256);
            lstFrom.Name = "lstFrom";
            lstFrom.Size = new Size(149, 124);
            lstFrom.TabIndex = 6;
            // 
            // lstTo
            // 
            lstTo.FormattingEnabled = true;
            lstTo.ItemHeight = 20;
            lstTo.Location = new Point(304, 256);
            lstTo.Name = "lstTo";
            lstTo.Size = new Size(149, 124);
            lstTo.TabIndex = 7;
            // 
            // convert
            // 
            convert.Location = new Point(208, 398);
            convert.Name = "convert";
            convert.Size = new Size(106, 44);
            convert.TabIndex = 8;
            convert.Text = "Convert";
            convert.UseVisualStyleBackColor = true;
            convert.Click += convert_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtConvertedAmount);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(67, 463);
            panel2.Name = "panel2";
            panel2.Size = new Size(386, 106);
            panel2.TabIndex = 9;
            // 
            // txtConvertedAmount
            // 
            txtConvertedAmount.Location = new Point(57, 53);
            txtConvertedAmount.Name = "txtConvertedAmount";
            txtConvertedAmount.Size = new Size(270, 27);
            txtConvertedAmount.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(131, 20);
            label5.Name = "label5";
            label5.Size = new Size(134, 20);
            label5.TabIndex = 0;
            label5.Text = "Converted Amount";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 593);
            Controls.Add(panel2);
            Controls.Add(convert);
            Controls.Add(lstTo);
            Controls.Add(lstFrom);
            Controls.Add(label4);
            Controls.Add(cmbType);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Unit Converter";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAmount;
        private Panel panel1;
        private Label label2;
        private ComboBox cmbType;
        private Label label3;
        private Label label4;
        private ListBox lstFrom;
        private ListBox lstTo;
        private Button convert;
        private Panel panel2;
        private TextBox txtConvertedAmount;
        private Label label5;
    }
}