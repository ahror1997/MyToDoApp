namespace MyToDoApp
{
    public partial class Form1 : Form
    {
        List<string> MyTasks = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void AddTaskBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NewTaskTbx.Text))
                return;

            MyTasks.Add(NewTaskTbx.Text);

            TasksLbx.DataSource = null;
            TasksLbx.DataSource = MyTasks;

            NewTaskTbx.Text = string.Empty;
        }

        private void TasksLbx_Click(object sender, EventArgs e)
        {
            if (TasksLbx.SelectedIndex == -1)
                return;

            MyTasks.RemoveAt(TasksLbx.SelectedIndex);

            TasksLbx.DataSource = null;
            TasksLbx.DataSource = MyTasks;
        }
    }
}
