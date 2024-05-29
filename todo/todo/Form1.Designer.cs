namespace TodoApp1
{
    partial class dueDateTimePicker
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.taskContentTextBox = new System.Windows.Forms.TextBox();
            this.inputDateTextBox = new System.Windows.Forms.TextBox();
            this.dueDateTextBox = new System.Windows.Forms.TextBox();
            this.openButton = new System.Windows.Forms.Button();
            this.tasksListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lable2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(67, 93);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(99, 51);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "追加";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(190, 92);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(100, 52);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "修正";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(326, 92);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(122, 52);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "削除";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(67, 179);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(381, 195);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(248, 418);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // taskContentTextBox
            // 
            this.taskContentTextBox.Location = new System.Drawing.Point(107, 522);
            this.taskContentTextBox.Multiline = true;
            this.taskContentTextBox.Name = "taskContentTextBox";
            this.taskContentTextBox.Size = new System.Drawing.Size(358, 167);
            this.taskContentTextBox.TabIndex = 5;
            // 
            // inputDateTextBox
            // 
            this.inputDateTextBox.Location = new System.Drawing.Point(340, 722);
            this.inputDateTextBox.Name = "inputDateTextBox";
            this.inputDateTextBox.Size = new System.Drawing.Size(100, 31);
            this.inputDateTextBox.TabIndex = 6;
            // 
            // dueDateTextBox
            // 
            this.dueDateTextBox.Location = new System.Drawing.Point(340, 777);
            this.dueDateTextBox.Name = "dueDateTextBox";
            this.dueDateTextBox.Size = new System.Drawing.Size(100, 31);
            this.dueDateTextBox.TabIndex = 7;
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(1087, 92);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(135, 34);
            this.openButton.TabIndex = 8;
            this.openButton.Text = "開く";
            this.openButton.UseVisualStyleBackColor = true;
            // 
            // tasksListBox
            // 
            this.tasksListBox.FormattingEnabled = true;
            this.tasksListBox.ItemHeight = 24;
            this.tasksListBox.Location = new System.Drawing.Point(801, 168);
            this.tasksListBox.Name = "tasksListBox";
            this.tasksListBox.Size = new System.Drawing.Size(488, 604);
            this.tasksListBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 728);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "入力日";
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Location = new System.Drawing.Point(241, 783);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(58, 24);
            this.lable2.TabIndex = 11;
            this.lable2.Text = "期日";
            // 
            // dueDateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 969);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tasksListBox);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.dueDateTextBox);
            this.Controls.Add(this.inputDateTextBox);
            this.Controls.Add(this.taskContentTextBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Name = "dueDateTimePicker";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox taskContentTextBox;
        private System.Windows.Forms.TextBox inputDateTextBox;
        private System.Windows.Forms.TextBox dueDateTextBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.ListBox tasksListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable2;
    }
}

