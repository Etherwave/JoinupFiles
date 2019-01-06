namespace joinup1
{
    partial class 合并文件夹
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(合并文件夹));
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.folder1 = new System.Windows.Forms.TextBox();
            this.folder2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.folder_combine = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.folderBrowserDialog3 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(579, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "选择文件夹1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // folder1
            // 
            this.folder1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.folder1.Location = new System.Drawing.Point(83, 83);
            this.folder1.Name = "folder1";
            this.folder1.Size = new System.Drawing.Size(477, 36);
            this.folder1.TabIndex = 1;
            // 
            // folder2
            // 
            this.folder2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.folder2.Location = new System.Drawing.Point(83, 166);
            this.folder2.Name = "folder2";
            this.folder2.Size = new System.Drawing.Size(477, 36);
            this.folder2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(580, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "选择文件夹2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(245, 311);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(315, 72);
            this.button3.TabIndex = 4;
            this.button3.Text = "合并";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(214, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "请选择要合并的文件夹";
            // 
            // folder_combine
            // 
            this.folder_combine.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.folder_combine.Location = new System.Drawing.Point(83, 233);
            this.folder_combine.Name = "folder_combine";
            this.folder_combine.Size = new System.Drawing.Size(477, 36);
            this.folder_combine.TabIndex = 6;
            this.folder_combine.Text = "combine";
            this.folder_combine.TextChanged += new System.EventHandler(this.folder_combine_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(579, 227);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 42);
            this.button4.TabIndex = 8;
            this.button4.Text = "合并的新文件夹名称";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // 合并文件夹
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.folder_combine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.folder2);
            this.Controls.Add(this.folder1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "合并文件夹";
            this.Text = "合并文件夹";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.TextBox folder1;
        private System.Windows.Forms.TextBox folder2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox folder_combine;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog3;
    }
}

