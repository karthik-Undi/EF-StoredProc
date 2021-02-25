using System;
using System.Linq;
using System.Windows.Forms;

namespace eftest2
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void addbutton_Click(object sender, EventArgs e)
        {
            using (var EmpDBContext = new employeeEntities())
            {
                EmpDBContext.InsertEmployee(Convert.ToInt32(idbox.Text), namebox.Text, Convert.ToInt32(salarybox.Text));
                EmpDBContext.SaveChanges();
                showbutton_Click(sender, e);
            }
            idbox.Clear(); namebox.Clear(); salarybox.Clear();
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            using (var EmpDBContext = new employeeEntities())
            {
                EmpDBContext.UpdateEmployee(Convert.ToInt32(idbox.Text), namebox.Text, Convert.ToInt32(salarybox.Text));
                EmpDBContext.SaveChanges();
                showbutton_Click(sender, e);
                MessageBox.Show("updated");
            }
            idbox.Clear(); namebox.Clear(); salarybox.Clear();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            using (var EmpDBContext = new employeeEntities())
            {
                EmpDBContext.DeleteEmployee(Convert.ToInt32(idbox.Text));
                EmpDBContext.SaveChanges();
                showbutton_Click(sender, e);
                MessageBox.Show("Deleted");
            }
            idbox.Clear(); namebox.Clear(); salarybox.Clear();
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            using (var show = new employeeEntities())
            {
                dataGridView1.DataSource = show.EmployeeDetails.ToList<EmployeeDetail>();
            }
            idbox.Clear(); namebox.Clear(); salarybox.Clear();
        }

        private void getdetailsbutton_Click(object sender, EventArgs e)
        {
            using (var DBcontext = new employeeEntities())
            {
                var result = DBcontext.GETDETAILS(Convert.ToInt32(idbox.Text)).ToList<EmployeeDetail>();
                dataGridView1.DataSource = result;
                idbox.Clear(); namebox.Clear(); salarybox.Clear();
            }
        }
    }
}