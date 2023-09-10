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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tasksTabPage = new System.Windows.Forms.TabPage();
            this.tasksListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.createTaskToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.upStatusToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.downStatusToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteTaskToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CreateReportToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.TasksFormToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabMenu.SuspendLayout();
            this.tasksTabPage.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tasksTabPage);
            this.tabMenu.Controls.Add(this.tabPage1);
            this.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabMenu.Location = new System.Drawing.Point(0, 0);
            this.tabMenu.Margin = new System.Windows.Forms.Padding(2);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(830, 413);
            this.tabMenu.TabIndex = 0;
            // 
            // tasksTabPage
            // 
            this.tasksTabPage.Controls.Add(this.tasksListView);
            this.tasksTabPage.Controls.Add(this.toolStrip);
            this.tasksTabPage.Location = new System.Drawing.Point(4, 26);
            this.tasksTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.tasksTabPage.Name = "tasksTabPage";
            this.tasksTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.tasksTabPage.Size = new System.Drawing.Size(822, 383);
            this.tasksTabPage.TabIndex = 0;
            this.tasksTabPage.Text = "Задачи";
            this.tasksTabPage.UseVisualStyleBackColor = true;
            // 
            // tasksListView
            // 
            this.tasksListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.tasksListView.AllowColumnReorder = true;
            this.tasksListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader6,
            this.columnHeader4,
            this.columnHeader5});
            this.tasksListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tasksListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.tasksListView.Location = new System.Drawing.Point(2, 27);
            this.tasksListView.Margin = new System.Windows.Forms.Padding(2);
            this.tasksListView.Name = "tasksListView";
            this.tasksListView.ShowItemToolTips = true;
            this.tasksListView.Size = new System.Drawing.Size(818, 354);
            this.tasksListView.TabIndex = 0;
            this.tasksListView.UseCompatibleStateImageBehavior = false;
            this.tasksListView.View = System.Windows.Forms.View.Details;
            this.tasksListView.SelectedIndexChanged += new System.EventHandler(this.tasksListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Заголовок";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Дней на исполнение";
            this.columnHeader6.Width = 197;
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
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createTaskToolStripButton,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.upStatusToolStripButton,
            this.downStatusToolStripButton,
            this.deleteTaskToolStripButton,
            this.CreateReportToolStripButton,
            this.TasksFormToolStripButton});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip.Location = new System.Drawing.Point(2, 2);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(818, 25);
            this.toolStrip.TabIndex = 29;
            this.toolStrip.Text = "toolStrip";
            // 
            // createTaskToolStripButton
            // 
            this.createTaskToolStripButton.AutoToolTip = false;
            this.createTaskToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.createTaskToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("createTaskToolStripButton.Image")));
            this.createTaskToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createTaskToolStripButton.Name = "createTaskToolStripButton";
            this.createTaskToolStripButton.Size = new System.Drawing.Size(54, 22);
            this.createTaskToolStripButton.Text = "Создать";
            this.createTaskToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.createTaskToolStripButton.Click += new System.EventHandler(this.createTaskToolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoToolTip = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(43, 22);
            this.toolStripButton1.Text = "Отчет";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // upStatusToolStripButton
            // 
            this.upStatusToolStripButton.AutoToolTip = false;
            this.upStatusToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.upStatusToolStripButton.Enabled = false;
            this.upStatusToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("upStatusToolStripButton.Image")));
            this.upStatusToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.upStatusToolStripButton.Name = "upStatusToolStripButton";
            this.upStatusToolStripButton.Size = new System.Drawing.Size(44, 22);
            this.upStatusToolStripButton.Text = "Выше";
            this.upStatusToolStripButton.Click += new System.EventHandler(this.upStatusToolStripButton_Click);
            // 
            // downStatusToolStripButton
            // 
            this.downStatusToolStripButton.AutoToolTip = false;
            this.downStatusToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.downStatusToolStripButton.Enabled = false;
            this.downStatusToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("downStatusToolStripButton.Image")));
            this.downStatusToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.downStatusToolStripButton.Name = "downStatusToolStripButton";
            this.downStatusToolStripButton.Size = new System.Drawing.Size(42, 22);
            this.downStatusToolStripButton.Text = "Ниже";
            this.downStatusToolStripButton.Click += new System.EventHandler(this.downStatusToolStripButton_Click);
            // 
            // deleteTaskToolStripButton
            // 
            this.deleteTaskToolStripButton.AutoToolTip = false;
            this.deleteTaskToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteTaskToolStripButton.Enabled = false;
            this.deleteTaskToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteTaskToolStripButton.Image")));
            this.deleteTaskToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteTaskToolStripButton.Name = "deleteTaskToolStripButton";
            this.deleteTaskToolStripButton.Size = new System.Drawing.Size(55, 22);
            this.deleteTaskToolStripButton.Text = "Удалить";
            this.deleteTaskToolStripButton.Click += new System.EventHandler(this.deleteTaskToolStripButton_Click);
            // 
            // CreateReportToolStripButton
            // 
            this.CreateReportToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CreateReportToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("CreateReportToolStripButton.Image")));
            this.CreateReportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreateReportToolStripButton.Name = "CreateReportToolStripButton";
            this.CreateReportToolStripButton.Size = new System.Drawing.Size(87, 22);
            this.CreateReportToolStripButton.Text = "Создать отчет";
            this.CreateReportToolStripButton.Click += new System.EventHandler(this.CreateReportToolStripButton_Click);
            // 
            // TasksFormToolStripButton
            // 
            this.TasksFormToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TasksFormToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("TasksFormToolStripButton.Image")));
            this.TasksFormToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TasksFormToolStripButton.Name = "TasksFormToolStripButton";
            this.TasksFormToolStripButton.Size = new System.Drawing.Size(83, 22);
            this.TasksFormToolStripButton.Text = "Задачи из БД";
            this.TasksFormToolStripButton.Click += new System.EventHandler(this.TasksFormToolStripButton_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Система управления задачами";
            this.tabMenu.ResumeLayout(false);
            this.tasksTabPage.ResumeLayout(false);
            this.tasksTabPage.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabMenu;
    private System.Windows.Forms.TabPage tasksTabPage;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.ToolStrip toolStrip;
    private System.Windows.Forms.ToolStripButton createTaskToolStripButton;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton upStatusToolStripButton;
    private System.Windows.Forms.ToolStripButton downStatusToolStripButton;
    private System.Windows.Forms.ToolStripButton deleteTaskToolStripButton;
    private System.Windows.Forms.ListView tasksListView;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader6;
    private System.Windows.Forms.ColumnHeader columnHeader4;
    private System.Windows.Forms.ColumnHeader columnHeader5;
    private System.Windows.Forms.ToolStripButton toolStripButton1;
    private System.Windows.Forms.ToolStripButton CreateReportToolStripButton;
    private System.Windows.Forms.ToolStripButton TasksFormToolStripButton;
    }
}

