namespace Stackoverflow_77490286.WinForms
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
            components = new System.ComponentModel.Container();
            listBox1 = new ListBox();
            btnSendData = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            listBox2 = new ListBox();
            btnCalculatePattern = new Button();
            label4 = new Label();
            label6 = new Label();
            btnAvatar = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "3.10", "110.30", "110.120", "50.40" });
            listBox1.Location = new Point(53, 422);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 104);
            listBox1.TabIndex = 0;
            // 
            // btnSendData
            // 
            btnSendData.Enabled = false;
            btnSendData.Location = new Point(376, 497);
            btnSendData.Name = "btnSendData";
            btnSendData.Size = new Size(135, 29);
            btnSendData.TabIndex = 1;
            btnSendData.Text = "Send Data";
            btnSendData.UseVisualStyleBackColor = true;
            btnSendData.Click += btnSendData_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(376, 422);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(135, 27);
            textBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(376, 395);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 3;
            label1.Text = "Sent Command";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 395);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 4;
            label2.Text = "Coordinates";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(209, 422);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(150, 104);
            listBox2.TabIndex = 5;
            // 
            // btnCalculatePattern
            // 
            btnCalculatePattern.Location = new Point(376, 462);
            btnCalculatePattern.Name = "btnCalculatePattern";
            btnCalculatePattern.Size = new Size(135, 29);
            btnCalculatePattern.TabIndex = 7;
            btnCalculatePattern.Text = "Calculate Pattern";
            btnCalculatePattern.UseVisualStyleBackColor = true;
            btnCalculatePattern.Click += btnCalculatePattern_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(209, 395);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 9;
            label4.Text = "Pattern";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Red;
            label6.Location = new Point(185, 78);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 11;
            // 
            // btnAvatar
            // 
            btnAvatar.BackColor = Color.Red;
            btnAvatar.FlatAppearance.BorderSize = 0;
            btnAvatar.Location = new Point(-1, -2);
            btnAvatar.Margin = new Padding(0);
            btnAvatar.Name = "btnAvatar";
            btnAvatar.Size = new Size(32, 32);
            btnAvatar.TabIndex = 13;
            btnAvatar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 572);
            Controls.Add(btnAvatar);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(btnCalculatePattern);
            Controls.Add(listBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(btnSendData);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Command";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button btnSendData;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private ListBox listBox2;
        private Button btnCalculatePattern;
        private Label label4;
        private Label label6;
        private Button btnAvatar;
    }
}