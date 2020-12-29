using System;
using System.Windows.Forms;

namespace HomeWork.Lesson8.Task1
{
    public partial class Form1 : Form
    {
        private Employees database = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsslCurrentTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            database = new Employees();
        }

        private void UpdateInfo()
        {
            var employee = database?.CurrentEmployee;
            if (employee == null)
            {
                tbName.Text = "";
                tbDescribe.Text = "";
                tbPosition.Text = "";
                tstbIndex.Text = "-1";
                return;
            }
            tbName.Text = employee.Name;
            tbDescribe.Text = employee.Describe;
            tbPosition.Text = employee.Position;
            dtpBirthDay.Value = employee.BirthDay;
            tstbIndex.Text = database.CurrentIndex.ToString();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            if (database==null)

            {
                MessageBox.Show("Создайте базу данных");
                return;
            }
            var frmAddEmployee = new frmAddEmployee();
            frmAddEmployee.ShowDialog();
            if (frmAddEmployee.DialogResult == DialogResult.OK)
            {
                database.Add(frmAddEmployee.Employee);
                UpdateInfo();
            }
        }

        private void tsbPrev_Click(object sender, EventArgs e)
        {
            database?.Prev();
            UpdateInfo();
        }

        private void tsbNext_Click(object sender, EventArgs e)
        {
            database?.Next();
            UpdateInfo();
        }

        private void сохранитькакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog
            {
                Filter = "XML файл|*.XML|Все файлы|*.*"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                database.Save(dialog.FileName);
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Filter = "XML файл|*.XML|Все файлы|*.*"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                database = new Employees();
                database.Load(dialog.FileName);
                UpdateInfo();
            }
        }

        private void tsbRemove_Click(object sender, EventArgs e)
        {
            database?.Remove();
            UpdateInfo();
        }

        private void опрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор - Александр Долгошеев", "Авторские права");
        }
    }
}
