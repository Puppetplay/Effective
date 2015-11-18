namespace Effective_20151111
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_24_1 = new System.Windows.Forms.Button();
            this.bt25_3 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bt_24_1);
            this.flowLayoutPanel1.Controls.Add(this.bt25_3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(303, 394);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // bt_24_1
            // 
            this.bt_24_1.Location = new System.Drawing.Point(10, 10);
            this.bt_24_1.Margin = new System.Windows.Forms.Padding(10);
            this.bt_24_1.Name = "bt_24_1";
            this.bt_24_1.Size = new System.Drawing.Size(277, 39);
            this.bt_24_1.TabIndex = 0;
            this.bt_24_1.Text = "24_1_DefaultSort";
            this.bt_24_1.UseVisualStyleBackColor = true;
            this.bt_24_1.Click += new System.EventHandler(this.bt_24_1_Click);
            // 
            // bt25_3
            // 
            this.bt25_3.Location = new System.Drawing.Point(10, 69);
            this.bt25_3.Margin = new System.Windows.Forms.Padding(10);
            this.bt25_3.Name = "bt25_3";
            this.bt25_3.Size = new System.Drawing.Size(277, 39);
            this.bt25_3.TabIndex = 1;
            this.bt25_3.Text = "25_3_Serialize";
            this.bt25_3.UseVisualStyleBackColor = true;
            this.bt25_3.Click += new System.EventHandler(this.bt25_3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 394);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bt_24_1;
        private System.Windows.Forms.Button bt25_3;
    }
}

