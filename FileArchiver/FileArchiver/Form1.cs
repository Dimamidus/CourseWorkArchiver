using System;
using System.IO;
using System.Windows.Forms;

namespace FileArchiver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void SelectArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            saveFileDialog.FileName = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                folderBrowserDialog.SelectedPath = openFileDialog.FileName;
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        MyArchiver.ExtractToDirectory(openFileDialog.FileName, folderBrowserDialog.SelectedPath);
                        richTextBox1.Text += "Архів розпаковано." + '\n';
                    }
                    catch (Exception ex)
                    {
                        richTextBox1.Text += "Помилка: " + ex.Message + '\n';
                    }
                }
            }
        }
        private void SelectFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            saveFileDialog.FileName = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                saveFileDialog.InitialDirectory = openFileDialog.FileName;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        MyArchiver.CreateFromFile(openFileDialog.FileName, saveFileDialog.FileName);
                        richTextBox1.Text += "Архів створено." + '\n';
                        double ef = (double)(new FileInfo(openFileDialog.FileName).Length) / (double)(new FileInfo(saveFileDialog.FileName).Length);
                        richTextBox1.Text += "Коефіціент: " + ef + '\n';
                        richTextBox1.Text += "Ефективність стискання: " + ef * 100 + "%\n";
                    }
                    catch (Exception ex)
                    {
                        richTextBox1.Text += "Помилка: " + ex.Message + '\n';
                    }
                }
            }
        }
        private void SelectFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = "";
            saveFileDialog.FileName = "";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                saveFileDialog.InitialDirectory = folderBrowserDialog.SelectedPath;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {            
                    try
                    {
                        MyArchiver.CreateFromDirectory(folderBrowserDialog.SelectedPath, saveFileDialog.FileName);
                        richTextBox1.Text += "Архів створено." + '\n';
                        double ef = 0;
                        var allfiles = Directory.GetFiles(folderBrowserDialog.SelectedPath, "*.*", SearchOption.AllDirectories);
                        foreach (var file in allfiles)
                        {
                            ef += (double)(new FileInfo(Path.GetFullPath(file)).Length);
                        }
                        ef /= (double)(new FileInfo(saveFileDialog.FileName).Length);
                        richTextBox1.Text += "Коефіціент: " + ef + '\n';
                        richTextBox1.Text += "Ефективність стискання: " + ef * 100 + "%\n";
                    }
                    catch (Exception ex)
                    {
                        richTextBox1.Text += "Помилка: " + ex.Message + '\n';
                    }
                }
            }
        }
        private void RenameFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string result = Microsoft.VisualBasic.Interaction.InputBox("Нова назва файлу: ");
                if (result.Length != 0)
                {
                    try
                    {
                        System.IO.File.Move(openFileDialog.FileName, Path.GetDirectoryName(openFileDialog.FileName) + '\\' + result + Path.GetExtension(openFileDialog.FileName));
                        richTextBox1.Text += "Файл перейменовано." + '\n';
                    }
                    catch (Exception ex)
                    {
                        richTextBox1.Text += "Помилка: " + ex.Message + '\n';
                    }
                }
            }
        }
        private void DeleteFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.IO.File.Delete(openFileDialog.FileName);
                    richTextBox1.Text += "Файл видалено." + '\n';
                }
                catch (Exception ex)
                {
                    richTextBox1.Text += "Помилка: " + ex.Message + '\n';
                }
            }
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void проFileArchiverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Цей архіватор розробив студент групи КІУКІ-20-7, Амосов\nДмитро.\n\nАрхіватор ризначений для стискання в ZIP архіви файлів\nабо папок з файлами, також він здатен розпакувати ці\nархіви.\nЄ можливість перейменування та видаленя файлів.", "Про FileArchiver", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
    }
}
