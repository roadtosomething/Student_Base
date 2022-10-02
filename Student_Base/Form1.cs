using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Student_Base
{
    public partial class BaseForm : Form
    {

        public BaseForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private StudentList InitializeDataStudents()
        {
            FileStream file = new FileStream("StudentXMLFile.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(StudentList));
            StudentList studentList = new StudentList();
            studentList =(StudentList) xmlSerializer.Deserialize(file);
            file.Close();
            return studentList;
        }
        private void InitializeComponent()
        {
            
            this.baseMenu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вЫбратьСтудентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.магистратурыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бакалавриатаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondName = new System.Windows.Forms.Label();
            this.group = new System.Windows.Forms.Label();
            this.middleName = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.subGroup = new System.Windows.Forms.Label();
            this.typeViewLabel = new System.Windows.Forms.Label();
            this.viewDescription = new System.Windows.Forms.Label();
            this.prevButtom = new System.Windows.Forms.Button();
            this.nextButtom = new System.Windows.Forms.Button();
            this.baseMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseMenu
            // 
            this.baseMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.baseMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.просмотрToolStripMenuItem,
            this.студентToolStripMenuItem});
            this.baseMenu.Location = new System.Drawing.Point(0, 0);
            this.baseMenu.Name = "baseMenu";
            this.baseMenu.Size = new System.Drawing.Size(443, 28);
            this.baseMenu.TabIndex = 0;
            this.baseMenu.Text = "Главное меню";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // просмотрToolStripMenuItem
            // 
            this.просмотрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вЫбратьСтудентовToolStripMenuItem});
            this.просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            this.просмотрToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.просмотрToolStripMenuItem.Text = "Просмотр";
            // 
            // вЫбратьСтудентовToolStripMenuItem
            // 
            this.вЫбратьСтудентовToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.магистратурыToolStripMenuItem,
            this.бакалавриатаToolStripMenuItem});
            this.вЫбратьСтудентовToolStripMenuItem.Name = "вЫбратьСтудентовToolStripMenuItem";
            this.вЫбратьСтудентовToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.вЫбратьСтудентовToolStripMenuItem.Text = "Выбрать студентов";
            // 
            // магистратурыToolStripMenuItem
            // 
            this.магистратурыToolStripMenuItem.CheckOnClick = true;
            this.магистратурыToolStripMenuItem.Name = "магистратурыToolStripMenuItem";
            this.магистратурыToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.магистратурыToolStripMenuItem.Text = "Магистратуры";
            this.магистратурыToolStripMenuItem.CheckedChanged += new System.EventHandler(this.магистратурыToolStripMenuItem_CheckedChanged);
            // 
            // бакалавриатаToolStripMenuItem
            // 
            this.бакалавриатаToolStripMenuItem.Checked = true;
            this.бакалавриатаToolStripMenuItem.CheckOnClick = true;
            this.бакалавриатаToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.бакалавриатаToolStripMenuItem.Name = "бакалавриатаToolStripMenuItem";
            this.бакалавриатаToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.бакалавриатаToolStripMenuItem.Text = "Бакалавриата";
            this.бакалавриатаToolStripMenuItem.CheckedChanged += new System.EventHandler(this.бакалавриатаToolStripMenuItem_CheckedChanged);
            // 
            // студентToolStripMenuItem
            // 
            this.студентToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьToolStripMenuItem,
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.студентToolStripMenuItem.Name = "студентToolStripMenuItem";
            this.студентToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.студентToolStripMenuItem.Text = "Студент";
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // secondName
            // 
            this.secondName.AutoSize = true;
            this.secondName.Location = new System.Drawing.Point(81, 69);
            this.secondName.Name = "secondName";
            this.secondName.Size = new System.Drawing.Size(66, 16);
            this.secondName.TabIndex = 1;
            this.secondName.Text = "Фамилия";
            // 
            // group
            // 
            this.group.AutoSize = true;
            this.group.Location = new System.Drawing.Point(69, 153);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(78, 16);
            this.group.TabIndex = 2;
            this.group.Text = "Факультет";
            // 
            // middleName
            // 
            this.middleName.AutoSize = true;
            this.middleName.Location = new System.Drawing.Point(77, 125);
            this.middleName.Name = "middleName";
            this.middleName.Size = new System.Drawing.Size(70, 16);
            this.middleName.TabIndex = 3;
            this.middleName.Text = "Отчество";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(114, 97);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(33, 16);
            this.name.TabIndex = 4;
            this.name.Text = "Имя";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(169, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = students.Students[0].SecondName;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(184, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(169, 22);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = students.Students[0].Name;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(184, 122);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(169, 22);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = students.Students[0].MiddleName;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(184, 150);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(169, 22);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = students.Students[0].Group;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Курс";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(184, 220);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(35, 20);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(225, 220);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(35, 20);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Enabled = false;
            this.radioButton3.Location = new System.Drawing.Point(266, 220);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(35, 20);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Enabled = false;
            this.radioButton4.Location = new System.Drawing.Point(307, 220);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(35, 20);
            this.radioButton4.TabIndex = 13;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(184, 179);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(169, 22);
            this.textBox5.TabIndex = 15;
            this.textBox5.Text = students.Students[0].SubGroup;
            // 
            // subGroup
            // 
            this.subGroup.AutoSize = true;
            this.subGroup.Location = new System.Drawing.Point(50, 182);
            this.subGroup.Name = "subGroup";
            this.subGroup.Size = new System.Drawing.Size(97, 16);
            this.subGroup.TabIndex = 14;
            this.subGroup.Text = "Направление";
            // 
            // typeViewLabel
            // 
            this.typeViewLabel.AutoSize = true;
            this.typeViewLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.typeViewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeViewLabel.Location = new System.Drawing.Point(318, 40);
            this.typeViewLabel.Name = "typeViewLabel";
            this.typeViewLabel.Size = new System.Drawing.Size(114, 16);
            this.typeViewLabel.TabIndex = 16;
            this.typeViewLabel.Text = this.бакалавриатаToolStripMenuItem.Text;
            // 
            // viewDescription
            // 
            this.viewDescription.AutoSize = true;
            this.viewDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewDescription.Location = new System.Drawing.Point(168, 40);
            this.viewDescription.Name = "viewDescription";
            this.viewDescription.Size = new System.Drawing.Size(144, 16);
            this.viewDescription.TabIndex = 17;
            this.viewDescription.Text = "Просмотр студентов";
            // 
            // prevButtom
            // 
            this.prevButtom.Location = new System.Drawing.Point(12, 246);
            this.prevButtom.Name = "prevButtom";
            this.prevButtom.Size = new System.Drawing.Size(207, 50);
            this.prevButtom.TabIndex = 18;
            this.prevButtom.Text = "Предыдущий";
            this.prevButtom.UseVisualStyleBackColor = true;
            // 
            // nextButtom
            // 
            this.nextButtom.Location = new System.Drawing.Point(225, 246);
            this.nextButtom.Name = "nextButtom";
            this.nextButtom.Size = new System.Drawing.Size(218, 50);
            this.nextButtom.TabIndex = 19;
            this.nextButtom.Text = "Следующий";
            this.nextButtom.UseVisualStyleBackColor = true;
            this.nextButtom.Click += new System.EventHandler(this.nextButtom_Click);
            // 
            // BaseForm
            // 
            this.ClientSize = new System.Drawing.Size(443, 308);
            this.Controls.Add(this.nextButtom);
            this.Controls.Add(this.prevButtom);
            this.Controls.Add(this.viewDescription);
            this.Controls.Add(this.typeViewLabel);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.subGroup);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.middleName);
            this.Controls.Add(this.group);
            this.Controls.Add(this.secondName);
            this.Controls.Add(this.baseMenu);
            this.MainMenuStrip = this.baseMenu;
            this.Name = "BaseForm";
            this.baseMenu.ResumeLayout(false);
            this.baseMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void магистратурыToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            this.бакалавриатаToolStripMenuItem.Checked = !магистратурыToolStripMenuItem.Checked;
            if (магистратурыToolStripMenuItem.Checked)
            {
                this.typeViewLabel.Text = магистратурыToolStripMenuItem.Text;
            }
            else
            {
                this.typeViewLabel.Text = бакалавриатаToolStripMenuItem.Text;
            }
        }

        private void бакалавриатаToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            this.магистратурыToolStripMenuItem.Checked = !бакалавриатаToolStripMenuItem.Checked;
            if (бакалавриатаToolStripMenuItem.Checked)
            {
                this.typeViewLabel.Text = бакалавриатаToolStripMenuItem.Text;
            }
            else
            {
                this.typeViewLabel.Text = магистратурыToolStripMenuItem.Text;
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForms addForm = new AddForms();
            addForm.Show();
        }
        private void nextButtom_Click(object sender, EventArgs e)
        {
            StudentList studentList = new StudentList();
            studentList = InitializeDataStudents();
            int num = studentList.Students.Find(x => 
            x.MiddleName.Contains(this.textBox3.Text)
            &&x.Group.Contains(this.textBox4.Text)
            &&x.Name.Contains(this.textBox2.Text)
            &&x.SecondName.Contains(this.textBox1.Text)
            &&x.SubGroup.Contains(this.textBox5.Text)).Id;
            if (num == studentList.Students.Count)
            {
                num = 0;
                ShowInfo(num);
            }
            else
            {
                ShowInfo(num);
            }
        }

        private void ShowInfo(int num)
        {
            StudentList studentList = new StudentList();
            studentList = InitializeDataStudents();
            this.textBox1.Text = studentList.Students[num].SecondName;
            this.textBox2.Text = studentList.Students[num].Name;
            this.textBox3.Text = studentList.Students[num].MiddleName;
            this.textBox4.Text = studentList.Students[num].Group;
            this.textBox5.Text = studentList.Students[num].SubGroup;
        }
    }
}
