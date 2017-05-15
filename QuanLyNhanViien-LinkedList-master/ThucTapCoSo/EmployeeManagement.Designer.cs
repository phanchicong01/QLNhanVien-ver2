namespace ThucTapCoSo
{
    partial class EmployeeManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.txtOffice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRefers = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSortDESCByOf = new System.Windows.Forms.Button();
            this.btnSortASCByOf = new System.Windows.Forms.Button();
            this.btnSortDESCByName = new System.Windows.Forms.Button();
            this.btnSortASCByName = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSortDESCByNS = new System.Windows.Forms.Button();
            this.btnSortASCByNS = new System.Windows.Forms.Button();
            this.btnSortDESCByHSL = new System.Windows.Forms.Button();
            this.btnSortASCByHSL = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.msdsEmployee = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msdsEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtSalary);
            this.panel1.Controls.Add(this.txtBirthday);
            this.panel1.Controls.Add(this.txtOffice);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnRefers);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.searchControl1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(13, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 181);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(884, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Hệ Số Lương:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(884, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ngày Sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(884, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Chức Vụ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(884, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ho va ten:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(993, 138);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 40);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(993, 100);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(153, 26);
            this.txtSalary.TabIndex = 11;
            // 
            // txtBirthday
            // 
            this.txtBirthday.Location = new System.Drawing.Point(993, 68);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(153, 26);
            this.txtBirthday.TabIndex = 10;
            // 
            // txtOffice
            // 
            this.txtOffice.Location = new System.Drawing.Point(993, 36);
            this.txtOffice.Name = "txtOffice";
            this.txtOffice.Size = new System.Drawing.Size(153, 26);
            this.txtOffice.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(993, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(153, 26);
            this.txtName.TabIndex = 8;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(620, 38);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 34);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRefers
            // 
            this.btnRefers.Location = new System.Drawing.Point(539, 38);
            this.btnRefers.Name = "btnRefers";
            this.btnRefers.Size = new System.Drawing.Size(75, 34);
            this.btnRefers.TabIndex = 6;
            this.btnRefers.Text = "Tải Lại.";
            this.btnRefers.UseVisualStyleBackColor = true;
            this.btnRefers.Click += new System.EventHandler(this.btnRefers_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(785, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(71, 26);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Tìm ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // searchControl1
            // 
            this.searchControl1.Location = new System.Drawing.Point(539, 9);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.searchControl1.Properties.Appearance.Options.UseFont = true;
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Size = new System.Drawing.Size(240, 26);
            this.searchControl1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSortDESCByOf);
            this.groupBox2.Controls.Add(this.btnSortASCByOf);
            this.groupBox2.Controls.Add(this.btnSortDESCByName);
            this.groupBox2.Controls.Add(this.btnSortASCByName);
            this.groupBox2.Location = new System.Drawing.Point(269, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 169);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sắp Xếp";
            // 
            // btnSortDESCByOf
            // 
            this.btnSortDESCByOf.Location = new System.Drawing.Point(132, 87);
            this.btnSortDESCByOf.Name = "btnSortDESCByOf";
            this.btnSortDESCByOf.Size = new System.Drawing.Size(120, 55);
            this.btnSortDESCByOf.TabIndex = 3;
            this.btnSortDESCByOf.Text = "Giảm Theo Chức Vụ";
            this.btnSortDESCByOf.UseVisualStyleBackColor = true;
            this.btnSortDESCByOf.Click += new System.EventHandler(this.btnSortDESCByOf_Click);
            // 
            // btnSortASCByOf
            // 
            this.btnSortASCByOf.Location = new System.Drawing.Point(132, 26);
            this.btnSortASCByOf.Name = "btnSortASCByOf";
            this.btnSortASCByOf.Size = new System.Drawing.Size(120, 55);
            this.btnSortASCByOf.TabIndex = 2;
            this.btnSortASCByOf.Text = "Tăng Theo Chức Vụ";
            this.btnSortASCByOf.UseVisualStyleBackColor = true;
            this.btnSortASCByOf.Click += new System.EventHandler(this.btnSortASCByOf_Click);
            // 
            // btnSortDESCByName
            // 
            this.btnSortDESCByName.Location = new System.Drawing.Point(6, 87);
            this.btnSortDESCByName.Name = "btnSortDESCByName";
            this.btnSortDESCByName.Size = new System.Drawing.Size(120, 55);
            this.btnSortDESCByName.TabIndex = 1;
            this.btnSortDESCByName.Text = "Giảm Theo Tên";
            this.btnSortDESCByName.UseVisualStyleBackColor = true;
            this.btnSortDESCByName.Click += new System.EventHandler(this.btnSortDESCByName_Click);
            // 
            // btnSortASCByName
            // 
            this.btnSortASCByName.Location = new System.Drawing.Point(6, 26);
            this.btnSortASCByName.Name = "btnSortASCByName";
            this.btnSortASCByName.Size = new System.Drawing.Size(120, 55);
            this.btnSortASCByName.TabIndex = 0;
            this.btnSortASCByName.Text = "Tăng Theo Tên";
            this.btnSortASCByName.UseVisualStyleBackColor = true;
            this.btnSortASCByName.Click += new System.EventHandler(this.btnSortASCByName_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSortDESCByNS);
            this.groupBox1.Controls.Add(this.btnSortASCByNS);
            this.groupBox1.Controls.Add(this.btnSortDESCByHSL);
            this.groupBox1.Controls.Add(this.btnSortASCByHSL);
            this.groupBox1.Location = new System.Drawing.Point(3, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 169);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sắp Xếp";
            // 
            // btnSortDESCByNS
            // 
            this.btnSortDESCByNS.Location = new System.Drawing.Point(132, 90);
            this.btnSortDESCByNS.Name = "btnSortDESCByNS";
            this.btnSortDESCByNS.Size = new System.Drawing.Size(120, 55);
            this.btnSortDESCByNS.TabIndex = 3;
            this.btnSortDESCByNS.Text = "Giảm Theo Ngày Sinh";
            this.btnSortDESCByNS.UseVisualStyleBackColor = true;
            this.btnSortDESCByNS.Click += new System.EventHandler(this.btnSortDESCByNS_Click);
            // 
            // btnSortASCByNS
            // 
            this.btnSortASCByNS.Location = new System.Drawing.Point(132, 29);
            this.btnSortASCByNS.Name = "btnSortASCByNS";
            this.btnSortASCByNS.Size = new System.Drawing.Size(120, 55);
            this.btnSortASCByNS.TabIndex = 2;
            this.btnSortASCByNS.Text = "Tăng Theo Ngày Sinh";
            this.btnSortASCByNS.UseVisualStyleBackColor = true;
            this.btnSortASCByNS.Click += new System.EventHandler(this.btnSortASCByNS_Click);
            // 
            // btnSortDESCByHSL
            // 
            this.btnSortDESCByHSL.Location = new System.Drawing.Point(6, 90);
            this.btnSortDESCByHSL.Name = "btnSortDESCByHSL";
            this.btnSortDESCByHSL.Size = new System.Drawing.Size(120, 55);
            this.btnSortDESCByHSL.TabIndex = 1;
            this.btnSortDESCByHSL.Text = "Giảm Theo HSL";
            this.btnSortDESCByHSL.UseVisualStyleBackColor = true;
            this.btnSortDESCByHSL.Click += new System.EventHandler(this.btnSortDESCByHSL_Click);
            // 
            // btnSortASCByHSL
            // 
            this.btnSortASCByHSL.Location = new System.Drawing.Point(6, 29);
            this.btnSortASCByHSL.Name = "btnSortASCByHSL";
            this.btnSortASCByHSL.Size = new System.Drawing.Size(120, 55);
            this.btnSortASCByHSL.TabIndex = 0;
            this.btnSortASCByHSL.Text = "Tăng Theo HSL";
            this.btnSortASCByHSL.UseVisualStyleBackColor = true;
            this.btnSortASCByHSL.Click += new System.EventHandler(this.btnSortASCByHSL_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.msdsEmployee);
            this.panel2.Location = new System.Drawing.Point(13, 205);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1149, 455);
            this.panel2.TabIndex = 1;
            // 
            // msdsEmployee
            // 
            this.msdsEmployee.AllowUserToAddRows = false;
            this.msdsEmployee.AllowUserToDeleteRows = false;
            this.msdsEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.msdsEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.msdsEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msdsEmployee.Location = new System.Drawing.Point(0, 0);
            this.msdsEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.msdsEmployee.Name = "msdsEmployee";
            this.msdsEmployee.RowTemplate.Height = 24;
            this.msdsEmployee.Size = new System.Drawing.Size(1149, 455);
            this.msdsEmployee.TabIndex = 0;
            // 
            // EmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 664);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "EmployeeManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.EmployeeManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.msdsEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView msdsEmployee;
        private System.Windows.Forms.Button btnSortASCByHSL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSortDESCByHSL;
        private System.Windows.Forms.Button btnSortDESCByNS;
        private System.Windows.Forms.Button btnSortASCByNS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSortDESCByOf;
        private System.Windows.Forms.Button btnSortASCByOf;
        private System.Windows.Forms.Button btnSortDESCByName;
        private System.Windows.Forms.Button btnSortASCByName;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefers;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.TextBox txtOffice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}