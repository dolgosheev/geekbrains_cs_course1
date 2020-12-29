using System;
using System.Windows.Forms;

namespace HomeWork.Lesson8.Task1
{
    public partial class frmAddEmployee : Form
    {

        public Employee Employee { get; private set; } = new Employee();

        public frmAddEmployee()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Employee.Name = tbName.Text;
            Employee.Describe = tbDescribe.Text;
            Employee.Position = tbPosition.Text;
            Employee.BirthDay = dtpBirthDay.Value;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
