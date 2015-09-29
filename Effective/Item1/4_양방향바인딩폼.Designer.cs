namespace Effective.Item1
{
    partial class _4_양방향바인딩폼
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
            this.bt값변경 = new System.Windows.Forms.Button();
            this.bt값확인 = new System.Windows.Forms.Button();
            this.btBinding = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt값변경
            // 
            this.bt값변경.Location = new System.Drawing.Point(384, 12);
            this.bt값변경.Name = "bt값변경";
            this.bt값변경.Size = new System.Drawing.Size(75, 23);
            this.bt값변경.TabIndex = 7;
            this.bt값변경.Text = "값변경";
            this.bt값변경.UseVisualStyleBackColor = true;
            this.bt값변경.Click += new System.EventHandler(this.bt값변경_Click);
            // 
            // bt값확인
            // 
            this.bt값확인.Location = new System.Drawing.Point(303, 12);
            this.bt값확인.Name = "bt값확인";
            this.bt값확인.Size = new System.Drawing.Size(75, 23);
            this.bt값확인.TabIndex = 6;
            this.bt값확인.Text = "값확인";
            this.bt값확인.UseVisualStyleBackColor = true;
            this.bt값확인.Click += new System.EventHandler(this.bt값확인_Click);
            // 
            // btBinding
            // 
            this.btBinding.Location = new System.Drawing.Point(222, 12);
            this.btBinding.Name = "btBinding";
            this.btBinding.Size = new System.Drawing.Size(75, 23);
            this.btBinding.TabIndex = 5;
            this.btBinding.Text = "바인딩";
            this.btBinding.UseVisualStyleBackColor = true;
            this.btBinding.Click += new System.EventHandler(this.btBinding_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(204, 21);
            this.tbName.TabIndex = 4;
            // 
            // _3_양방향바인딩폼
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 46);
            this.Controls.Add(this.bt값변경);
            this.Controls.Add(this.bt값확인);
            this.Controls.Add(this.btBinding);
            this.Controls.Add(this.tbName);
            this.Name = "_3_양방향바인딩폼";
            this.Text = "_3_양방향바인딩폼";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt값변경;
        private System.Windows.Forms.Button bt값확인;
        private System.Windows.Forms.Button btBinding;
        private System.Windows.Forms.TextBox tbName;
    }
}