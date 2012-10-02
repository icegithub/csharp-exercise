namespace T2
{
    partial class FormMain
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelNum = new System.Windows.Forms.Label();
            this.groupBoxScore = new System.Windows.Forms.GroupBox();
            this.labelPostion = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelChinese = new System.Windows.Forms.Label();
            this.labelEnglish = new System.Windows.Forms.Label();
            this.labelMath = new System.Windows.Forms.Label();
            this.labelAverage = new System.Windows.Forms.Label();
            this.textBoxEnglish = new System.Windows.Forms.TextBox();
            this.textBoxMath = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxChinese = new System.Windows.Forms.TextBox();
            this.textBoxAverage = new System.Windows.Forms.TextBox();
            this.textBoxPostion = new System.Windows.Forms.TextBox();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.textBoxClass = new System.Windows.Forms.TextBox();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.groupBoxMode = new System.Windows.Forms.GroupBox();
            this.checkBoxChangeable = new System.Windows.Forms.CheckBox();
            this.listBoxStuList = new System.Windows.Forms.ListBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.listBoxClassList = new System.Windows.Forms.ListBox();
            this.labelClassList = new System.Windows.Forms.Label();
            this.labelStuList = new System.Windows.Forms.Label();
            this.groupBoxMessage = new System.Windows.Forms.GroupBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelSortMode = new System.Windows.Forms.Label();
            this.comboBoxSortMode = new System.Windows.Forms.ComboBox();
            this.groupBoxScore.SuspendLayout();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxMode.SuspendLayout();
            this.groupBoxMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(16, 27);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(41, 12);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "姓名：";
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(239, 28);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(41, 12);
            this.labelClass.TabIndex = 1;
            this.labelClass.Text = "班级：";
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Location = new System.Drawing.Point(144, 28);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(41, 12);
            this.labelNum.TabIndex = 2;
            this.labelNum.Text = "学号：";
            // 
            // groupBoxScore
            // 
            this.groupBoxScore.Controls.Add(this.labelPostion);
            this.groupBoxScore.Controls.Add(this.labelTotal);
            this.groupBoxScore.Controls.Add(this.labelChinese);
            this.groupBoxScore.Controls.Add(this.labelEnglish);
            this.groupBoxScore.Controls.Add(this.labelMath);
            this.groupBoxScore.Controls.Add(this.labelAverage);
            this.groupBoxScore.Controls.Add(this.textBoxEnglish);
            this.groupBoxScore.Controls.Add(this.textBoxMath);
            this.groupBoxScore.Controls.Add(this.textBoxTotal);
            this.groupBoxScore.Controls.Add(this.textBoxChinese);
            this.groupBoxScore.Controls.Add(this.textBoxAverage);
            this.groupBoxScore.Controls.Add(this.textBoxPostion);
            this.groupBoxScore.Location = new System.Drawing.Point(6, 82);
            this.groupBoxScore.Name = "groupBoxScore";
            this.groupBoxScore.Size = new System.Drawing.Size(369, 175);
            this.groupBoxScore.TabIndex = 4;
            this.groupBoxScore.TabStop = false;
            this.groupBoxScore.Text = "成绩信息";
            // 
            // labelPostion
            // 
            this.labelPostion.AutoSize = true;
            this.labelPostion.Location = new System.Drawing.Point(211, 136);
            this.labelPostion.Name = "labelPostion";
            this.labelPostion.Size = new System.Drawing.Size(41, 12);
            this.labelPostion.TabIndex = 16;
            this.labelPostion.Text = "排名：";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(211, 35);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(41, 12);
            this.labelTotal.TabIndex = 15;
            this.labelTotal.Text = "总分：";
            // 
            // labelChinese
            // 
            this.labelChinese.AutoSize = true;
            this.labelChinese.Location = new System.Drawing.Point(24, 38);
            this.labelChinese.Name = "labelChinese";
            this.labelChinese.Size = new System.Drawing.Size(41, 12);
            this.labelChinese.TabIndex = 14;
            this.labelChinese.Text = "语文：";
            // 
            // labelEnglish
            // 
            this.labelEnglish.AutoSize = true;
            this.labelEnglish.Location = new System.Drawing.Point(24, 86);
            this.labelEnglish.Name = "labelEnglish";
            this.labelEnglish.Size = new System.Drawing.Size(41, 12);
            this.labelEnglish.TabIndex = 13;
            this.labelEnglish.Text = "英语：";
            // 
            // labelMath
            // 
            this.labelMath.AutoSize = true;
            this.labelMath.Location = new System.Drawing.Point(24, 136);
            this.labelMath.Name = "labelMath";
            this.labelMath.Size = new System.Drawing.Size(41, 12);
            this.labelMath.TabIndex = 12;
            this.labelMath.Text = "数学：";
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Location = new System.Drawing.Point(211, 86);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(41, 12);
            this.labelAverage.TabIndex = 11;
            this.labelAverage.Text = "平均：";
            // 
            // textBoxEnglish
            // 
            this.textBoxEnglish.Location = new System.Drawing.Point(71, 83);
            this.textBoxEnglish.Name = "textBoxEnglish";
            this.textBoxEnglish.ReadOnly = true;
            this.textBoxEnglish.Size = new System.Drawing.Size(87, 21);
            this.textBoxEnglish.TabIndex = 10;
            this.textBoxEnglish.WordWrap = false;
            this.textBoxEnglish.TextChanged += new System.EventHandler(this.textBoxEnglish_TextChanged);
            // 
            // textBoxMath
            // 
            this.textBoxMath.Location = new System.Drawing.Point(71, 133);
            this.textBoxMath.Name = "textBoxMath";
            this.textBoxMath.ReadOnly = true;
            this.textBoxMath.Size = new System.Drawing.Size(87, 21);
            this.textBoxMath.TabIndex = 9;
            this.textBoxMath.WordWrap = false;
            this.textBoxMath.TextChanged += new System.EventHandler(this.textBoxMath_TextChanged);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(258, 32);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(87, 21);
            this.textBoxTotal.TabIndex = 8;
            this.textBoxTotal.WordWrap = false;
            // 
            // textBoxChinese
            // 
            this.textBoxChinese.Location = new System.Drawing.Point(71, 35);
            this.textBoxChinese.Name = "textBoxChinese";
            this.textBoxChinese.ReadOnly = true;
            this.textBoxChinese.Size = new System.Drawing.Size(87, 21);
            this.textBoxChinese.TabIndex = 7;
            this.textBoxChinese.WordWrap = false;
            this.textBoxChinese.TextChanged += new System.EventHandler(this.textBoxChinese_TextChanged);
            // 
            // textBoxAverage
            // 
            this.textBoxAverage.Location = new System.Drawing.Point(258, 83);
            this.textBoxAverage.Name = "textBoxAverage";
            this.textBoxAverage.ReadOnly = true;
            this.textBoxAverage.Size = new System.Drawing.Size(87, 21);
            this.textBoxAverage.TabIndex = 6;
            this.textBoxAverage.WordWrap = false;
            // 
            // textBoxPostion
            // 
            this.textBoxPostion.Location = new System.Drawing.Point(258, 133);
            this.textBoxPostion.Name = "textBoxPostion";
            this.textBoxPostion.ReadOnly = true;
            this.textBoxPostion.Size = new System.Drawing.Size(87, 21);
            this.textBoxPostion.TabIndex = 5;
            this.textBoxPostion.WordWrap = false;
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.textBoxClass);
            this.groupBoxInfo.Controls.Add(this.textBoxNum);
            this.groupBoxInfo.Controls.Add(this.textBoxName);
            this.groupBoxInfo.Controls.Add(this.labelName);
            this.groupBoxInfo.Controls.Add(this.labelNum);
            this.groupBoxInfo.Controls.Add(this.labelClass);
            this.groupBoxInfo.Location = new System.Drawing.Point(6, 20);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(369, 56);
            this.groupBoxInfo.TabIndex = 5;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "个人信息";
            // 
            // textBoxClass
            // 
            this.textBoxClass.Location = new System.Drawing.Point(271, 25);
            this.textBoxClass.Name = "textBoxClass";
            this.textBoxClass.ReadOnly = true;
            this.textBoxClass.Size = new System.Drawing.Size(87, 21);
            this.textBoxClass.TabIndex = 7;
            this.textBoxClass.WordWrap = false;
            this.textBoxClass.TextChanged += new System.EventHandler(this.textBoxClass_TextChanged);
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(169, 24);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.ReadOnly = true;
            this.textBoxNum.Size = new System.Drawing.Size(64, 21);
            this.textBoxNum.TabIndex = 8;
            this.textBoxNum.WordWrap = false;
            this.textBoxNum.TextChanged += new System.EventHandler(this.textBoxNum_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(51, 24);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(87, 21);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.WordWrap = false;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // groupBoxMode
            // 
            this.groupBoxMode.Controls.Add(this.groupBoxInfo);
            this.groupBoxMode.Controls.Add(this.groupBoxScore);
            this.groupBoxMode.Location = new System.Drawing.Point(140, 3);
            this.groupBoxMode.Name = "groupBoxMode";
            this.groupBoxMode.Size = new System.Drawing.Size(380, 266);
            this.groupBoxMode.TabIndex = 6;
            this.groupBoxMode.TabStop = false;
            this.groupBoxMode.Text = "查询模式";
            // 
            // checkBoxChangeable
            // 
            this.checkBoxChangeable.AutoSize = true;
            this.checkBoxChangeable.Location = new System.Drawing.Point(28, 264);
            this.checkBoxChangeable.Name = "checkBoxChangeable";
            this.checkBoxChangeable.Size = new System.Drawing.Size(72, 16);
            this.checkBoxChangeable.TabIndex = 7;
            this.checkBoxChangeable.Text = "启用修改";
            this.checkBoxChangeable.UseVisualStyleBackColor = true;
            this.checkBoxChangeable.CheckedChanged += new System.EventHandler(this.checkBoxChangeable_CheckedChanged);
            // 
            // listBoxStuList
            // 
            this.listBoxStuList.FormattingEnabled = true;
            this.listBoxStuList.ItemHeight = 12;
            this.listBoxStuList.Location = new System.Drawing.Point(12, 133);
            this.listBoxStuList.Name = "listBoxStuList";
            this.listBoxStuList.Size = new System.Drawing.Size(122, 100);
            this.listBoxStuList.TabIndex = 8;
            this.listBoxStuList.SelectedIndexChanged += new System.EventHandler(this.listBoxStuList_SelectedIndexChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(25, 301);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Text = "删除";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // listBoxClassList
            // 
            this.listBoxClassList.FormattingEnabled = true;
            this.listBoxClassList.ItemHeight = 12;
            this.listBoxClassList.Location = new System.Drawing.Point(12, 28);
            this.listBoxClassList.Name = "listBoxClassList";
            this.listBoxClassList.Size = new System.Drawing.Size(122, 40);
            this.listBoxClassList.TabIndex = 10;
            this.listBoxClassList.SelectedValueChanged += new System.EventHandler(this.listBoxClassList_SelectedValueChanged);
            // 
            // labelClassList
            // 
            this.labelClassList.AutoSize = true;
            this.labelClassList.Location = new System.Drawing.Point(12, 9);
            this.labelClassList.Name = "labelClassList";
            this.labelClassList.Size = new System.Drawing.Size(41, 12);
            this.labelClassList.TabIndex = 11;
            this.labelClassList.Text = "班级：";
            // 
            // labelStuList
            // 
            this.labelStuList.AutoSize = true;
            this.labelStuList.Location = new System.Drawing.Point(12, 117);
            this.labelStuList.Name = "labelStuList";
            this.labelStuList.Size = new System.Drawing.Size(41, 12);
            this.labelStuList.TabIndex = 12;
            this.labelStuList.Text = "学生：";
            // 
            // groupBoxMessage
            // 
            this.groupBoxMessage.Controls.Add(this.labelMessage);
            this.groupBoxMessage.Location = new System.Drawing.Point(140, 283);
            this.groupBoxMessage.Name = "groupBoxMessage";
            this.groupBoxMessage.Size = new System.Drawing.Size(380, 59);
            this.groupBoxMessage.TabIndex = 14;
            this.groupBoxMessage.TabStop = false;
            this.groupBoxMessage.Text = "提示信息";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(22, 18);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(47, 12);
            this.labelMessage.TabIndex = 0;
            this.labelMessage.Text = "message";
            // 
            // labelSortMode
            // 
            this.labelSortMode.AutoSize = true;
            this.labelSortMode.Location = new System.Drawing.Point(12, 71);
            this.labelSortMode.Name = "labelSortMode";
            this.labelSortMode.Size = new System.Drawing.Size(65, 12);
            this.labelSortMode.TabIndex = 15;
            this.labelSortMode.Text = "排序方式：";
            // 
            // comboBoxSortMode
            // 
            this.comboBoxSortMode.FormattingEnabled = true;
            this.comboBoxSortMode.Location = new System.Drawing.Point(14, 87);
            this.comboBoxSortMode.Name = "comboBoxSortMode";
            this.comboBoxSortMode.Size = new System.Drawing.Size(120, 20);
            this.comboBoxSortMode.TabIndex = 16;
            this.comboBoxSortMode.Text = "选择排序模式";
            this.comboBoxSortMode.TextChanged += new System.EventHandler(this.comboBoxSortMode_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(528, 351);
            this.Controls.Add(this.comboBoxSortMode);
            this.Controls.Add(this.labelSortMode);
            this.Controls.Add(this.groupBoxMessage);
            this.Controls.Add(this.labelStuList);
            this.Controls.Add(this.labelClassList);
            this.Controls.Add(this.listBoxClassList);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.listBoxStuList);
            this.Controls.Add(this.checkBoxChangeable);
            this.Controls.Add(this.groupBoxMode);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(544, 389);
            this.MinimumSize = new System.Drawing.Size(544, 389);
            this.Name = "FormMain";
            this.Text = "学生系统";
            this.groupBoxScore.ResumeLayout(false);
            this.groupBoxScore.PerformLayout();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBoxMode.ResumeLayout(false);
            this.groupBoxMessage.ResumeLayout(false);
            this.groupBoxMessage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.GroupBox groupBoxScore;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelPostion;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelChinese;
        private System.Windows.Forms.Label labelEnglish;
        private System.Windows.Forms.Label labelMath;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.TextBox textBoxEnglish;
        private System.Windows.Forms.TextBox textBoxMath;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxChinese;
        private System.Windows.Forms.TextBox textBoxAverage;
        private System.Windows.Forms.TextBox textBoxPostion;
        private System.Windows.Forms.TextBox textBoxClass;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.GroupBox groupBoxMode;
        private System.Windows.Forms.CheckBox checkBoxChangeable;
        private System.Windows.Forms.ListBox listBoxStuList;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListBox listBoxClassList;
        private System.Windows.Forms.Label labelClassList;
        private System.Windows.Forms.Label labelStuList;
        private System.Windows.Forms.GroupBox groupBoxMessage;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelSortMode;
        private System.Windows.Forms.ComboBox comboBoxSortMode;
    }
}

