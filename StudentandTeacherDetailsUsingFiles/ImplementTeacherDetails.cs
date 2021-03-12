using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StudentandTeacherDetailsUsingFiles
{
    class ImplementTeacherDetails : TeacherDetails
    {
        public override string GetClassAndSession()
        {
            return ClassandSession;
        }

        public override string GetId()
        {
            return Id;
        }

        public override string GetName()
        {
            return Name;
        }

        public override void SetValues(string id, string name, string classandsession)
        {
            this.Id = id;
            this.Name = name;
            this.ClassandSession = classandsession;
        }

        public override void UpdateDetails(string id, string name, string classandsession)
        {
            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "\\TeacherDetails.txt";

            string[] contents = File.ReadAllLines(filename);
            StreamWriter writer = File.CreateText(filename);
            foreach (string content in contents)
            {

                string[] data = content.Split(", ");
                if (id == data[0])
                {
                    writer.WriteLine(id + ", " + name + ", " + classandsession);
                }
                else
                {
                    writer.WriteLine(data[0]+ ", " + data[1]+ ", " + data[2]);
                }
                
            }
            writer.Close();
        }
    }
}

      
