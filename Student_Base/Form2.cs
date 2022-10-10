using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Student_Base
{
    public partial class AddForms : Form
    {
        private BaseForm form = new BaseForm();
        private DataWork dw = new DataWork();
        public AddForms()
        {
            InitializeComponent();
        }

        private void addButtom_Click(object sender, EventArgs e)
        {
            string name = this.nameBox.Text;
            string secondName = this.secondNameBox.Text;
            string middleName = this.middleNameBox.Text;
            string group = this.groupBox.Text;
            string subGroup = this.subGroupBox.Text;
            if (CheckField())
            {
                if (this.sTypeBox.Text == "Бакалавр")
                {
                    Student student = new Student(name, secondName, middleName, group, subGroup, GetCurse(), (form.studentList.BStudents.Count + 1), GetType());
                    form.studentList.BStudents.Add(student);
                }
                else
                {
                    Student student = new Student(name, secondName, middleName, group, subGroup, GetCurse(), (form.studentList.MStudents.Count + 1), GetType());
                    form.studentList.MStudents.Add(student);
                }
                dw.ExportData(form.studentList);
                MessageBox.Show("Информация о студенте добавлена в файл.");
            }
            else
            {
                MessageBox.Show("Необходимо заполнить все обязательные поля");
                CheckField();
            }
        }

        private bool CheckField()
        {
            if ((GetCurse() == 0)||(this.nameBox.Text is null)||(this.secondName.Text is null)||(this.group.Text is null)||(this.subGroup is null)||GetType()=="Unknown")
            {
                this.name.ForeColor = Color.Red;
                this.secondName.ForeColor = Color.Red;
                this.group.ForeColor = Color.Red;
                this.subGroup.ForeColor = Color.Red;
                this.course.ForeColor = Color.Red;
                this.sTypeBox.ForeColor = Color.Red;
                return false;
            }
            else
            {
                return true;
            }
        }
        private string GetType()
        {
            switch (this.sTypeBox.Text.ToLower())
            {
                case "магистр":
                    return "M";
                    break;
                case "бакалавр":
                    return "B";
                    break;
                case "абитуриент":
                    return "A";
                    break;
                default:
                    return "Unknown";
                    break;
            }
        }
        private int GetCurse()
        {
            if (radio1Curse.Checked) { return 1; }
            else if (radio2Curse.Checked) { return 2; }
            else if (radio3Curse.Checked) { return 3; }
            else if (radio4Curse.Checked) { return 4; }
            else return 0;
        }

        private void exitButtom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sTypeBox_TextChanged(object sender, EventArgs e)
        {
            radio1Curse.Visible = ((this.sTypeBox.Text.ToLower() == "бакалавр") || (this.sTypeBox.Text.ToLower() == "магистр"));
            radio2Curse.Visible = ((this.sTypeBox.Text.ToLower() == "бакалавр") || (this.sTypeBox.Text.ToLower() == "магистр"));
            radio3Curse.Visible = (this.sTypeBox.Text.ToLower() == "бакалавр");
            radio4Curse.Visible = (this.sTypeBox.Text.ToLower() == "бакалавр");
            
        }
    }
}
