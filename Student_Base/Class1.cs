using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Base
{
    internal class DataWork
    {
        
        public StudentList ImportData()
        {
            FileStream file = new FileStream("StudentXMLFile.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(StudentList));
            StudentList studentList = new StudentList();
            studentList = (StudentList)xmlSerializer.Deserialize(file);
            file.Close();
            return studentList;
        }

        public void ExportData(StudentList target)
        {
            System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(StudentList));
            StreamWriter sw = new StreamWriter("StudentXMLFile.xml", false);
            xmlSerializer.Serialize(sw, target);
            sw.Close();
        }
    }
}
