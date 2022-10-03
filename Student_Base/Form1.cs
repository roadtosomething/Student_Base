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
        private DataWork dw = new DataWork();
        public BaseForm()
        {
            InitializeComponent();
            ShowInfo(0);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            this.studentData = new System.Data.DataSet();
            this.baseMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentData)).BeginInit();
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
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // просмотрToolStripMenuItem
            // 
            this.просмотрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вЫбратьСтудентовToolStripMenuItem});
            this.просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            this.просмотрToolStripMenuItem.Size = new System.Drawing.Size(94, 26);
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
            this.студентToolStripMenuItem.Size = new System.Drawing.Size(76, 26);
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
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
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
            // studentData
            // 
            this.studentData.DataSetName = "StudentData";
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
            ((System.ComponentModel.ISupportInitialize)(this.studentData)).EndInit();
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

            int num = GetNumStudents(dw.ImportData());
            if ( num== GetCount(dw.ImportData()))
            {
                num = 0;
                ShowInfo(num);
            }
            else
            {
                ShowInfo(num+1);
            }
        }

        private int GetNumStudents(StudentList targetTable)
        { 
            return targetTable.Students.Find(x =>
            x.MiddleName.Contains(this.midlleNameTextBox.Text)
            && x.Group.Contains(this.groupTextBox.Text)
            && x.Name.Contains(this.nameTextBox.Text)
            && x.SecondName.Contains(this.secondNameTextBox.Text)
            && x.SubGroup.Contains(this.subGroupTextBox.Text)).Id-1;
        }
        private int GetCount(StudentList targetTable)
        {
            return targetTable.Students.Count-1;
        }

        private void ShowInfo(int num)
        {
            StudentList studentList = dw.ImportData();
            this.secondNameTextBox.Text = studentList.Students[num].SecondName;
            this.nameTextBox.Text = studentList.Students[num].Name;
            this.midlleNameTextBox.Text = studentList.Students[num].MiddleName;
            this.groupTextBox.Text = studentList.Students[num].Group;
            this.subGroupTextBox.Text = studentList.Students[num].SubGroup;
            int course = studentList.Students[num].Curse;
            switch (course)
            {
                case 1:
                    firstCourseRadioButtom.Checked = true;
                    break;
                case 2:
                    secondCourseRadioButtom.Checked= true;
                    break;
                case 3:
                    thirdCourseRadioButtom.Checked= true;
                    break;
                case 4:
                    fourCOurseRadioButtom.Checked= true;
                    break;

            }

        }

        private void prevButtom_Click(object sender, EventArgs e)
        {
            int num = GetNumStudents(dw.ImportData());
            if (num == 0)
            {
                num=GetCount(dw.ImportData());
                ShowInfo(num);
            }
            else
            {
                ShowInfo(num-1);
            }

        }
    }
}
