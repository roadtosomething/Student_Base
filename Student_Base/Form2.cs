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
        public AddForms()
        {
            InitializeComponent();
        }

        private void addButtom_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream("StudentXMLFile.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(StudentList));
            string name = this.nameBox.Text;
            string secondName = this.secondNameBox.Text;
            string middleName = this.middleNameBox.Text;
            string group = this.groupBox.Text;
            string subGroup = this.subGroupBox.Text;
            int curse = 1;
            StudentList studentList = new StudentList();
            studentList = (StudentList) xmlSerializer.Deserialize(file);
            file.Close();
            StreamWriter sw = new StreamWriter("StudentXMLFile.xml", false);
            Student student = new Student(name, secondName, middleName, group, subGroup, curse, (studentList.Students.Count+1));
            studentList.Students.Add(student);
            xmlSerializer.Serialize(sw,studentList);
            sw.Close();
            MessageBox.Show("Информация о студенте добавлена в файл.");
        }
    }
}
