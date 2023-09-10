using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class TasksForm1 : Form
       
    {
        private List<Tasks> _list1;
        private DataTable _dt1;
        public TasksForm1()
        {
            InitializeComponent();
            _list1 = new List<Tasks>();
            _dt1 = new DataTable();
            bnSrc1.DataSource = _list1;
            //bnSrc2.DataSource = _dt1;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView2.AutoGenerateColumns = true;
    }

        private void TasksForm1_Load(object sender, EventArgs e)
        {
            _list1.Clear();
            List<Tasks> list = DBHelper.GetTasks();
            if (list != null && list.Count > 0)
            {
                _list1.AddRange(list);
                bnSrc1.ResetBindings(false);
            }

            _dt1.Clear();
            DataTable table1 = DBHelper.GetResponsibles();
            dataGridView2.DataSource = table1;
            //bnSrc2.ResetBindings(false);
            

        }
    }
}
