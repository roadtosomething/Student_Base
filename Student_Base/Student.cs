﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Base
{
    public class Student
    {
        private int id;
        private string name;
        private string secondName;
        private string middleName;
        private string group;
        private string subgroup;
        private int curse;
        public Student(string name, string secondName, string middleName, string group,string subgroup, int curse,int id)
        {
            Id = id;
            Name = name;
            SecondName = secondName;
            MiddleName = middleName;
            Group = group;
            SubGroup = subgroup;
            Curse = curse;
        }
        public Student()
        {
            Name=null;
            SecondName=null;
            MiddleName=null;
            Group = null;
            SubGroup = null;
            Curse = 1;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name 
        { 
            get { return name; }
            set { name = value; }
        }
        public string SecondName { get { return secondName; } set { secondName = value; } }
        public string MiddleName { get { return middleName; } set { middleName = value; } }
        public string Group { get  { return group; } set { group = value; } }
        public string SubGroup { get { return subgroup; } set { subgroup = value; } }
        public int Curse { get { return curse; } set { curse = value; } }
    }

    public class StudentList
    {
        public List<Student> Students = new List<Student>();
    }
}
