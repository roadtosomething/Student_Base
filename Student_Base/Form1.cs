using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Student_Base
{

    public partial class BaseForm : Form
    {
        private static DataWork dw = new DataWork();
        public StudentList studentList = dw.ImportData();
        public int studentNum=0;
        public int StudentNum()
        {
            return studentNum;
        }
        public BaseForm()
        {
            InitializeComponent();
            ShowInfo(studentNum, this.typeViewLabel.Text); 
    }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void InitializeComponent()
        {
            this.baseMenu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выгрузитьАктуальнуюИнформациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.secondNameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.midlleNameTextBox = new System.Windows.Forms.TextBox();
            this.groupTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstCourseRadioButtom = new System.Windows.Forms.RadioButton();
            this.secondCourseRadioButtom = new System.Windows.Forms.RadioButton();
            this.thirdCourseRadioButtom = new System.Windows.Forms.RadioButton();
            this.fourCOurseRadioButtom = new System.Windows.Forms.RadioButton();
            this.subGroupTextBox = new System.Windows.Forms.TextBox();
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
            this.baseMenu.Size = new System.Drawing.Size(458, 28);
            this.baseMenu.TabIndex = 0;
            this.baseMenu.Text = "Главное меню";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выгрузитьАктуальнуюИнформациюToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выгрузитьАктуальнуюИнформациюToolStripMenuItem
            // 
            this.выгрузитьАктуальнуюИнформациюToolStripMenuItem.Name = "выгрузитьАктуальнуюИнформациюToolStripMenuItem";
            this.выгрузитьАктуальнуюИнформациюToolStripMenuItem.Size = new System.Drawing.Size(347, 26);
            this.выгрузитьАктуальнуюИнформациюToolStripMenuItem.Text = "Выгрузить актуальную информацию";
            this.выгрузитьАктуальнуюИнформациюToolStripMenuItem.Click += new System.EventHandler(this.выгрузитьАктуальнуюИнформациюToolStripMenuItem_Click);
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
            this.магистратурыToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.магистратурыToolStripMenuItem.Text = "Магистратуры";
            this.магистратурыToolStripMenuItem.CheckedChanged += new System.EventHandler(this.магистратурыToolStripMenuItem_CheckedChanged);
            // 
            // бакалавриатаToolStripMenuItem
            // 
            this.бакалавриатаToolStripMenuItem.Checked = true;
            this.бакалавриатаToolStripMenuItem.CheckOnClick = true;
            this.бакалавриатаToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.бакалавриатаToolStripMenuItem.Name = "бакалавриатаToolStripMenuItem";
            this.бакалавриатаToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
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
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
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
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
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
            // secondNameTextBox
            // 
            this.secondNameTextBox.Location = new System.Drawing.Point(184, 66);
            this.secondNameTextBox.Name = "secondNameTextBox";
            this.secondNameTextBox.ReadOnly = true;
            this.secondNameTextBox.Size = new System.Drawing.Size(169, 22);
            this.secondNameTextBox.TabIndex = 5;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(184, 94);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(169, 22);
            this.nameTextBox.TabIndex = 6;
            // 
            // midlleNameTextBox
            // 
            this.midlleNameTextBox.Location = new System.Drawing.Point(184, 122);
            this.midlleNameTextBox.Name = "midlleNameTextBox";
            this.midlleNameTextBox.ReadOnly = true;
            this.midlleNameTextBox.Size = new System.Drawing.Size(169, 22);
            this.midlleNameTextBox.TabIndex = 7;
            // 
            // groupTextBox
            // 
            this.groupTextBox.Location = new System.Drawing.Point(184, 150);
            this.groupTextBox.Name = "groupTextBox";
            this.groupTextBox.ReadOnly = true;
            this.groupTextBox.Size = new System.Drawing.Size(169, 22);
            this.groupTextBox.TabIndex = 8;
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
            // firstCourseRadioButtom
            // 
            this.firstCourseRadioButtom.AutoSize = true;
            this.firstCourseRadioButtom.Enabled = false;
            this.firstCourseRadioButtom.Location = new System.Drawing.Point(184, 220);
            this.firstCourseRadioButtom.Name = "firstCourseRadioButtom";
            this.firstCourseRadioButtom.Size = new System.Drawing.Size(35, 20);
            this.firstCourseRadioButtom.TabIndex = 10;
            this.firstCourseRadioButtom.TabStop = true;
            this.firstCourseRadioButtom.Text = "1";
            this.firstCourseRadioButtom.UseVisualStyleBackColor = true;
            // 
            // secondCourseRadioButtom
            // 
            this.secondCourseRadioButtom.AutoSize = true;
            this.secondCourseRadioButtom.Enabled = false;
            this.secondCourseRadioButtom.Location = new System.Drawing.Point(225, 220);
            this.secondCourseRadioButtom.Name = "secondCourseRadioButtom";
            this.secondCourseRadioButtom.Size = new System.Drawing.Size(35, 20);
            this.secondCourseRadioButtom.TabIndex = 11;
            this.secondCourseRadioButtom.TabStop = true;
            this.secondCourseRadioButtom.Text = "2";
            this.secondCourseRadioButtom.UseVisualStyleBackColor = true;
            // 
            // thirdCourseRadioButtom
            // 
            this.thirdCourseRadioButtom.AutoSize = true;
            this.thirdCourseRadioButtom.Enabled = false;
            this.thirdCourseRadioButtom.Location = new System.Drawing.Point(266, 220);
            this.thirdCourseRadioButtom.Name = "thirdCourseRadioButtom";
            this.thirdCourseRadioButtom.Size = new System.Drawing.Size(35, 20);
            this.thirdCourseRadioButtom.TabIndex = 12;
            this.thirdCourseRadioButtom.TabStop = true;
            this.thirdCourseRadioButtom.Text = "3";
            this.thirdCourseRadioButtom.UseVisualStyleBackColor = true;
            // 
            // fourCOurseRadioButtom
            // 
            this.fourCOurseRadioButtom.AutoSize = true;
            this.fourCOurseRadioButtom.Enabled = false;
            this.fourCOurseRadioButtom.Location = new System.Drawing.Point(307, 220);
            this.fourCOurseRadioButtom.Name = "fourCOurseRadioButtom";
            this.fourCOurseRadioButtom.Size = new System.Drawing.Size(35, 20);
            this.fourCOurseRadioButtom.TabIndex = 13;
            this.fourCOurseRadioButtom.TabStop = true;
            this.fourCOurseRadioButtom.Text = "4";
            this.fourCOurseRadioButtom.UseVisualStyleBackColor = true;
            // 
            // subGroupTextBox
            // 
            this.subGroupTextBox.Location = new System.Drawing.Point(184, 179);
            this.subGroupTextBox.Name = "subGroupTextBox";
            this.subGroupTextBox.ReadOnly = true;
            this.subGroupTextBox.Size = new System.Drawing.Size(169, 22);
            this.subGroupTextBox.TabIndex = 15;
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
            this.prevButtom.Click += new System.EventHandler(this.prevButtom_Click);
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
            this.ClientSize = new System.Drawing.Size(458, 305);
            this.Controls.Add(this.nextButtom);
            this.Controls.Add(this.prevButtom);
            this.Controls.Add(this.viewDescription);
            this.Controls.Add(this.typeViewLabel);
            this.Controls.Add(this.subGroupTextBox);
            this.Controls.Add(this.subGroup);
            this.Controls.Add(this.fourCOurseRadioButtom);
            this.Controls.Add(this.thirdCourseRadioButtom);
            this.Controls.Add(this.secondCourseRadioButtom);
            this.Controls.Add(this.firstCourseRadioButtom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupTextBox);
            this.Controls.Add(this.midlleNameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.secondNameTextBox);
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
            ShowInfo(studentNum, this.typeViewLabel.Text);
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
            studentNum = 0;
            ShowInfo(studentNum,this.typeViewLabel.Text);
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForms addForm = new AddForms();
            addForm.Show();
        }
        private void nextButtom_Click(object sender, EventArgs e)
        {
            int num = GetNumStudents(dw.ImportData());
            if ( num== GetCount(dw.ImportData()))
            {
                num = 0;
                ShowInfo(num,this.typeViewLabel.Text);
            }
            else
            {
                ShowInfo(num+1,this.typeViewLabel.Text);
            }
        }

        public int GetNumStudents(StudentList targetTable)
        { 
                if (this.typeViewLabel.Text == "Бакалавриата")
                {
                    this.studentNum = targetTable.BStudents.Find(x =>
                    x.MiddleName.Contains(this.midlleNameTextBox.Text)
                    && x.Name.Contains(this.nameTextBox.Text)
                    && x.SecondName.Contains(this.secondNameTextBox.Text)).Id - 1;
                    return studentNum;
                }
                else
                {
                    this.studentNum = targetTable.MStudents.Find(x =>
                    x.MiddleName.Contains(this.midlleNameTextBox.Text)
                    && x.Name.Contains(this.nameTextBox.Text)
                    && x.SecondName.Contains(this.secondNameTextBox.Text)).Id - 1;
                    return studentNum;
                }

        }
        private int GetCount(StudentList targetTable)
        {
            if (this.typeViewLabel.Text == "Бакалавриата")
            {
                return targetTable.BStudents.Count - 1;
            }
            else
            {
                return targetTable.MStudents.Count - 1;
            }
        }

        public void ShowInfo(int num, string type)
        {
            int course;
            if (type == "Бакалавриата")
            {
                if (GetCount(studentList) >= 0)
                {
                    this.secondNameTextBox.Text = studentList.BStudents[num].SecondName;
                    this.nameTextBox.Text = studentList.BStudents[num].Name;
                    this.midlleNameTextBox.Text = studentList.BStudents[num].MiddleName;
                    this.groupTextBox.Text = studentList.BStudents[num].Group;
                    this.subGroupTextBox.Text = studentList.BStudents[num].SubGroup;
                    course = studentList.BStudents[num].Curse;
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
                else
                {
                    this.secondNameTextBox.Text = null;
                    this.nameTextBox.Text = null;
                    this.midlleNameTextBox.Text = null;
                    this.groupTextBox.Text = null;
                    this.subGroupTextBox.Text = null;
                    firstCourseRadioButtom.Checked = false;
                    secondCourseRadioButtom.Checked = false;
                    thirdCourseRadioButtom.Checked = false;
                    fourCOurseRadioButtom.Checked = false;
                }
            }
            else //if (type=="Магистратуры")
            {
                if (GetCount(studentList) >= 0)
                {
                    this.secondNameTextBox.Text = studentList.MStudents[num].SecondName;
                    this.nameTextBox.Text = studentList.MStudents[num].Name;
                    this.midlleNameTextBox.Text = studentList.MStudents[num].MiddleName;
                    this.groupTextBox.Text = studentList.MStudents[num].Group;
                    this.subGroupTextBox.Text = studentList.MStudents[num].SubGroup;
                    course = studentList.MStudents[num].Curse;
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
                else
                {
                    this.secondNameTextBox.Text = null;
                    this.nameTextBox.Text = null;
                    this.midlleNameTextBox.Text = null;
                    this.groupTextBox.Text = null;
                    this.subGroupTextBox.Text = null;
                    firstCourseRadioButtom.Checked = false;
                    secondCourseRadioButtom.Checked = false;
                    thirdCourseRadioButtom.Checked = false;
                    fourCOurseRadioButtom.Checked = false;
                }
            }

        }

        private void prevButtom_Click(object sender, EventArgs e)
        {
            studentNum = GetNumStudents(studentList);
            if (studentNum == 0)
            {
                studentNum=GetCount(studentList);
                ShowInfo(studentNum, this.typeViewLabel.Text);
            }
            else
            {
                ShowInfo(studentNum-1, this.typeViewLabel.Text);
            }

        }
        public void UpdateInfo()
        {
            this.studentList = dw.ImportData();
            ShowInfo(studentNum, this.typeViewLabel.Text);
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RedactorForm form = new RedactorForm(GetNumStudents(studentList));
            form.Show();
        }

        private void выгрузитьАктуальнуюИнформациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateInfo();
        }
        private void DeleteStudent (StudentList stl, int num)
        {
            if (this.typeViewLabel.Text == "Магистратуры")
            {
                stl.MStudents.Remove(stl.MStudents[num]);
                int i= 0;
                foreach (Student student in stl.MStudents)
                {
                    student.Id = i + 1;
                    i += 1;
                }
                dw.ExportData(stl);
            }
            else //if (this.typeViewLabel.Text=="Бакалавриата")
            {
                stl.BStudents.Remove(stl.BStudents[num]);
                int i = 0;
                foreach (Student student in stl.BStudents)
                {
                    student.Id = i + 1;
                    i += 1;
                }
                dw.ExportData(stl);
            }
            MessageBox.Show("Студент удален из списка студентов: " + this.typeViewLabel.Text);
            this.studentList = dw.ImportData();
            ShowInfo(studentNum, this.typeViewLabel.Text);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteStudent(studentList, GetNumStudents(studentList));
        }
    }
}
