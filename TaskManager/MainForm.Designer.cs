namespace TaskManager
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
      System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Не в работе", System.Windows.Forms.HorizontalAlignment.Left);
      System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("В работе", System.Windows.Forms.HorizontalAlignment.Left);
      System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("На проверке", System.Windows.Forms.HorizontalAlignment.Left);
      System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Завершена", System.Windows.Forms.HorizontalAlignment.Left);
      this.tabMenu = new System.Windows.Forms.TabControl();
      this.tasksTabPage = new System.Windows.Forms.TabPage();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.richTextBox2 = new System.Windows.Forms.RichTextBox();
      this.sendCommentButton = new System.Windows.Forms.Button();
      this.sendCommentTextBox = new System.Windows.Forms.TextBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.upStatusButton = new System.Windows.Forms.Button();
      this.deleteTasksButton = new System.Windows.Forms.Button();
      this.downStatusButton = new System.Windows.Forms.Button();
      this.tasksListView = new System.Windows.Forms.ListView();
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.button5 = new System.Windows.Forms.Button();
      this.createTaskTabPage = new System.Windows.Forms.TabPage();
      this.priorityNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.label6 = new System.Windows.Forms.Label();
      this.createTaskButton = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.usersCheckedListBox = new System.Windows.Forms.CheckedListBox();
      this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
      this.label4 = new System.Windows.Forms.Label();
      this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
      this.label3 = new System.Windows.Forms.Label();
      this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.titleTextBox = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.tabMenu.SuspendLayout();
      this.tasksTabPage.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.createTaskTabPage.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.priorityNumericUpDown)).BeginInit();
      this.SuspendLayout();
      // 
      // tabMenu
      // 
      this.tabMenu.Controls.Add(this.tasksTabPage);
      this.tabMenu.Controls.Add(this.createTaskTabPage);
      this.tabMenu.Controls.Add(this.tabPage1);
      this.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.tabMenu.Location = new System.Drawing.Point(0, 0);
      this.tabMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.tabMenu.Name = "tabMenu";
      this.tabMenu.SelectedIndex = 0;
      this.tabMenu.Size = new System.Drawing.Size(830, 413);
      this.tabMenu.TabIndex = 0;
      // 
      // tasksTabPage
      // 
      this.tasksTabPage.Controls.Add(this.groupBox1);
      this.tasksTabPage.Controls.Add(this.groupBox2);
      this.tasksTabPage.Controls.Add(this.tasksListView);
      this.tasksTabPage.Controls.Add(this.button5);
      this.tasksTabPage.Location = new System.Drawing.Point(4, 26);
      this.tasksTabPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.tasksTabPage.Name = "tasksTabPage";
      this.tasksTabPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.tasksTabPage.Size = new System.Drawing.Size(822, 383);
      this.tasksTabPage.TabIndex = 0;
      this.tasksTabPage.Text = "Задачи";
      this.tasksTabPage.UseVisualStyleBackColor = true;
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.richTextBox2);
      this.groupBox1.Controls.Add(this.sendCommentButton);
      this.groupBox1.Controls.Add(this.sendCommentTextBox);
      this.groupBox1.Location = new System.Drawing.Point(630, 4);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.groupBox1.Size = new System.Drawing.Size(190, 183);
      this.groupBox1.TabIndex = 26;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Коментарии к задаче";
      // 
      // richTextBox2
      // 
      this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.richTextBox2.Location = new System.Drawing.Point(4, 21);
      this.richTextBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.richTextBox2.Name = "richTextBox2";
      this.richTextBox2.Size = new System.Drawing.Size(182, 93);
      this.richTextBox2.TabIndex = 22;
      this.richTextBox2.Text = "";
      // 
      // sendCommentButton
      // 
      this.sendCommentButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.sendCommentButton.Location = new System.Drawing.Point(4, 145);
      this.sendCommentButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.sendCommentButton.Name = "sendCommentButton";
      this.sendCommentButton.Size = new System.Drawing.Size(181, 32);
      this.sendCommentButton.TabIndex = 25;
      this.sendCommentButton.Text = "Отправить";
      this.sendCommentButton.UseVisualStyleBackColor = true;
      this.sendCommentButton.Click += new System.EventHandler(this.sendCommentButton_Click);
      // 
      // sendCommentTextBox
      // 
      this.sendCommentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.sendCommentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.sendCommentTextBox.Location = new System.Drawing.Point(4, 119);
      this.sendCommentTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.sendCommentTextBox.Name = "sendCommentTextBox";
      this.sendCommentTextBox.Size = new System.Drawing.Size(181, 23);
      this.sendCommentTextBox.TabIndex = 24;
      // 
      // groupBox2
      // 
      this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox2.Controls.Add(this.upStatusButton);
      this.groupBox2.Controls.Add(this.deleteTasksButton);
      this.groupBox2.Controls.Add(this.downStatusButton);
      this.groupBox2.Location = new System.Drawing.Point(630, 192);
      this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.groupBox2.Size = new System.Drawing.Size(190, 133);
      this.groupBox2.TabIndex = 27;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Опции с выделенными";
      // 
      // upStatusButton
      // 
      this.upStatusButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.upStatusButton.Location = new System.Drawing.Point(4, 21);
      this.upStatusButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.upStatusButton.Name = "upStatusButton";
      this.upStatusButton.Size = new System.Drawing.Size(181, 32);
      this.upStatusButton.TabIndex = 16;
      this.upStatusButton.Text = "Выше";
      this.upStatusButton.UseVisualStyleBackColor = true;
      this.upStatusButton.Click += new System.EventHandler(this.upStatusButton_Click);
      // 
      // deleteTasksButton
      // 
      this.deleteTasksButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.deleteTasksButton.Location = new System.Drawing.Point(4, 96);
      this.deleteTasksButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.deleteTasksButton.Name = "deleteTasksButton";
      this.deleteTasksButton.Size = new System.Drawing.Size(181, 32);
      this.deleteTasksButton.TabIndex = 15;
      this.deleteTasksButton.Text = "Удалить";
      this.deleteTasksButton.UseVisualStyleBackColor = true;
      this.deleteTasksButton.Click += new System.EventHandler(this.deleteTasksButton_Click);
      // 
      // downStatusButton
      // 
      this.downStatusButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.downStatusButton.Location = new System.Drawing.Point(4, 58);
      this.downStatusButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.downStatusButton.Name = "downStatusButton";
      this.downStatusButton.Size = new System.Drawing.Size(181, 32);
      this.downStatusButton.TabIndex = 17;
      this.downStatusButton.Text = "Ниже";
      this.downStatusButton.UseVisualStyleBackColor = true;
      this.downStatusButton.Click += new System.EventHandler(this.downStatusButton_Click);
      // 
      // tasksListView
      // 
      this.tasksListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tasksListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader6,
            this.columnHeader4,
            this.columnHeader5});
      listViewGroup1.Header = "Не в работе";
      listViewGroup1.Name = "listViewGroup1";
      listViewGroup2.Header = "В работе";
      listViewGroup2.Name = "listViewGroup2";
      listViewGroup3.Header = "На проверке";
      listViewGroup3.Name = "listViewGroup3";
      listViewGroup4.Header = "Завершена";
      listViewGroup4.Name = "listViewGroup4";
      this.tasksListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4});
      this.tasksListView.HideSelection = false;
      this.tasksListView.Location = new System.Drawing.Point(4, 4);
      this.tasksListView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.tasksListView.Name = "tasksListView";
      this.tasksListView.ShowItemToolTips = true;
      this.tasksListView.Size = new System.Drawing.Size(622, 379);
      this.tasksListView.TabIndex = 0;
      this.tasksListView.UseCompatibleStateImageBehavior = false;
      this.tasksListView.View = System.Windows.Forms.View.Details;
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "Заголовок";
      this.columnHeader1.Width = 120;
      // 
      // columnHeader6
      // 
      this.columnHeader6.Text = "Осталось дней";
      this.columnHeader6.Width = 156;
      // 
      // columnHeader4
      // 
      this.columnHeader4.Text = "Приоритет";
      this.columnHeader4.Width = 116;
      // 
      // columnHeader5
      // 
      this.columnHeader5.Text = "Ответственные";
      this.columnHeader5.Width = 192;
      // 
      // button5
      // 
      this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.button5.Location = new System.Drawing.Point(630, 349);
      this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(190, 32);
      this.button5.TabIndex = 20;
      this.button5.Text = "Выход из программы";
      this.button5.UseVisualStyleBackColor = true;
      // 
      // createTaskTabPage
      // 
      this.createTaskTabPage.Controls.Add(this.priorityNumericUpDown);
      this.createTaskTabPage.Controls.Add(this.label6);
      this.createTaskTabPage.Controls.Add(this.createTaskButton);
      this.createTaskTabPage.Controls.Add(this.label5);
      this.createTaskTabPage.Controls.Add(this.usersCheckedListBox);
      this.createTaskTabPage.Controls.Add(this.endDateTimePicker);
      this.createTaskTabPage.Controls.Add(this.label4);
      this.createTaskTabPage.Controls.Add(this.startDateTimePicker);
      this.createTaskTabPage.Controls.Add(this.label3);
      this.createTaskTabPage.Controls.Add(this.descriptionTextBox);
      this.createTaskTabPage.Controls.Add(this.label2);
      this.createTaskTabPage.Controls.Add(this.titleTextBox);
      this.createTaskTabPage.Controls.Add(this.label1);
      this.createTaskTabPage.Location = new System.Drawing.Point(4, 26);
      this.createTaskTabPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.createTaskTabPage.Name = "createTaskTabPage";
      this.createTaskTabPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.createTaskTabPage.Size = new System.Drawing.Size(822, 383);
      this.createTaskTabPage.TabIndex = 1;
      this.createTaskTabPage.Text = "Создание задачи";
      this.createTaskTabPage.UseVisualStyleBackColor = true;
      // 
      // priorityNumericUpDown
      // 
      this.priorityNumericUpDown.Location = new System.Drawing.Point(169, 20);
      this.priorityNumericUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.priorityNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
      this.priorityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.priorityNumericUpDown.Name = "priorityNumericUpDown";
      this.priorityNumericUpDown.Size = new System.Drawing.Size(85, 23);
      this.priorityNumericUpDown.TabIndex = 29;
      this.priorityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(166, 2);
      this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(80, 17);
      this.label6.TabIndex = 27;
      this.label6.Text = "Приоритет";
      // 
      // createTaskButton
      // 
      this.createTaskButton.Location = new System.Drawing.Point(390, 96);
      this.createTaskButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.createTaskButton.Name = "createTaskButton";
      this.createTaskButton.Size = new System.Drawing.Size(150, 32);
      this.createTaskButton.TabIndex = 26;
      this.createTaskButton.Text = "Создать";
      this.createTaskButton.UseVisualStyleBackColor = true;
      this.createTaskButton.Click += new System.EventHandler(this.createTaskButton_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(255, 2);
      this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(111, 17);
      this.label5.TabIndex = 10;
      this.label5.Text = "Ответственные";
      // 
      // usersCheckedListBox
      // 
      this.usersCheckedListBox.CheckOnClick = true;
      this.usersCheckedListBox.FormattingEnabled = true;
      this.usersCheckedListBox.Items.AddRange(new object[] {
            "Имя1",
            "Имя2",
            "Имя3",
            "Имя4",
            "Имя5"});
      this.usersCheckedListBox.Location = new System.Drawing.Point(258, 20);
      this.usersCheckedListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.usersCheckedListBox.Name = "usersCheckedListBox";
      this.usersCheckedListBox.Size = new System.Drawing.Size(126, 94);
      this.usersCheckedListBox.TabIndex = 9;
      // 
      // endDateTimePicker
      // 
      this.endDateTimePicker.Location = new System.Drawing.Point(390, 63);
      this.endDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.endDateTimePicker.Name = "endDateTimePicker";
      this.endDateTimePicker.Size = new System.Drawing.Size(151, 23);
      this.endDateTimePicker.TabIndex = 8;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(387, 45);
      this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(127, 17);
      this.label4.TabIndex = 7;
      this.label4.Text = "Дата завершения";
      // 
      // startDateTimePicker
      // 
      this.startDateTimePicker.Location = new System.Drawing.Point(390, 20);
      this.startDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.startDateTimePicker.Name = "startDateTimePicker";
      this.startDateTimePicker.Size = new System.Drawing.Size(151, 23);
      this.startDateTimePicker.TabIndex = 6;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(387, 2);
      this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(94, 17);
      this.label3.TabIndex = 5;
      this.label3.Text = "Дата начала";
      // 
      // descriptionTextBox
      // 
      this.descriptionTextBox.Location = new System.Drawing.Point(8, 63);
      this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.descriptionTextBox.Name = "descriptionTextBox";
      this.descriptionTextBox.Size = new System.Drawing.Size(247, 66);
      this.descriptionTextBox.TabIndex = 4;
      this.descriptionTextBox.Text = "";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(4, 45);
      this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(74, 17);
      this.label2.TabIndex = 3;
      this.label2.Text = "Описание";
      // 
      // titleTextBox
      // 
      this.titleTextBox.Location = new System.Drawing.Point(8, 20);
      this.titleTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.titleTextBox.Name = "titleTextBox";
      this.titleTextBox.Size = new System.Drawing.Size(158, 23);
      this.titleTextBox.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(4, 2);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(76, 17);
      this.label1.TabIndex = 1;
      this.label1.Text = "Заголовок";
      // 
      // tabPage1
      // 
      this.tabPage1.Location = new System.Drawing.Point(4, 26);
      this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.tabPage1.Size = new System.Drawing.Size(822, 383);
      this.tabPage1.TabIndex = 2;
      this.tabPage1.Text = "Пользователи";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(830, 413);
      this.Controls.Add(this.tabMenu);
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.Name = "MainForm";
      this.Text = "TaskManager";
      this.tabMenu.ResumeLayout(false);
      this.tasksTabPage.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.createTaskTabPage.ResumeLayout(false);
      this.createTaskTabPage.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.priorityNumericUpDown)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabMenu;
    private System.Windows.Forms.TabPage tasksTabPage;
    private System.Windows.Forms.TabPage createTaskTabPage;
    private System.Windows.Forms.ListView tasksListView;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader4;
    private System.Windows.Forms.ColumnHeader columnHeader5;
    private System.Windows.Forms.Button deleteTasksButton;
    private System.Windows.Forms.Button downStatusButton;
    private System.Windows.Forms.Button upStatusButton;
    private System.Windows.Forms.ColumnHeader columnHeader6;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TextBox titleTextBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.CheckedListBox usersCheckedListBox;
    private System.Windows.Forms.DateTimePicker endDateTimePicker;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.DateTimePicker startDateTimePicker;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.RichTextBox descriptionTextBox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.RichTextBox richTextBox2;
    private System.Windows.Forms.Button sendCommentButton;
    private System.Windows.Forms.TextBox sendCommentTextBox;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button createTaskButton;
    private System.Windows.Forms.NumericUpDown priorityNumericUpDown;
  }
}

