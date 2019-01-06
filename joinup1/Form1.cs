using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace joinup1
{
    public partial class 合并文件夹 : Form
    {
        public string firstToCombineFolder;
        public string secondToCombineFolder;

        public bool equls(string filePath1, string filePath2)
        {
            //创建一个哈希算法对象 
            using (HashAlgorithm hash = HashAlgorithm.Create())
            {
                using (FileStream file1 = new FileStream(filePath1, FileMode.Open), file2 = new FileStream(filePath2, FileMode.Open))
                {
                    byte[] hashByte1 = hash.ComputeHash(file1);//哈希算法根据文本得到哈希码的字节数组 
                    byte[] hashByte2 = hash.ComputeHash(file2);
                    string str1 = BitConverter.ToString(hashByte1);//将字节数组装换为字符串 
                    string str2 = BitConverter.ToString(hashByte2);
                    return (str1 == str2);//比较哈希码 
                }
            }
        }

        public 合并文件夹()
        {
            InitializeComponent();
            this.folder_combine.Text= System.IO.Directory.GetCurrentDirectory()+"\\combine";
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folder1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                folder2.Text = folderBrowserDialog2.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(this.folder1.Text==""||this.folder2.Text==""||this.folder_combine.Text=="")
            {
                this.label1.Text = "请选择要合并的文件夹";
            }
            else
            {
                this.label1.Text = "正在合并";
                combine();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog3.ShowDialog() == DialogResult.OK)
            {
                folder_combine.Text = folderBrowserDialog3.SelectedPath;
            }
        }

        public void CombineFolder(string sourcePath, string destPath)
        {
            if (Directory.Exists(sourcePath))
            {
                if (!Directory.Exists(destPath))
                {
                    //目标目录不存在则创建
                    try
                    {
                        Directory.CreateDirectory(destPath);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("创建目标目录失败:" + ex.Message);
                    }
                }
                //获得源文件下所有文件
                List<string> files = new List<string>(Directory.GetFiles(sourcePath));
                //List<string> files_dest = new List<string>(Directory.GetFiles(destPath));
                files.ForEach(c =>
                {
                    string destFile = Path.Combine(new string[] { destPath, Path.GetFileName(c) });
                    //覆盖模式
                    //如果目标文件夹下有该文件，那么首先删除该文件
                    if (File.Exists(destFile))
                    {
                        //如果目标文件夹中有该文件，那么获取两个文件的信息
                        //如果两个文件不同，那么就将原文件重命名，并把新文件copy过来
                        FileInfo f1 = new FileInfo(c);
                        FileInfo f2 = new FileInfo(destFile);
                        if (f1.Length != f2.Length || !equls(c, destFile))
                        {
                            string newPath = destPath + "\\1" + f1.Name;
                            File.Move(destFile, newPath);
                            File.Copy(c, destFile);
                        }
                    }
                    else
                    {
                        //把新文件复制过来
                        File.Copy(c, destFile);
                    }
                });
                //获得源文件下所有目录文件
                List<string> folders = new List<string>(Directory.GetDirectories(sourcePath));

                folders.ForEach(c =>
                {
                    string destDir = Path.Combine(new string[] { destPath, Path.GetFileName(c) });
                    //Directory.Move必须要在同一个根目录下移动才有效,不能在不同卷中移动。
                    //Directory.Move(c, destDir);

                    //采用递归的方法实现
                    CombineFolder(c, destDir);
                });
            }
            else
            {
                throw new DirectoryNotFoundException("源目录不存在!");
            }
        }

        public void combine()
        {
            //首先创建要合并到的文件夹
            string Path = this.folder_combine.Text;
            if (!Directory.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }
            /*首先将一个文件夹的全部内容移动到combine文件夹
             *此处要判断要合并到的文件夹是不是源文件夹
             * 如果是源文件夹，那么直接将另一个文件夹的内容合并过来就好了
             * 如果不是那么我们就还需要先将一个文件的内容首先先全部搬过来
             */
            //确定合并顺序
            //firstToCombineFolder首先移进去
            //secondToCombineFolder第二个移进去
            this.firstToCombineFolder = this.folder1.Text;
            this.secondToCombineFolder = this.folder2.Text;
            if (this.folder_combine.Text == this.folder2.Text)
            {
                this.firstToCombineFolder = this.folder2.Text;
                this.secondToCombineFolder = this.folder1.Text;
            }
            //如果firstToCombineFolder等于combine
            //那么就不需要先将第一个文件先移动进combine文件夹了
            //否则先将第一个文件夹里的内容合并进combine文件夹
            if(this.firstToCombineFolder!=this.folder_combine.Text)
            {
                this.CombineFolder(this.firstToCombineFolder, this.folder_combine.Text);
            }

            //将第二个文件夹合并入combine文件夹
            CombineFolder(this.secondToCombineFolder, this.folder_combine.Text);

            this.label1.Text = "合并完成";
        }

        private void folder_combine_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
