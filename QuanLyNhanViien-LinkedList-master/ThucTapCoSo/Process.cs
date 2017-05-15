using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucTapCoSo
{
   class Process
    {   
       
        /// <summary>
        /// Phương thức tạo node trong DSLK
        /// </summary>
        /// <param name="item">Đối tượng Employee</param>
        /// <returns>Trả về node vừa tạo</returns>
        Node CreateNode(Employee item)
        {
            Node p = new Node
            {
                Data = item,
                PNext = null
            };
            //tao moi lien ket
            return p;
        }
        /// <summary>
        /// Thêm node vào đầu DSLK
        /// </summary>
        /// <param name="l">DSLK</param>
        /// <param name="p">Node cần thêm</param>
        public void AddHead(ref LinkedList l, Node p)
        {
            if (l.PHead == null)
            {
                l.PHead = l.PTail = p;
            }
            else
            {
                p.PNext = l.PHead;
                l.PHead = p;
            }
        }
        /// <summary>
        /// Thêm node vào cuối DSLK
        /// </summary>
        /// <param name="l">DSLK</param>
        /// <param name="p">Node cần thêm</param>
        public void AddTail(ref LinkedList l, Node p)
        {
            if (l.PHead == null)
            {
                l.PHead = l.PTail = p;
            }
            else
            {
                l.PTail.PNext = p;
                l.PTail = p;
            }
        }
        public void removeHead(ref LinkedList l)
        {
            // xoa Node dau tien.
            Node p = l.PHead;
            l.PHead = l.PHead.PNext;
        }
        public void removeTail(ref LinkedList l)
        {
            Node q = l.PHead;
            for (Node k = l.PHead; k!= null; k=k.PNext)
            {
                if(k == l.PTail)
                {
                    l.PTail = q;
                    l.PTail.PNext = null;
                    return;
                }
                q = k;
            }         

           
        }
        public void removeNode(ref LinkedList l, Node p  )
        {

            if (l.PHead == p)
            {
                removeHead(ref l);
            }
            else
            {
                if (l.PTail == p) removeTail(ref l);
                else
                {
                    Node q = l.PHead;
                    for (Node k = q.PNext; k!= null; k = k.PNext)
                    {
                        if (k == p)
                        {
                            q.PNext = k.PNext;
                            return;
                        }
                        q = k;
                    }
                }
               
            }

        }    
        /// <summary>
        /// Lấy data từ file đưa vào DSLK
        /// </summary>
        /// <param name="l">DSLK cần đưa vào</param>
        public void ImportDataFromFile(ref LinkedList l)
        {
            Employee e = null;
            StreamReader file = File.OpenText("../../Data/ListEmployee.txt");
            string line;
            do
            {
                line = file.ReadLine();
                if (line != null)
                {
                    //Tạo đối tượng mới
                    e = new Employee();
                    string[] words = line.Split('\t');
                    e.Name = words[0];
                    e.Office = words[1];
                    e.Birthday = Convert.ToDateTime(words[2]);
                    e.Salary = Convert.ToDouble(words[3]);
                    //Lưu đối tượng vào trong danh sách liên kết
                    Node p = CreateNode(e);
                    AddTail(ref l, p);
                }
            }
            while (line != null);
            file.Close();
        }
        /// <summary>
        /// Load dữ liệu từ DSLK lên DataGridView
        /// </summary>
        /// <param name="dg">Tên DataGridView</param>
        /// <param name="l">DSLK</param>
        public void LoadToDataGridView(DataGridView dg, LinkedList l)
        {
            //Dùng code
            BindingSource dts = new BindingSource();//Khai báo BindingSource
            dts.DataSource = typeof(Employee);// => datasource này chỉ thêm được những đối tượng Employee. Nếu không thì nó sẽ nhận typeof(đối tượng đầu tiên thêm vào)
            dg.DataSource = dts;
            for (Node p = l.PHead; p != null; p = p.PNext)
            {
                dts.Add(p.Data);//Thêm 1 đối tượng lên bảng (sẽ tự tạo ra 1 hàng mới). Biến doiTuong giống như ở cách 1
            }
            //Đặt tên cho các cột
            dg.Columns["Name"].HeaderText = "Họ Và Tên";
            dg.Columns["Office"].HeaderText = "Chức Vụ";
            dg.Columns["Birthday"].HeaderText = "Ngày Sinh";
            dg.Columns["Salary"].HeaderText = "Hệ Số Lương";
           
        }
        public void Swap(ref Node p, ref Node q)
        {
            Node temp = p;
            p = q;
            q = temp;
        }
        /// <summary>
        /// Sắp xếp
        /// </summary>
        /// <param name="l">DSLK</param>
        /// <param name="typeSort">kiểu sắp xếp, true: tăng, flase: giảm </param>
        /// <param name="sortBy"></param>
        //sắp xếp theo Hệ số lương và ngày sinh
        public void QuickSort1(ref LinkedList l, bool typeSort, int sortBy) 
        {         
            LinkedList l1, l2;
            Node tag, temp;
            if (l.PHead == l.PTail) return; //Kiểm tra danh sách có sắp xếp chưa
            //Khởi tạo 2 DSLK
            l1 = new LinkedList();
            l2 = new LinkedList();
            //cho cờ bằng node đầu tiên
            tag = l.PHead;
            //Cập nhật lại DSLK hiện tại
            l.PHead = tag.PNext;
            //Cô lập tag
            tag.PNext = null;
            //tách các node ra DS l1, l2 (l1: các node có data < tag) và (l2: các node có data > tag)
            while (l.PHead != null)
            {
                temp = l.PHead;
                l.PHead = l.PHead.PNext;
                temp.PNext = null;
                if (typeSort)
                {
                    if (sortBy == 1)
                        if (temp.Data.Salary <= tag.Data.Salary)
                            AddHead(ref l1, temp);
                        else AddHead(ref l2, temp);
                    else if (sortBy == 2)
                    {
                        if (temp.Data.Birthday <= tag.Data.Birthday)
                            AddHead(ref l1, temp);
                        else AddHead(ref l2, temp);
                    }
                }
                else
                {
                    if (sortBy == 1)
                        if (temp.Data.Salary  >= tag.Data.Salary)
                            AddHead(ref l1, temp);
                        else AddHead(ref l2, temp);
                    else if (sortBy == 2)
                    {
                        if (temp.Data.Birthday > tag.Data.Birthday)
                            AddHead(ref l1, temp);
                        else AddHead(ref l2, temp);
                    }
                }
            }
            //Gọi đệ quy sắp xếp l1, l2
            if (typeSort)
            {
                QuickSort1(ref l1, true, sortBy);
                QuickSort1(ref l2, true, sortBy);
            }
            else
            {
                QuickSort1(ref l1, false, sortBy);
                QuickSort1(ref l2, false, sortBy);
            }
            if (l1.PHead != null)
            {
                //l1 không rỗng
                l.PHead = l1.PHead;
                l1.PTail.PNext = tag;
            }
            else l.PHead = tag;
            tag.PNext = l2.PHead;
            if (l2.PHead != null)
                l.PTail = l2.PTail;
            else l.PTail = tag;
        }
        //tách tên
        public String GetName( String l)
        {   String Name;
            l = l.Trim();
            return   Name = l.Substring(l.LastIndexOf(' ') + 1);
        }
       //Sắp xếp theo Tên và chức vụ
        public void QuickSort2(ref LinkedList l, bool typeSort, int sortBy)
        {
            LinkedList l1, l2;
            Node tag, temp;
            if (l.PHead == l.PTail) return; //Kiểm tra danh sách có sắp xếp chưa
            //Khởi tạo 2 DSLK
            l1 = new LinkedList();
            l2 = new LinkedList();
            //cho cờ bằng node đầu tiên
            tag = l.PHead;
            //Cập nhật lại DSLK hiện tại
            l.PHead = l.PHead.PNext;
            //Cô lập tag
            tag.PNext = null;
            //tách các node ra DS l1, l2 (l1: các node có data < tag) và (l2: các node có data > tag)
            while (l.PHead != null)
            {
                temp = l.PHead;
                l.PHead = l.PHead.PNext;
                temp.PNext = null;
                if (typeSort)
                {
                    if (sortBy == 1)
                        if (String.Compare(GetName(temp.Data.Name),GetName(tag.Data.Name)) <=0)
                            AddHead(ref l1, temp);
                        else AddHead(ref l2, temp);
                    else if (sortBy == 2)
                    {
                        if (String.Compare(temp.Data.Office, tag.Data.Office) <= 0)
                            AddHead(ref l1, temp);
                        else AddHead(ref l2, temp);
                    }
                }
                else
                {
                    if (sortBy == 1)
                        if (String.Compare(GetName(temp.Data.Name), GetName(tag.Data.Name)) >= 0)
                            AddHead(ref l1, temp);
                        else AddHead(ref l2, temp);
                    else if (sortBy == 2)
                    {
                        if (String.Compare(temp.Data.Office, tag.Data.Office) >= 0)
                            AddHead(ref l1, temp);
                        else AddHead(ref l2, temp);
                    }
                }
            }
            //Gọi đệ quy sắp xếp l1, l2
            if (typeSort)
            {
                QuickSort2(ref l1, true, sortBy);
                QuickSort2(ref l2, true, sortBy);
            }
            else
            {
                QuickSort2(ref l1, false, sortBy);
                QuickSort2(ref l2, false, sortBy);
            }
            if (l1.PHead != null)
            {
                //l1 không rỗng
                l.PHead = l1.PHead;
                l1.PTail.PNext = tag;
            }
            else l.PHead = tag;
            tag.PNext = l2.PHead;
            if (l2.PHead != null)
                l.PTail = l2.PTail;
            else l.PTail = tag;
        }
        //Tim kiếm theo yêu cầu nhập vào
        public LinkedList searchByKey( String S)
        {
            LinkedList l = new LinkedList();
            LinkedList l1 = new LinkedList();
            LinkedList l2 = new LinkedList();

            ImportDataFromFile(ref l);
            int dem = 0;
            while (l.PHead != null) {
                Node temp;
                temp = l.PHead;
                l.PHead = l.PHead.PNext;
                temp.PNext = null;
                String Name = temp.Data.Name.ToUpper().Trim();
                String Office = temp.Data.Office.ToUpper().Trim();
                string sal = temp.Data.Salary.ToString();
                string bir = temp.Data.Birthday.ToString();
                if (Name.Contains(S) || Office.Contains(S)||sal.Contains(S)||bir.Contains(S))
                {
                    AddTail(ref l1, temp);
                    dem++;
                }
              temp =  temp.PNext;
            }
            if (dem == 0)
            {
                return l2;
            }
             else
                return l1;
        }
        //Xóa một nhân viên theo yêu cầu nhập vào
        public LinkedList removeNhanVien(ref LinkedList l, String S)
        {
            LinkedList l1 = new LinkedList();
            // LinkedList l2 = new LinkedList();
            int dem = 0;
            Node q = l.PHead;
            for (Node p = l.PHead; p != null; p = p.PNext)
            {
                string name = p.Data.Name.ToUpper().Trim();
                string of = p.Data.Office.ToUpper().Trim();
                string sal = p.Data.Salary.ToString();
                string bir = p.Data.Birthday.Year.ToString();
                if (name.Contains(S) || of.Contains(S) || sal.Contains(S) || bir.Contains(S))
                {
                    removeNode(ref l, p);
                    dem++;
                }
             }
            if (dem == 0) {
                return l1;
            }else
                return l;
        }
        //Thêm một nhân viên theo thứ tự sắp xếp
        public LinkedList addNewNhanVien(String name , String of , double Sal)
        {
            //LinkedList l1 = new LinkedList();
            LinkedList l = new LinkedList();
            ImportDataFromFile(ref l);
            Employee e = null; e = new Employee();
            //Node temp;
            e.Name = Convert.ToString(name);
            e.Office = of;
            e.Birthday = Convert.ToDateTime("10/10/1998");
            e.Salary = Sal;
            Node p = CreateNode(e);
           AddTail(ref l, p);
            return l;
        }
        /* câu 1:  Đọc file - finish
         * câu 2:  Sắp xếp theo tiêu chí - finish - cần viết lại class DateTime - tạo biến int tag để làm câu 3
         * câu 3:  Chèn vào theo tiêu chí sắp xếp hiện có - finish - bsung t Update
         * câu 4:  Xóa nhân viên theo keyword - finish - Bổ sung Pt Update
         * câu 5:  Tìm kiếm nv theo keyword - Còn chưa in ra được vị trí 
         * câu 6 : xuất ra theo định dạng - chưa.
         Thiếu Phương thức cập nhật Linkedlist
         Viết class dateTime
         KT lại hàm sx khi tìm kiếm thì k thể sxep
         */
    }
}
