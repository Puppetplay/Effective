namespace Effective
{
    partial class MainForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bt1_3 = new System.Windows.Forms.Button();
            this.bt1_4 = new System.Windows.Forms.Button();
            this.bt1_6 = new System.Windows.Forms.Button();
            this.bt3_1 = new System.Windows.Forms.Button();
            this.bt_3_3 = new System.Windows.Forms.Button();
            this.bt_3_4 = new System.Windows.Forms.Button();
            this.bt_3_6 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.bt1_3);
            this.flowLayoutPanel1.Controls.Add(this.bt1_4);
            this.flowLayoutPanel1.Controls.Add(this.bt1_6);
            this.flowLayoutPanel1.Controls.Add(this.bt3_1);
            this.flowLayoutPanel1.Controls.Add(this.bt_3_3);
            this.flowLayoutPanel1.Controls.Add(this.bt_3_4);
            this.flowLayoutPanel1.Controls.Add(this.bt_3_6);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(281, 420);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // bt1_3
            // 
            this.bt1_3.Location = new System.Drawing.Point(8, 8);
            this.bt1_3.Margin = new System.Windows.Forms.Padding(8);
            this.bt1_3.Name = "bt1_3";
            this.bt1_3.Size = new System.Drawing.Size(237, 42);
            this.bt1_3.TabIndex = 0;
            this.bt1_3.Text = "1_3_ 데이터바인딩";
            this.bt1_3.UseVisualStyleBackColor = true;
            this.bt1_3.Click += new System.EventHandler(this.bt1_3_Click);
            // 
            // bt1_4
            // 
            this.bt1_4.Location = new System.Drawing.Point(8, 66);
            this.bt1_4.Margin = new System.Windows.Forms.Padding(8);
            this.bt1_4.Name = "bt1_4";
            this.bt1_4.Size = new System.Drawing.Size(237, 42);
            this.bt1_4.TabIndex = 1;
            this.bt1_4.Text = "1_4_양방향바인딩";
            this.bt1_4.UseVisualStyleBackColor = true;
            this.bt1_4.Click += new System.EventHandler(this.bt1_4_Click);
            // 
            // bt1_6
            // 
            this.bt1_6.Location = new System.Drawing.Point(8, 124);
            this.bt1_6.Margin = new System.Windows.Forms.Padding(8);
            this.bt1_6.Name = "bt1_6";
            this.bt1_6.Size = new System.Drawing.Size(237, 42);
            this.bt1_6.TabIndex = 2;
            this.bt1_6.Text = "1_6_Lock";
            this.bt1_6.UseVisualStyleBackColor = true;
            this.bt1_6.Click += new System.EventHandler(this.bt1_6_Click);
            // 
            // bt3_1
            // 
            this.bt3_1.Location = new System.Drawing.Point(8, 182);
            this.bt3_1.Margin = new System.Windows.Forms.Padding(8);
            this.bt3_1.Name = "bt3_1";
            this.bt3_1.Size = new System.Drawing.Size(237, 42);
            this.bt3_1.TabIndex = 3;
            this.bt3_1.Text = "3_1_Cast";
            this.bt3_1.UseVisualStyleBackColor = true;
            this.bt3_1.Click += new System.EventHandler(this.bt3_1_Click);
            // 
            // bt_3_3
            // 
            this.bt_3_3.Location = new System.Drawing.Point(8, 240);
            this.bt_3_3.Margin = new System.Windows.Forms.Padding(8);
            this.bt_3_3.Name = "bt_3_3";
            this.bt_3_3.Size = new System.Drawing.Size(237, 42);
            this.bt_3_3.TabIndex = 4;
            this.bt_3_3.Text = "3_3_As";
            this.bt_3_3.UseVisualStyleBackColor = true;
            // 
            // bt_3_4
            // 
            this.bt_3_4.Location = new System.Drawing.Point(8, 298);
            this.bt_3_4.Margin = new System.Windows.Forms.Padding(8);
            this.bt_3_4.Name = "bt_3_4";
            this.bt_3_4.Size = new System.Drawing.Size(237, 42);
            this.bt_3_4.TabIndex = 5;
            this.bt_3_4.Text = "3_4_사용자정의형변환";
            this.bt_3_4.UseVisualStyleBackColor = true;
            this.bt_3_4.Click += new System.EventHandler(this.bt_3_4_Click);
            // 
            // bt_3_6
            // 
            this.bt_3_6.Location = new System.Drawing.Point(8, 356);
            this.bt_3_6.Margin = new System.Windows.Forms.Padding(8);
            this.bt_3_6.Name = "bt_3_6";
            this.bt_3_6.Size = new System.Drawing.Size(237, 42);
            this.bt_3_6.TabIndex = 6;
            this.bt_3_6.Text = "3_6_값타입";
            this.bt_3_6.UseVisualStyleBackColor = true;
            this.bt_3_6.Click += new System.EventHandler(this.bt_3_6_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(281, 420);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bt1_3;
        private System.Windows.Forms.Button bt1_4;
        private System.Windows.Forms.Button bt1_6;
        private System.Windows.Forms.Button bt3_1;
        private System.Windows.Forms.Button bt_3_3;
        private System.Windows.Forms.Button bt_3_4;
        private System.Windows.Forms.Button bt_3_6;
    }
}