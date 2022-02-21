using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationApp
{
    public partial class DashBord : Form
    {
        List<Student> students;
        public DashBord()
        {
            InitializeComponent();
        }

        

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataAccess da=new DataAccess();
            int id =int.Parse( textBox1.Text);

            students = da.getAllStudents(id);

            studentView.DataSource = students;
            //studentView.DisplayMember = "St_Address";
            
        }

        

        
    }
}
