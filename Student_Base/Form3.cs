using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Base
{
    public partial class RedactorForm : Form
    {
        private static DataWork dw = new DataWork();
        BaseForm form = new BaseForm();
        private int actualNum;
        public RedactorForm(int studentNum)
        {
            InitializeComponent();
            actualNum = studentNum;
            InitialyzeData(studentNum);
        }
        private void InitialyzeData(int actualNum)
        {
            this.secondNameTextBox.Text = form.studentList.BStudents[actualNum].SecondName;
            this.nameTextBox.Text = form.studentList.BStudents[actualNum].Name;
            this.midlleNameTextBox.Text = form.studentList.BStudents[actualNum].MiddleName;
            this.groupTextBox.Text = form.studentList.BStudents[actualNum].Group;
            this.subGroupTextBox.Text = form.studentList.BStudents[actualNum].SubGroup;
            int course = form.studentList.BStudents[actualNum].Curse;
            switch (course)
            {
                case 1:
                    firstCourseRadioButtom.Checked = true;
                    break;
                case 2:
                    secondCourseRadioButtom.Checked = true;
                    break;
                case 3:
                    thirdCourseRadioButtom.Checked = true;
                    break;
                case 4:
                    fourCOurseRadioButtom.Checked = true;
                    break;

            }
            
        }

        private void saveChangesButtom_Click(object sender, EventArgs e)
        {
            form.studentList.BStudents[actualNum].Curse=GetCurse();
            form.studentList.BStudents[actualNum].Group = groupTextBox.Text;
            form.studentList.BStudents[actualNum].SubGroup = subGroupTextBox.Text;
            dw.ExportData(form.studentList);
            MessageBox.Show("Редактирование прошло успешно");
            this.Close();
            
        }
        private int GetCurse()
        {
            if (firstCourseRadioButtom.Checked) { return 1; }
            else if (secondCourseRadioButtom.Checked) { return 2; }
            else if (thirdCourseRadioButtom.Checked) { return 3; }
            else if (fourCOurseRadioButtom.Checked) { return 4; }
            else return 0;
        }
    }
}
