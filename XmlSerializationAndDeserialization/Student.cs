using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlSerializationAndDeserialization
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }

        public static void ToXML(Student student, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Student));

            FileStream fileStream = new FileStream(filePath, FileMode.Create);
            serializer.Serialize(fileStream, student);
            fileStream.Close();

        }

        public static Student XMLToObject(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Student));
            FileStream fileStream = new FileStream(filePath, FileMode.Open);
            return (Student)serializer.Deserialize(fileStream);

        }

    }
   
}
