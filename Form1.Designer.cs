namespace TestTaskExplorer
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
            treeView1 = new System.Windows.Forms.TreeView();
            buttonSelectFolder = new System.Windows.Forms.Button();
            buttonSearch = new System.Windows.Forms.Button();
            buttonPauseContinue = new System.Windows.Forms.Button();
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
            folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            backgroundWorker = new System.ComponentModel.BackgroundWorker();
            buttonReset = new System.Windows.Forms.Button();
            checkBoxTestMode = new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            treeView1.Location = new System.Drawing.Point(11, 135);
            treeView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            treeView1.Name = "treeView1";
            treeView1.Size = new System.Drawing.Size(903, 381);
            treeView1.TabIndex = 0;
            // 
            // buttonSelectFolder
            // 
            buttonSelectFolder.Location = new System.Drawing.Point(296, 43);
            buttonSelectFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonSelectFolder.Name = "buttonSelectFolder";
            buttonSelectFolder.Size = new System.Drawing.Size(75, 29);
            buttonSelectFolder.TabIndex = 2;
            buttonSelectFolder.Text = "Обзор";
            buttonSelectFolder.UseVisualStyleBackColor = true;
            buttonSelectFolder.Click += buttonSelectFolder_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new System.Drawing.Point(11, 79);
            buttonSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new System.Drawing.Size(562, 29);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "Поиск";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonPauseContinue
            // 
            buttonPauseContinue.Enabled = false;
            buttonPauseContinue.Location = new System.Drawing.Point(581, 43);
            buttonPauseContinue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonPauseContinue.Name = "buttonPauseContinue";
            buttonPauseContinue.Size = new System.Drawing.Size(146, 29);
            buttonPauseContinue.TabIndex = 2;
            buttonPauseContinue.Text = "Пауза";
            buttonPauseContinue.UseVisualStyleBackColor = true;
            buttonPauseContinue.Click += buttonPauseContinue_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(847, 51);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(74, 20);
            label1.TabIndex = 3;
            label1.Text = "Найдено:";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(813, 11);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(107, 20);
            label2.TabIndex = 3;
            label2.Text = "Всего файлов:";
            // 
            // labelTotalFiles
            // 
            labelTotalFiles.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            labelTotalFiles.Location = new System.Drawing.Point(731, 31);
            labelTotalFiles.Name = "labelTotalFiles";
            labelTotalFiles.Size = new System.Drawing.Size(183, 20);
            labelTotalFiles.TabIndex = 3;
            labelTotalFiles.Text = "0";
            labelTotalFiles.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelFoundFiles
            // 
            labelFoundFiles.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            labelFoundFiles.Location = new System.Drawing.Point(731, 71);
            labelFoundFiles.Name = "labelFoundFiles";
            labelFoundFiles.Size = new System.Drawing.Size(183, 20);
            labelFoundFiles.TabIndex = 3;
            labelFoundFiles.Text = "0";
            labelFoundFiles.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(11, 111);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(64, 20);
            label5.TabIndex = 4;
            label5.Text = "Поиск в";
            // 
            // labelCurrentFolder
            // 
            labelCurrentFolder.AutoSize = true;
            labelCurrentFolder.Location = new System.Drawing.Point(72, 111);
            labelCurrentFolder.Name = "labelCurrentFolder";
            labelCurrentFolder.Size = new System.Drawing.Size(15, 20);
            labelCurrentFolder.TabIndex = 4;
            labelCurrentFolder.Text = "-";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(9, 11);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(145, 20);
            label3.TabIndex = 3;
            label3.Text = "Начальный каталог";
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(374, 11);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(174, 20);
            label4.TabIndex = 3;
            label4.Text = "Регулярное выражение";
            // 
            // textBoxRegex
            // 
            textBoxRegex.Location = new System.Drawing.Point(377, 43);
            textBoxRegex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxRegex.Name = "textBoxRegex";
            textBoxRegex.Size = new System.Drawing.Size(197, 27);
            textBoxRegex.TabIndex = 1;
            // 
            // textBoxPath
            // 
            textBoxPath.Location = new System.Drawing.Point(11, 43);
            textBoxPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxPath.Name = "textBoxPath";
            textBoxPath.Size = new System.Drawing.Size(278, 27);
            textBoxPath.TabIndex = 1;
            // 
            // backgroundWorker
            // 
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.DoWork += backgroundWorker_DoWork;
            backgroundWorker.ProgressChanged += backgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;
            // 
            // buttonReset
            // 
            buttonReset.Enabled = false;
            buttonReset.Location = new System.Drawing.Point(581, 79);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new System.Drawing.Size(146, 29);
            buttonReset.TabIndex = 5;
            buttonReset.Text = "Сброс";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // checkBoxTestMode
            // 
            checkBoxTestMode.AutoSize = true;
            checkBoxTestMode.Location = new System.Drawing.Point(762, 94);
            checkBoxTestMode.Name = "checkBoxTestMode";
            checkBoxTestMode.Size = new System.Drawing.Size(159, 24);
            checkBoxTestMode.TabIndex = 6;
            checkBoxTestMode.Text = "Медленный поиск";
            checkBoxTestMode.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(929, 532);
            Controls.Add(checkBoxTestMode);
            Controls.Add(buttonReset);
            Controls.Add(labelCurrentFolder);
            Controls.Add(label5);
            Controls.Add(labelFoundFiles);
            Controls.Add(labelTotalFiles);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonPauseContinue);
            Controls.Add(buttonSearch);
            Controls.Add(buttonSelectFolder);
            Controls.Add(textBoxRegex);
            Controls.Add(textBoxPath);
            Controls.Add(treeView1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MinimumSize = new System.Drawing.Size(945, 387);
            Name = "Form1";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTotalFiles;
        private System.Windows.Forms.Label labelFoundFiles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCurrentFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.CheckBox checkBoxTestMode;
    }
}

