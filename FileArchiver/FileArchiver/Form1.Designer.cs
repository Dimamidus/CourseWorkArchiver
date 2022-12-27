namespace FileArchiver
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectArchiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проFileArchiverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.проПрограмуToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectArchiveToolStripMenuItem,
            this.SelectFileToolStripMenuItem,
            this.SelectFolderToolStripMenuItem,
            this.RenameFileToolStripMenuItem,
            this.DeleteFileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ExitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // SelectArchiveToolStripMenuItem
            // 
            this.SelectArchiveToolStripMenuItem.Name = "SelectArchiveToolStripMenuItem";
            this.SelectArchiveToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.SelectArchiveToolStripMenuItem.Text = "Обрати архів";
            this.SelectArchiveToolStripMenuItem.Click += new System.EventHandler(this.SelectArchiveToolStripMenuItem_Click);
            // 
            // SelectFileToolStripMenuItem
            // 
            this.SelectFileToolStripMenuItem.Name = "SelectFileToolStripMenuItem";
            this.SelectFileToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.SelectFileToolStripMenuItem.Text = "Обрати файл";
            this.SelectFileToolStripMenuItem.Click += new System.EventHandler(this.SelectFileToolStripMenuItem_Click);
            // 
            // SelectFolderToolStripMenuItem
            // 
            this.SelectFolderToolStripMenuItem.Name = "SelectFolderToolStripMenuItem";
            this.SelectFolderToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.SelectFolderToolStripMenuItem.Text = "Обрати папку";
            this.SelectFolderToolStripMenuItem.Click += new System.EventHandler(this.SelectFolderToolStripMenuItem_Click);
            // 
            // RenameFileToolStripMenuItem
            // 
            this.RenameFileToolStripMenuItem.Name = "RenameFileToolStripMenuItem";
            this.RenameFileToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.RenameFileToolStripMenuItem.Text = "Перейменувати файл";
            this.RenameFileToolStripMenuItem.Click += new System.EventHandler(this.RenameFileToolStripMenuItem_Click);
            // 
            // DeleteFileToolStripMenuItem
            // 
            this.DeleteFileToolStripMenuItem.Name = "DeleteFileToolStripMenuItem";
            this.DeleteFileToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.DeleteFileToolStripMenuItem.Text = "Видалити файл";
            this.DeleteFileToolStripMenuItem.Click += new System.EventHandler(this.DeleteFileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(190, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.ExitToolStripMenuItem.Text = "Вихід";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проFileArchiverToolStripMenuItem});
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.проПрограмуToolStripMenuItem.Text = "Довідка";
            // 
            // проFileArchiverToolStripMenuItem
            // 
            this.проFileArchiverToolStripMenuItem.Name = "проFileArchiverToolStripMenuItem";
            this.проFileArchiverToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.проFileArchiverToolStripMenuItem.Text = "Про File archiver";
            this.проFileArchiverToolStripMenuItem.Click += new System.EventHandler(this.проFileArchiverToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "zip";
            this.saveFileDialog.Filter = "Zip files (*.zip)|*.zip";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(800, 423);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip);
            this.Name = "Form1";
            this.Text = "File archiver";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectArchiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RenameFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проFileArchiverToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem SelectFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

