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
      System.Windows.Forms.ListViewGroup listViewGroup9 = new System.Windows.Forms.ListViewGroup("Не в работе", System.Windows.Forms.HorizontalAlignment.Left);
      System.Windows.Forms.ListViewGroup listViewGroup10 = new System.Windows.Forms.ListViewGroup("В работе", System.Windows.Forms.HorizontalAlignment.Left);
      System.Windows.Forms.ListViewGroup listViewGroup11 = new System.Windows.Forms.ListViewGroup("На проверке", System.Windows.Forms.HorizontalAlignment.Left);
      System.Windows.Forms.ListViewGroup listViewGroup12 = new System.Windows.Forms.ListViewGroup("Завершена", System.Windows.Forms.HorizontalAlignment.Left);
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
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.upStatusToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.downStatusToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.deleteTaskToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
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
      this.tabMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tabMenu.Name = "tabMenu";
      this.tabMenu.SelectedIndex = 0;
      this.tabMenu.Size = new System.Drawing.Size(1107, 508);
      this.tabMenu.TabIndex = 0;
      // 
      // tasksTabPage
      // 
      this.tasksTabPage.Controls.Add(this.tasksListView);
      this.tasksTabPage.Controls.Add(this.toolStrip);
      this.tasksTabPage.Location = new System.Drawing.Point(4, 29);
      this.tasksTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tasksTabPage.Name = "tasksTabPage";
      this.tasksTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tasksTabPage.Size = new System.Drawing.Size(1099, 475);
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
      listViewGroup9.Header = "Не в работе";
      listViewGroup9.Name = "listViewGroup1";
      listViewGroup10.Header = "В работе";
      listViewGroup10.Name = "listViewGroup2";
      listViewGroup11.Header = "На проверке";
      listViewGroup11.Name = "listViewGroup3";
      listViewGroup12.Header = "Завершена";
      listViewGroup12.Name = "listViewGroup4";
      this.tasksListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup9,
            listViewGroup10,
            listViewGroup11,
            listViewGroup12});
      this.tasksListView.HideSelection = false;
      this.tasksListView.Location = new System.Drawing.Point(3, 29);
      this.tasksListView.Name = "tasksListView";
      this.tasksListView.ShowItemToolTips = true;
      this.tasksListView.Size = new System.Drawing.Size(1093, 444);
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
            this.deleteTaskToolStripButton});
      this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
      this.toolStrip.Location = new System.Drawing.Point(3, 2);
      this.toolStrip.Name = "toolStrip";
      this.toolStrip.Size = new System.Drawing.Size(1093, 27);
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
      this.createTaskToolStripButton.Size = new System.Drawing.Size(68, 24);
      this.createTaskToolStripButton.Text = "Создать";
      this.createTaskToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
      this.createTaskToolStripButton.Click += new System.EventHandler(this.createTaskToolStripButton_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
      // 
      // upStatusToolStripButton
      // 
      this.upStatusToolStripButton.AutoToolTip = false;
      this.upStatusToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.upStatusToolStripButton.Enabled = false;
      this.upStatusToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("upStatusToolStripButton.Image")));
      this.upStatusToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.upStatusToolStripButton.Name = "upStatusToolStripButton";
      this.upStatusToolStripButton.Size = new System.Drawing.Size(53, 24);
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
      this.downStatusToolStripButton.Size = new System.Drawing.Size(52, 24);
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
      this.deleteTaskToolStripButton.Size = new System.Drawing.Size(69, 24);
      this.deleteTaskToolStripButton.Text = "Удалить";
      this.deleteTaskToolStripButton.Click += new System.EventHandler(this.deleteTaskToolStripButton_Click);
      // 
      // tabPage1
      // 
      this.tabPage1.Location = new System.Drawing.Point(4, 29);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(1099, 475);
      this.tabPage1.TabIndex = 2;
      this.tabPage1.Text = "Пользователи";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // toolStripButton1
      // 
      this.toolStripButton1.AutoToolTip = false;
      this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
      this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButton1.Name = "toolStripButton1";
      this.toolStripButton1.Size = new System.Drawing.Size(52, 24);
      this.toolStripButton1.Text = "Отчет";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1107, 508);
      this.Controls.Add(this.tabMenu);
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
  }
}

