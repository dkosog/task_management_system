namespace TaskManager
{
  partial class CreateTaskForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.priorityNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.label6 = new System.Windows.Forms.Label();
      this.createTaskButton = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.usersCheckedListBox = new System.Windows.Forms.CheckedListBox();
      this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.titleTextBox = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.cancelButton = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.priorityNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
      this.SuspendLayout();
      // 
      // priorityNumericUpDown
      // 
      this.priorityNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.priorityNumericUpDown.Location = new System.Drawing.Point(226, 192);
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
      this.priorityNumericUpDown.Size = new System.Drawing.Size(113, 27);
      this.priorityNumericUpDown.TabIndex = 42;
      this.priorityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label6.Location = new System.Drawing.Point(222, 169);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(102, 20);
      this.label6.TabIndex = 41;
      this.label6.Text = "Приоритет";
      // 
      // createTaskButton
      // 
      this.createTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.createTaskButton.Location = new System.Drawing.Point(16, 387);
      this.createTaskButton.Name = "createTaskButton";
      this.createTaskButton.Size = new System.Drawing.Size(194, 40);
      this.createTaskButton.TabIndex = 40;
      this.createTaskButton.Text = "Создать";
      this.createTaskButton.UseVisualStyleBackColor = true;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label5.Location = new System.Drawing.Point(12, 222);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(143, 20);
      this.label5.TabIndex = 39;
      this.label5.Text = "Ответственные";
      // 
      // usersCheckedListBox
      // 
      this.usersCheckedListBox.CheckOnClick = true;
      this.usersCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.usersCheckedListBox.FormattingEnabled = true;
      this.usersCheckedListBox.Items.AddRange(new object[] {
            "Имя1",
            "Имя2",
            "Имя3",
            "Имя4",
            "Имя5"});
      this.usersCheckedListBox.Location = new System.Drawing.Point(16, 245);
      this.usersCheckedListBox.Name = "usersCheckedListBox";
      this.usersCheckedListBox.Size = new System.Drawing.Size(323, 136);
      this.usersCheckedListBox.TabIndex = 38;
      // 
      // descriptionTextBox
      // 
      this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.descriptionTextBox.Location = new System.Drawing.Point(16, 85);
      this.descriptionTextBox.Name = "descriptionTextBox";
      this.descriptionTextBox.Size = new System.Drawing.Size(323, 80);
      this.descriptionTextBox.TabIndex = 33;
      this.descriptionTextBox.Text = "";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(12, 62);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(91, 20);
      this.label2.TabIndex = 32;
      this.label2.Text = "Описание";
      // 
      // titleTextBox
      // 
      this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.titleTextBox.Location = new System.Drawing.Point(16, 32);
      this.titleTextBox.Name = "titleTextBox";
      this.titleTextBox.Size = new System.Drawing.Size(323, 27);
      this.titleTextBox.TabIndex = 31;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(98, 20);
      this.label1.TabIndex = 30;
      this.label1.Text = "Заголовок";
      // 
      // cancelButton
      // 
      this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.cancelButton.Location = new System.Drawing.Point(216, 387);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(123, 40);
      this.cancelButton.TabIndex = 43;
      this.cancelButton.Text = "Отмена";
      this.cancelButton.UseVisualStyleBackColor = true;
      this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(12, 169);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(184, 20);
      this.label3.TabIndex = 44;
      this.label3.Text = "Дней на выполнение";
      // 
      // numericUpDown1
      // 
      this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.numericUpDown1.Location = new System.Drawing.Point(16, 192);
      this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.numericUpDown1.Name = "numericUpDown1";
      this.numericUpDown1.Size = new System.Drawing.Size(204, 27);
      this.numericUpDown1.TabIndex = 45;
      this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // CreateTaskForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(358, 439);
      this.Controls.Add(this.numericUpDown1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.cancelButton);
      this.Controls.Add(this.priorityNumericUpDown);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.createTaskButton);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.usersCheckedListBox);
      this.Controls.Add(this.descriptionTextBox);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.titleTextBox);
      this.Controls.Add(this.label1);
      this.MaximizeBox = false;
      this.Name = "CreateTaskForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Создание задачи";
      ((System.ComponentModel.ISupportInitialize)(this.priorityNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.NumericUpDown priorityNumericUpDown;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button createTaskButton;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.CheckedListBox usersCheckedListBox;
    private System.Windows.Forms.RichTextBox descriptionTextBox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox titleTextBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button cancelButton;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.NumericUpDown numericUpDown1;
  }
}