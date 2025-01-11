namespace text_editor
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
            this.components = new System.ComponentModel.Container();
            this.toolBar = new System.Windows.Forms.Panel();
            this.cms_toolBar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.скрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bExit = new System.Windows.Forms.Button();
            this.bHelp = new System.Windows.Forms.Button();
            this.bCut = new System.Windows.Forms.Button();
            this.bPaste = new System.Windows.Forms.Button();
            this.bCopy = new System.Windows.Forms.Button();
            this.bFileClose = new System.Windows.Forms.Button();
            this.bFileOpen = new System.Windows.Forms.Button();
            this.bFileSave = new System.Windows.Forms.Button();
            this.bFileNew = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветФонаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветШрифтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findMSG = new System.Windows.Forms.ToolStripTextBox();
            this.заменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replacingMSG = new System.Windows.Forms.ToolStripTextBox();
            this.replacedMSG = new System.Windows.Forms.ToolStripTextBox();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.cms_rtb = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.копироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.saveFD = new System.Windows.Forms.SaveFileDialog();
            this.printFD = new System.Windows.Forms.PrintDialog();
            this.colorTD = new System.Windows.Forms.ColorDialog();
            this.ttHint = new System.Windows.Forms.ToolTip(this.components);
            this.bTBShow = new System.Windows.Forms.Button();
            this.fontDialogRtb = new System.Windows.Forms.FontDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.toolBar.SuspendLayout();
            this.cms_toolBar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.cms_rtb.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBar
            // 
            this.toolBar.ContextMenuStrip = this.cms_toolBar;
            this.toolBar.Controls.Add(this.bExit);
            this.toolBar.Controls.Add(this.bHelp);
            this.toolBar.Controls.Add(this.bCut);
            this.toolBar.Controls.Add(this.bPaste);
            this.toolBar.Controls.Add(this.bCopy);
            this.toolBar.Controls.Add(this.bFileClose);
            this.toolBar.Controls.Add(this.bFileOpen);
            this.toolBar.Controls.Add(this.bFileSave);
            this.toolBar.Controls.Add(this.bFileNew);
            this.toolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolBar.Location = new System.Drawing.Point(0, 33);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(1295, 71);
            this.toolBar.TabIndex = 0;
            // 
            // cms_toolBar
            // 
            this.cms_toolBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cms_toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.скрытьToolStripMenuItem});
            this.cms_toolBar.Name = "cms_TollBar";
            this.cms_toolBar.Size = new System.Drawing.Size(145, 36);
            this.cms_toolBar.Opening += new System.ComponentModel.CancelEventHandler(this.cms_TollBox_Opening);
            // 
            // скрытьToolStripMenuItem
            // 
            this.скрытьToolStripMenuItem.Name = "скрытьToolStripMenuItem";
            this.скрытьToolStripMenuItem.Size = new System.Drawing.Size(144, 32);
            this.скрытьToolStripMenuItem.Text = "Скрыть";
            this.скрытьToolStripMenuItem.Click += new System.EventHandler(this.скрытьToolStripMenuItem_Click);
            // 
            // bExit
            // 
            this.bExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bExit.Image = global::text_editor.Properties.Resources.Exit;
            this.bExit.Location = new System.Drawing.Point(1161, 16);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(40, 40);
            this.bExit.TabIndex = 8;
            this.bExit.Text = " \r\n";
            this.ttHint.SetToolTip(this.bExit, "Выход");
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bHelp
            // 
            this.bHelp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bHelp.Image = global::text_editor.Properties.Resources.QuestionMark;
            this.bHelp.Location = new System.Drawing.Point(1083, 16);
            this.bHelp.Name = "bHelp";
            this.bHelp.Size = new System.Drawing.Size(40, 40);
            this.bHelp.TabIndex = 7;
            this.bHelp.Text = " \r\n";
            this.ttHint.SetToolTip(this.bHelp, "Справка");
            this.bHelp.UseVisualStyleBackColor = true;
            this.bHelp.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // bCut
            // 
            this.bCut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.bCut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCut.Image = global::text_editor.Properties.Resources.Cut;
            this.bCut.Location = new System.Drawing.Point(897, 16);
            this.bCut.Name = "bCut";
            this.bCut.Size = new System.Drawing.Size(40, 40);
            this.bCut.TabIndex = 6;
            this.bCut.Text = " \r\n";
            this.ttHint.SetToolTip(this.bCut, "Вырезать");
            this.bCut.UseVisualStyleBackColor = true;
            this.bCut.Click += new System.EventHandler(this.bCut_Click);
            // 
            // bPaste
            // 
            this.bPaste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.bPaste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bPaste.Image = global::text_editor.Properties.Resources.Paste;
            this.bPaste.Location = new System.Drawing.Point(785, 16);
            this.bPaste.Name = "bPaste";
            this.bPaste.Size = new System.Drawing.Size(40, 40);
            this.bPaste.TabIndex = 5;
            this.bPaste.Text = " \r\n";
            this.ttHint.SetToolTip(this.bPaste, "Вставить");
            this.bPaste.UseVisualStyleBackColor = true;
            this.bPaste.Click += new System.EventHandler(this.bPaste_Click);
            // 
            // bCopy
            // 
            this.bCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.bCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCopy.Image = global::text_editor.Properties.Resources.Copy;
            this.bCopy.Location = new System.Drawing.Point(691, 16);
            this.bCopy.Name = "bCopy";
            this.bCopy.Size = new System.Drawing.Size(40, 40);
            this.bCopy.TabIndex = 4;
            this.bCopy.Text = " \r\n";
            this.ttHint.SetToolTip(this.bCopy, "Копировать");
            this.bCopy.UseVisualStyleBackColor = true;
            this.bCopy.Click += new System.EventHandler(this.bCopy_Click);
            // 
            // bFileClose
            // 
            this.bFileClose.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bFileClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bFileClose.Image = global::text_editor.Properties.Resources.Close;
            this.bFileClose.Location = new System.Drawing.Point(239, 16);
            this.bFileClose.Name = "bFileClose";
            this.bFileClose.Size = new System.Drawing.Size(40, 40);
            this.bFileClose.TabIndex = 3;
            this.bFileClose.Text = " \r\n";
            this.ttHint.SetToolTip(this.bFileClose, "Закрыть ");
            this.bFileClose.UseVisualStyleBackColor = true;
            this.bFileClose.Click += new System.EventHandler(this.bFileClose_Click);
            // 
            // bFileOpen
            // 
            this.bFileOpen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bFileOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bFileOpen.Image = global::text_editor.Properties.Resources.OpenFile1;
            this.bFileOpen.Location = new System.Drawing.Point(170, 16);
            this.bFileOpen.Name = "bFileOpen";
            this.bFileOpen.Size = new System.Drawing.Size(40, 40);
            this.bFileOpen.TabIndex = 2;
            this.bFileOpen.Text = " \r\n";
            this.ttHint.SetToolTip(this.bFileOpen, "Открыть");
            this.bFileOpen.UseVisualStyleBackColor = true;
            this.bFileOpen.Click += new System.EventHandler(this.bFileOpen_Click);
            // 
            // bFileSave
            // 
            this.bFileSave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bFileSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bFileSave.Image = global::text_editor.Properties.Resources.Save;
            this.bFileSave.Location = new System.Drawing.Point(106, 16);
            this.bFileSave.Name = "bFileSave";
            this.bFileSave.Size = new System.Drawing.Size(40, 40);
            this.bFileSave.TabIndex = 1;
            this.bFileSave.Text = " \r\n";
            this.ttHint.SetToolTip(this.bFileSave, "Сохранить");
            this.bFileSave.UseVisualStyleBackColor = true;
            this.bFileSave.Click += new System.EventHandler(this.bFileSave_Click);
            // 
            // bFileNew
            // 
            this.bFileNew.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bFileNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bFileNew.Image = global::text_editor.Properties.Resources.NewDocument;
            this.bFileNew.Location = new System.Drawing.Point(46, 16);
            this.bFileNew.Name = "bFileNew";
            this.bFileNew.Size = new System.Drawing.Size(40, 40);
            this.bFileNew.TabIndex = 0;
            this.ttHint.SetToolTip(this.bFileNew, "Новый файл");
            this.bFileNew.UseVisualStyleBackColor = true;
            this.bFileNew.Click += new System.EventHandler(this.bFileNew_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.видToolStripMenuItem,
            this.редактированиеToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1295, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.закрытьToolStripMenuItem,
            this.закрытьToolStripMenuItem1,
            this.печатьToolStripMenuItem,
            this.toolStripSeparator2,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.bFileOpen_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.bFileSave_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.закрытьToolStripMenuItem.Text = "Создать";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.bFileNew_Click);
            // 
            // закрытьToolStripMenuItem1
            // 
            this.закрытьToolStripMenuItem1.Name = "закрытьToolStripMenuItem1";
            this.закрытьToolStripMenuItem1.Size = new System.Drawing.Size(200, 34);
            this.закрытьToolStripMenuItem1.Text = "Закрыть";
            this.закрытьToolStripMenuItem1.Click += new System.EventHandler(this.bFileClose_Click);
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.печатьToolStripMenuItem.Text = "Печать";
            this.печатьToolStripMenuItem.Click += new System.EventHandler(this.печатьToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(197, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.bExit_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.шрифтToolStripMenuItem,
            this.цветФонаToolStripMenuItem,
            this.цветШрифтаToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(221, 34);
            this.шрифтToolStripMenuItem.Text = "Шрифт";
            this.шрифтToolStripMenuItem.Click += new System.EventHandler(this.шрифтToolStripMenuItem_Click);
            // 
            // цветФонаToolStripMenuItem
            // 
            this.цветФонаToolStripMenuItem.Name = "цветФонаToolStripMenuItem";
            this.цветФонаToolStripMenuItem.Size = new System.Drawing.Size(221, 34);
            this.цветФонаToolStripMenuItem.Text = "Цвет фона";
            this.цветФонаToolStripMenuItem.Click += new System.EventHandler(this.цветФонаToolStripMenuItem_Click);
            // 
            // цветШрифтаToolStripMenuItem
            // 
            this.цветШрифтаToolStripMenuItem.Name = "цветШрифтаToolStripMenuItem";
            this.цветШрифтаToolStripMenuItem.Size = new System.Drawing.Size(221, 34);
            this.цветШрифтаToolStripMenuItem.Text = "Цвет шрифта";
            this.цветШрифтаToolStripMenuItem.Click += new System.EventHandler(this.цветШрифтаToolStripMenuItem_Click);
            // 
            // редактированиеToolStripMenuItem
            // 
            this.редактированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.вырезатьToolStripMenuItem,
            this.найтиToolStripMenuItem,
            this.заменитьToolStripMenuItem});
            this.редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            this.редактированиеToolStripMenuItem.Size = new System.Drawing.Size(162, 29);
            this.редактированиеToolStripMenuItem.Text = "Редактирование";
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.bCopy_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.bPaste_Click);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.bCut_Click);
            // 
            // найтиToolStripMenuItem
            // 
            this.найтиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findMSG});
            this.найтиToolStripMenuItem.Name = "найтиToolStripMenuItem";
            this.найтиToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.найтиToolStripMenuItem.Text = "Найти";
            this.найтиToolStripMenuItem.Click += new System.EventHandler(this.найтиToolStripMenuItem_Click);
            // 
            // findMSG
            // 
            this.findMSG.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.findMSG.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.findMSG.Name = "findMSG";
            this.findMSG.Size = new System.Drawing.Size(200, 31);
            this.findMSG.Text = "Введите искомый текст";
            this.findMSG.Click += new System.EventHandler(this.findMSG_Click);
            // 
            // заменитьToolStripMenuItem
            // 
            this.заменитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.replacingMSG,
            this.replacedMSG});
            this.заменитьToolStripMenuItem.Name = "заменитьToolStripMenuItem";
            this.заменитьToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.заменитьToolStripMenuItem.Text = "Заменить";
            this.заменитьToolStripMenuItem.Click += new System.EventHandler(this.заменитьToolStripMenuItem_Click);
            // 
            // replacingMSG
            // 
            this.replacingMSG.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.replacingMSG.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.replacingMSG.Name = "replacingMSG";
            this.replacingMSG.Size = new System.Drawing.Size(230, 31);
            this.replacingMSG.Text = "Заменяемый текст";
            this.replacingMSG.Click += new System.EventHandler(this.findMSG_Click);
            // 
            // replacedMSG
            // 
            this.replacedMSG.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.replacedMSG.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.replacedMSG.Name = "replacedMSG";
            this.replacedMSG.Size = new System.Drawing.Size(230, 31);
            this.replacedMSG.Text = "Заменить на";
            this.replacedMSG.Click += new System.EventHandler(this.findMSG_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // rtbText
            // 
            this.rtbText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbText.ContextMenuStrip = this.cms_rtb;
            this.rtbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbText.Location = new System.Drawing.Point(0, 104);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(1295, 680);
            this.rtbText.TabIndex = 2;
            this.rtbText.Text = "";
            this.rtbText.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // cms_rtb
            // 
            this.cms_rtb.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cms_rtb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem1,
            this.вставитьToolStripMenuItem1,
            this.вырезатьToolStripMenuItem1});
            this.cms_rtb.Name = "cms_rtb";
            this.cms_rtb.Size = new System.Drawing.Size(183, 100);
            // 
            // копироватьToolStripMenuItem1
            // 
            this.копироватьToolStripMenuItem1.Name = "копироватьToolStripMenuItem1";
            this.копироватьToolStripMenuItem1.Size = new System.Drawing.Size(182, 32);
            this.копироватьToolStripMenuItem1.Text = "Копировать";
            this.копироватьToolStripMenuItem1.Click += new System.EventHandler(this.bCopy_Click);
            // 
            // вставитьToolStripMenuItem1
            // 
            this.вставитьToolStripMenuItem1.Name = "вставитьToolStripMenuItem1";
            this.вставитьToolStripMenuItem1.Size = new System.Drawing.Size(182, 32);
            this.вставитьToolStripMenuItem1.Text = "Вставить";
            this.вставитьToolStripMenuItem1.Click += new System.EventHandler(this.bPaste_Click);
            // 
            // вырезатьToolStripMenuItem1
            // 
            this.вырезатьToolStripMenuItem1.Name = "вырезатьToolStripMenuItem1";
            this.вырезатьToolStripMenuItem1.Size = new System.Drawing.Size(182, 32);
            this.вырезатьToolStripMenuItem1.Text = "Вырезать";
            this.вырезатьToolStripMenuItem1.Click += new System.EventHandler(this.bCut_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 752);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1295, 32);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(117, 25);
            this.toolStripStatusLabel1.Text = "Безымянный";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 25);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 25);
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            this.openFD.Filter = "RTF файлы|*.rtf";
            this.openFD.FileOk += new System.ComponentModel.CancelEventHandler(this.openFD_FileOk);
            // 
            // saveFD
            // 
            this.saveFD.FileName = "Безымянный";
            this.saveFD.Filter = "RTF файлы|*.rtf";
            // 
            // printFD
            // 
            this.printFD.UseEXDialog = true;
            // 
            // bTBShow
            // 
            this.bTBShow.Image = global::text_editor.Properties.Resources.Download;
            this.bTBShow.Location = new System.Drawing.Point(1234, 0);
            this.bTBShow.Name = "bTBShow";
            this.bTBShow.Size = new System.Drawing.Size(61, 33);
            this.bTBShow.TabIndex = 4;
            this.ttHint.SetToolTip(this.bTBShow, "Отобразить панель иструментов");
            this.bTBShow.UseVisualStyleBackColor = true;
            this.bTBShow.Visible = false;
            this.bTBShow.Click += new System.EventHandler(this.bTBShow_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 784);
            this.Controls.Add(this.bTBShow);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "gi";
            this.toolBar.ResumeLayout(false);
            this.cms_toolBar.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cms_rtb.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel toolBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветФонаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиToolStripMenuItem;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bHelp;
        private System.Windows.Forms.Button bCut;
        private System.Windows.Forms.Button bPaste;
        private System.Windows.Forms.Button bCopy;
        private System.Windows.Forms.Button bFileClose;
        private System.Windows.Forms.Button bFileOpen;
        private System.Windows.Forms.Button bFileSave;
        private System.Windows.Forms.Button bFileNew;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.SaveFileDialog saveFD;
        private System.Windows.Forms.ContextMenuStrip cms_rtb;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip cms_toolBar;
        private System.Windows.Forms.ToolStripMenuItem скрытьToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printFD;
        private System.Windows.Forms.ColorDialog colorTD;
        private System.Windows.Forms.ToolTip ttHint;
        private System.Windows.Forms.Button bTBShow;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.FontDialog fontDialogRtb;
        private System.Windows.Forms.ToolStripMenuItem цветШрифтаToolStripMenuItem;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ToolStripTextBox findMSG;
        private System.Windows.Forms.ToolStripMenuItem заменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox replacingMSG;
        private System.Windows.Forms.ToolStripTextBox replacedMSG;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

