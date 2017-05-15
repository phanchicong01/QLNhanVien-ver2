using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
	

namespace ThucTapCoSo
{
    public partial class EmployeeManagement : Form
    {    int tag = 0 ;
         Boolean tag2 = true;
        
        LinkedList l = new LinkedList();
        Process p = new Process();
        public EmployeeManagement()
        {
            InitializeComponent();
           
        }
        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            tag = 5;
            p.ImportDataFromFile(ref l);
            p.LoadToDataGridView(msdsEmployee, l);
        }
        //HSL
        private void btnSortASCByHSL_Click(object sender, EventArgs e)
        {
            p.QuickSort1(ref l, true, 1);
            p.LoadToDataGridView(msdsEmployee, l);
            tag = 4;tag2 = true;
        }
        private void btnSortDESCByHSL_Click(object sender, EventArgs e)
        {
            p.QuickSort1(ref l, false, 1);
            p.LoadToDataGridView(msdsEmployee, l);
            tag = 4; tag2 = false;
        }
        //Birthday
        private void btnSortASCByNS_Click(object sender, EventArgs e)
        {
            p.QuickSort1(ref l, true, 2);
            p.LoadToDataGridView(msdsEmployee, l);
            tag = 3; tag2 = true;
        }
        private void btnSortDESCByNS_Click(object sender, EventArgs e)
        {
            p.QuickSort1(ref l, false, 2);
            p.LoadToDataGridView(msdsEmployee, l);
            tag = 3; tag2 = false;
        }
        //Name
        private void btnSortASCByName_Click(object sender, EventArgs e)
        {
            p.QuickSort2(ref l, true, 1);
            p.LoadToDataGridView(msdsEmployee, l);
            tag = 1; tag2 = true;
        }
        private void btnSortDESCByName_Click(object sender, EventArgs e)
        {
            p.QuickSort2(ref l, false, 1);
            p.LoadToDataGridView(msdsEmployee, l);
            tag = 1; tag2 = false;
        }
        //Office
        private void btnSortASCByOf_Click(object sender, EventArgs e)
        {
          
            p.QuickSort2(ref l, true, 2);
            p.LoadToDataGridView(msdsEmployee, l);
            tag = 2; tag2 = true;
        }
        private void btnSortDESCByOf_Click(object sender, EventArgs e)
        {
            p.QuickSort2(ref l, false, 2);
            p.LoadToDataGridView(msdsEmployee, l);
            tag = 2; tag2 = false;
        }
        //
        private void btnSearch_Click(object sender, EventArgs e)
        {
            tag = 0;
            String s = Convert.ToString(searchControl1.Text).ToUpper().Trim() ;
            LinkedList l1 = new LinkedList();
            l1 =  p.searchByKey( s);
            if (l1.PHead == l1.PTail)
            {
                MessageBox.Show("Không có nhân viên nào hợp lệ với từ khóa: ' " + searchControl1.Text
                    + " '");
            }else
                p.LoadToDataGridView(msdsEmployee, l1);
        }
        private void btnRefers_Click(object sender, EventArgs e)
        {
            if (tag < 5 || tag == 0)
            {
              EmployeeManagement_Load(sender,e);
            }
            else
                p.LoadToDataGridView(msdsEmployee, l);
            
            tag = 5;
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            tag = 0;
            LinkedList l1 = new LinkedList();
            String s = Convert.ToString(searchControl1.Text).ToUpper().Trim();
            l = p.removeNhanVien(ref l, s);
       
            if (l.PHead == l.PTail )
            {
                MessageBox.Show("Không có nhân viên nào hợp lệ với từ khóa: ' " + searchControl1.Text
                    + " '");
            }
            else if(MessageBox.Show("Bạn có muốn xóa tất cả nhân viên có từ khóa: ' " + searchControl1.Text + " '", "thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                p.LoadToDataGridView(msdsEmployee, l);
            }
        }      
        private void btnAdd_Click(object sender, EventArgs e)
        {
            /*   string[] names = new string[] { txtName.Text.ToString().Trim(), txtOffice.Text.ToString().Trim(),txtBirthday.Text.ToString().Trim(), txtSalary.Text.ToString().Trim() };
               using (StreamWriter sw = new StreamWriter("../../Data/ListEmployee.txt"))
               {
                   foreach (string s in names)
                   {
                       sw.Write(s + "\t");
                   }
               }*/
            String name, of;
            LinkedList l1 = new LinkedList();
            name = Convert.ToString( txtName.Text);
            of = Convert.ToString(txtOffice.Text);
            double sal = Convert.ToDouble(txtSalary.Text);
            //q.Data.Birthday = Convert.ToDateTime( txtBirthday.Text);
            l1 = p.addNewNhanVien( name, of, sal);
            if(tag != 0 || tag != 5) { 
                if(tag2 == true)
                {
                    if (tag == 1) p.QuickSort2(ref l1, true, 1);
                    if (tag == 2) p.QuickSort2(ref l1, true, 2);
                    if (tag == 3) p.QuickSort1(ref l1, true, 2);
                    if (tag == 4) p.QuickSort1(ref l1, true, 1);
                }
                else
                {
                    if (tag == 1) p.QuickSort2(ref l1, false, 1);
                    if (tag == 2) p.QuickSort2(ref l1, false, 2);
                    if (tag == 3) p.QuickSort1(ref l1, false, 2);
                    if (tag == 4) p.QuickSort1(ref l1, false, 1);
                }
            }
            p.LoadToDataGridView(msdsEmployee, l1);
                  
        }


    }
}
