namespace MyToDoApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NewTaskTbx = new TextBox();
            AddTaskBtn = new Button();
            TasksLbx = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // NewTaskTbx
            // 
            NewTaskTbx.Location = new Point(26, 67);
            NewTaskTbx.Margin = new Padding(6);
            NewTaskTbx.Name = "NewTaskTbx";
            NewTaskTbx.Size = new Size(231, 43);
            NewTaskTbx.TabIndex = 0;
            // 
            // AddTaskBtn
            // 
            AddTaskBtn.Location = new Point(285, 67);
            AddTaskBtn.Name = "AddTaskBtn";
            AddTaskBtn.Size = new Size(130, 43);
            AddTaskBtn.TabIndex = 1;
            AddTaskBtn.Text = "add task";
            AddTaskBtn.UseVisualStyleBackColor = true;
            AddTaskBtn.Click += AddTaskBtn_Click;
            // 
            // TasksLbx
            // 
            TasksLbx.FormattingEnabled = true;
            TasksLbx.ItemHeight = 37;
            TasksLbx.Location = new Point(26, 142);
            TasksLbx.Name = "TasksLbx";
            TasksLbx.Size = new Size(389, 300);
            TasksLbx.TabIndex = 2;
            TasksLbx.Click += TasksLbx_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 9);
            label1.Name = "label1";
            label1.Size = new Size(125, 38);
            label1.TabIndex = 3;
            label1.Text = "just do it";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 474);
            Controls.Add(label1);
            Controls.Add(TasksLbx);
            Controls.Add(AddTaskBtn);
            Controls.Add(NewTaskTbx);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NewTaskTbx;
        private Button AddTaskBtn;
        private ListBox TasksLbx;
        private Label label1;
    }
}
