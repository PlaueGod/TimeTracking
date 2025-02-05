namespace TimeTracking
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
            openFileExe = new OpenFileDialog();
            textBox1 = new TextBox();
            ClearTextBox = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            textBox2 = new TextBox();
            PathOE = new Label();
            WriteT = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            GoBlock = new Button();
            exitLabel = new Label();
            label1 = new Label();
            hideBut = new Label();
            SuspendLayout();
            // 
            // openFileExe
            // 
            openFileExe.FileName = "openFileExe";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Cursor = Cursors.Hand;
            textBox1.Font = new Font("Microsoft JhengHei", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(51, 65);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(627, 36);
            textBox1.TabIndex = 0;
            textBox1.Click += textBox1_Click_1;
            textBox1.TextChanged += textBox1_Click;
            // 
            // ClearTextBox
            // 
            ClearTextBox.Cursor = Cursors.Hand;
            ClearTextBox.FlatStyle = FlatStyle.Popup;
            ClearTextBox.Font = new Font("Sitka Heading Semibold", 12.249999F, FontStyle.Bold);
            ClearTextBox.Location = new Point(603, 117);
            ClearTextBox.Name = "ClearTextBox";
            ClearTextBox.Size = new Size(75, 45);
            ClearTextBox.TabIndex = 1;
            ClearTextBox.Text = "Clear";
            ClearTextBox.UseVisualStyleBackColor = true;
            ClearTextBox.Click += ClearTextBox_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, 487);
            panel1.Name = "panel1";
            panel1.Size = new Size(735, 95);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(0, -6);
            panel2.Name = "panel2";
            panel2.Size = new Size(735, 26);
            panel2.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Microsoft JhengHei", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(539, 222);
            textBox2.MaxLength = 3;
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(139, 35);
            textBox2.TabIndex = 4;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // PathOE
            // 
            PathOE.AutoSize = true;
            PathOE.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PathOE.Location = new Point(503, 32);
            PathOE.Name = "PathOE";
            PathOE.Size = new Size(139, 19);
            PathOE.TabIndex = 5;
            PathOE.Text = "Path of exe file pls";
            // 
            // WriteT
            // 
            WriteT.AutoSize = true;
            WriteT.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WriteT.Location = new Point(241, 179);
            WriteT.Name = "WriteT";
            WriteT.Size = new Size(401, 19);
            WriteT.TabIndex = 6;
            WriteT.Text = "Write the time you want to spend in the app(In minuts)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(223, 278);
            label3.Name = "label3";
            label3.Size = new Size(419, 19);
            label3.TabIndex = 8;
            label3.Text = "Write the time for which you want to block the application";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Microsoft JhengHei", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(539, 327);
            textBox3.MaxLength = 3;
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(139, 35);
            textBox3.TabIndex = 7;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // GoBlock
            // 
            GoBlock.Cursor = Cursors.Hand;
            GoBlock.FlatStyle = FlatStyle.Popup;
            GoBlock.Font = new Font("Sitka Heading Semibold", 12.249999F, FontStyle.Bold);
            GoBlock.Location = new Point(603, 399);
            GoBlock.Name = "GoBlock";
            GoBlock.Size = new Size(75, 45);
            GoBlock.TabIndex = 9;
            GoBlock.Text = "Block";
            GoBlock.UseVisualStyleBackColor = true;
            GoBlock.Click += GoBlock_Click;
            // 
            // exitLabel
            // 
            exitLabel.AutoSize = true;
            exitLabel.BorderStyle = BorderStyle.Fixed3D;
            exitLabel.Cursor = Cursors.Hand;
            exitLabel.FlatStyle = FlatStyle.Flat;
            exitLabel.Font = new Font("Segoe UI", 15F);
            exitLabel.Location = new Point(697, 25);
            exitLabel.Name = "exitLabel";
            exitLabel.Size = new Size(26, 30);
            exitLabel.TabIndex = 11;
            exitLabel.Text = "X";
            exitLabel.Click += exitLabel_Click;
            exitLabel.MouseEnter += exitLabel_MouseEnter;
            exitLabel.MouseLeave += exitLabel_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 134);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 12;
            label1.Text = "Time:";
            // 
            // hideBut
            // 
            hideBut.AutoSize = true;
            hideBut.BorderStyle = BorderStyle.Fixed3D;
            hideBut.Cursor = Cursors.Hand;
            hideBut.FlatStyle = FlatStyle.Flat;
            hideBut.Font = new Font("Segoe UI", 15F);
            hideBut.Location = new Point(665, 25);
            hideBut.Name = "hideBut";
            hideBut.Size = new Size(22, 30);
            hideBut.TabIndex = 13;
            hideBut.Text = "-";
            hideBut.Click += hideBut_Click;
            hideBut.MouseEnter += hideBut_MouseEnter;
            hideBut.MouseLeave += hideBut_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 508);
            Controls.Add(hideBut);
            Controls.Add(label1);
            Controls.Add(exitLabel);
            Controls.Add(GoBlock);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(WriteT);
            Controls.Add(PathOE);
            Controls.Add(textBox2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(ClearTextBox);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Resize += Form1_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileExe;
        private TextBox textBox1;
        private Button ClearTextBox;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox2;
        private Label PathOE;
        private Label WriteT;
        private Label label3;
        private TextBox textBox3;
        private Button GoBlock;
        private Label exitLabel;
        private Label label1;
        private Label hideBut;
    }
}
