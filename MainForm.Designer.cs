namespace TestTaskExplorer
{
    partial class MainForm
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
            treeView1 = new System.Windows.Forms.TreeView();
            buttonSelectFolder = new System.Windows.Forms.Button();
            buttonSearch = new System.Windows.Forms.Button();
            buttonPauseContinue = new System.Windows.Forms.Button();
            buttonReset = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            labelTotalFiles = new System.Windows.Forms.Label();
            labelFoundFiles = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            labelCurrentFolder = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            textBoxRegex = new System.Windows.Forms.TextBox();
            textBoxPath = new System.Windows.Forms.TextBox();
            backgroundWorker = new System.ComponentModel.BackgroundWorker();
            folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            treeView1.Location = new System.Drawing.Point(10, 101);
            treeView1.Name = "treeView1";
            treeView1.Size = new System.Drawing.Size(791, 287);
            treeView1.TabIndex = 0;
            // 
            // buttonSelectFolder
            // 
            buttonSelectFolder.Location = new System.Drawing.Point(259, 32);
            buttonSelectFolder.Name = "buttonSelectFolder";
            buttonSelectFolder.Size = new System.Drawing.Size(66, 22);
            buttonSelectFolder.TabIndex = 2;
            buttonSelectFolder.Text = "Обзор";
            buttonSelectFolder.UseVisualStyleBackColor = true;
            buttonSelectFolder.Click += buttonSelectFolder_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new System.Drawing.Point(10, 59);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new System.Drawing.Size(492, 22);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "Поиск";
            buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonPauseContinue
            // 
            buttonPauseContinue.Location = new System.Drawing.Point(508, 32);
            buttonPauseContinue.Name = "buttonPauseContinue";
            buttonPauseContinue.Size = new System.Drawing.Size(128, 22);
            buttonPauseContinue.TabIndex = 2;
            buttonPauseContinue.Text = "Пауза";
            buttonPauseContinue.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            buttonReset.Location = new System.Drawing.Point(508, 59);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new System.Drawing.Size(128, 22);
            buttonReset.TabIndex = 2;
            buttonReset.Text = "Сброс";
            buttonReset.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(741, 38);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 15);
            label1.TabIndex = 3;
            label1.Text = "Найдено:";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(711, 8);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(86, 15);
            label2.TabIndex = 3;
            label2.Text = "Всего файлов:";
            // 
            // labelTotalFiles
            // 
            labelTotalFiles.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            labelTotalFiles.Location = new System.Drawing.Point(640, 23);
            labelTotalFiles.Name = "labelTotalFiles";
            labelTotalFiles.Size = new System.Drawing.Size(160, 15);
            labelTotalFiles.TabIndex = 3;
            labelTotalFiles.Text = "0";
            labelTotalFiles.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelFoundFiles
            // 
            labelFoundFiles.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            labelFoundFiles.Location = new System.Drawing.Point(640, 53);
            labelFoundFiles.Name = "labelFoundFiles";
            labelFoundFiles.Size = new System.Drawing.Size(160, 15);
            labelFoundFiles.TabIndex = 3;
            labelFoundFiles.Text = "0";
            labelFoundFiles.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(10, 83);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(51, 15);
            label5.TabIndex = 4;
            label5.Text = "Поиск в";
            // 
            // labelCurrentFolder
            // 
            labelCurrentFolder.AutoSize = true;
            labelCurrentFolder.Location = new System.Drawing.Point(63, 83);
            labelCurrentFolder.Name = "labelCurrentFolder";
            labelCurrentFolder.Size = new System.Drawing.Size(12, 15);
            labelCurrentFolder.TabIndex = 4;
            labelCurrentFolder.Text = "-";
            labelCurrentFolder.Click += labelCurrentFolder_Click;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(8, 8);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(116, 15);
            label3.TabIndex = 3;
            label3.Text = "Начальный каталог";
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(327, 8);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(137, 15);
            label4.TabIndex = 3;
            label4.Text = "Регулярное выражение";
            // 
            // textBoxRegex
            // 
            textBoxRegex.Location = new System.Drawing.Point(330, 32);
            textBoxRegex.Name = "textBoxRegex";
            textBoxRegex.Size = new System.Drawing.Size(173, 23);
            textBoxRegex.TabIndex = 1;
            // 
            // textBoxPath
            // 
            textBoxPath.Location = new System.Drawing.Point(10, 32);
            textBoxPath.Name = "textBoxPath";
            textBoxPath.Size = new System.Drawing.Size(244, 23);
            textBoxPath.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(813, 399);
            Controls.Add(labelCurrentFolder);
            Controls.Add(label5);
            Controls.Add(labelFoundFiles);
            Controls.Add(labelTotalFiles);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonReset);
            Controls.Add(buttonPauseContinue);
            Controls.Add(buttonSearch);
            Controls.Add(buttonSelectFolder);
            Controls.Add(textBoxRegex);
            Controls.Add(textBoxPath);
            Controls.Add(treeView1);
            MinimumSize = new System.Drawing.Size(829, 302);
            Name = "MainForm";
            Text = "Поиск файлов по регулярному выражению";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonSelectFolder;
        private System.Windows.Forms.TextBox textBoxRegex;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonPauseContinue;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTotalFiles;
        private System.Windows.Forms.Label labelFoundFiles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCurrentFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

