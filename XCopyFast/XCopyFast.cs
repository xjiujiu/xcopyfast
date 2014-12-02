using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace XCopyFast
{
    public partial class XCopyFast : Form
    {
        public XCopyFast()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 开始复制目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartCopyBtn_Click(object sender, EventArgs e)
        {
            String baseDir      = SrcRootDir.Text.Replace("\\", "/");
            String [] subFiles  = (SrcSubDir.Text.Replace("\\", "/").Replace("，", ",")).Split('\r');
            String descDir      = DescDir.Text.Replace("\\", "/");
            try {
                LogTextBox.Text = "";
                foreach(String file in subFiles) {
                    String srcFile  = file.Replace("\n", "");
                    CopyFile(baseDir + "/" + srcFile, descDir + "/" + srcFile);
                }
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// 创建目录
        /// </summary>
        /// <param name="newDir"></param>
        private void CreateDirectory(String newDir)
        {
            String [] dirs  = newDir.Split('/');
            String dirPath  = "";
            foreach(String dir in dirs) {
                dirPath     += dir + "/";
                DirectoryInfo dirInfo   = new DirectoryInfo(dirPath);
                if(dirInfo.Exists) {
                    continue;
                }
                dirInfo.Create();
            }
        }
        
        /// <summary>
        /// 复制文件
        /// </summary>
        /// <param name="srcFile">源文件</param>
        /// <param name="descFile">目标文件</param>
        private void CopyFile(String srcFile, String descFile)
        {
            FileInfo file   = new FileInfo(srcFile);
            if(!file.Exists) {
                return;
            }
            CreateDirectory(_GetParentDir(descFile));
            FileInfo descInfo   = new FileInfo(descFile);
            if(descInfo.Exists) {
                LogTextBox.Text     += "[Exists]\t" + srcFile + "\r\n";
                return;
            }
            LogTextBox.Text     += "[Copying]\t" + srcFile + "\r\n";
            File.Copy(file.FullName, descFile, true);
            LogTextBox.Text     += "[Done]\t" + srcFile + "\r\n";
        }

        /// <summary>
        /// 得到当前文件所在目录
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        private String _GetParentDir(String file)
        {
            int loc     = file.LastIndexOf("/");

            return file.Substring(0, loc);
        }

        /// <summary>
        /// 复制目录
        /// </summary>
        /// <param name="srcDir"></param>
        /// <param name="tgtDir"></param>
        private void CopyDirectory(string srcDir, string tgtDir)
        {
            DirectoryInfo source = new DirectoryInfo(srcDir);
            DirectoryInfo target = new DirectoryInfo(tgtDir);
            if (target.FullName.StartsWith(source.FullName, StringComparison.CurrentCultureIgnoreCase)) {
                throw new Exception("父目录不能拷贝到子目录！");
            }
            if (!source.Exists) {
                return;
            }
            if (!target.Exists) {
                target.Create();
            }
            FileInfo[] files = source.GetFiles();
            for (int i = 0; i < files.Length; i++) {
                File.Copy(files[i].FullName, target.FullName + @"\" + files[i].Name, true);
                LogTextBox.Text   += "[Copying]" + files[i].FullName + "\r\n"; 
            }
            DirectoryInfo[] dirs = source.GetDirectories();
            for (int j = 0; j < dirs.Length; j++) {
                CopyDirectory(dirs[j].FullName, target.FullName + @"\" + dirs[j].Name);
            }
        }

        /// <summary>
        /// 选择源根目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectSrcRootDir_Click(object sender, EventArgs e)
        {
            DialogResult dr     = FBDBaseDir.ShowDialog();
            if(dr != DialogResult.OK) {
                return;
            }
            SrcRootDir.Text     = FBDBaseDir.SelectedPath;
        }

        /// <summary>
        /// 选择目标目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectDescDir_Click(object sender, EventArgs e)
        {
            DialogResult dr     = FBDDescDir.ShowDialog();
            if(dr != DialogResult.OK) {
                return;
            }
            DescDir.Text        = FBDDescDir.SelectedPath;
        }

        private void TSMIClose_Click(object sender, EventArgs e)
        {
            Close();
        } 
    }
}
