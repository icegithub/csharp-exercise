﻿namespace PinYin
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.test = new System.Windows.Forms.Button();
            this.textBoxHZ = new System.Windows.Forms.TextBox();
            this.textBoxPY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(197, 113);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(75, 23);
            this.test.TabIndex = 0;
            this.test.Text = "Test";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // textBoxHZ
            // 
            this.textBoxHZ.Location = new System.Drawing.Point(75, 24);
            this.textBoxHZ.Name = "textBoxHZ";
            this.textBoxHZ.Size = new System.Drawing.Size(197, 21);
            this.textBoxHZ.TabIndex = 1;
            // 
            // textBoxPY
            // 
            this.textBoxPY.Location = new System.Drawing.Point(75, 71);
            this.textBoxPY.Name = "textBoxPY";
            this.textBoxPY.ReadOnly = true;
            this.textBoxPY.Size = new System.Drawing.Size(197, 21);
            this.textBoxPY.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "输入汉字：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "显示拼音：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 149);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPY);
            this.Controls.Add(this.textBoxHZ);
            this.Controls.Add(this.test);
            this.Name = "Form1";
            this.Text = "拼音";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button test;
        private System.Windows.Forms.TextBox textBoxHZ;
        private System.Windows.Forms.TextBox textBoxPY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
