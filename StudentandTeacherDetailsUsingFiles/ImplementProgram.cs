using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StudentandTeacherDetailsUsingFiles
{
    class ImplementProgram : ImplementTeacherDetails
    {
        public static void Do()
        {
            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "\\TeacherDetails.txt";
            Console.WriteLine(filename);
            if (!(File.Exists(filename)))
            {
                Console.WriteLine("File doesn't exist");
            }
            else
            {
                Console.WriteLine("File exists");

                string[] contents = File.ReadAllLines(filename);
                Console.WriteLine("-----------------------------Teachers Details Before Updation-----------------------------");
                foreach (var content in contents)
                {
                    string[] data = content.Split(", ");
                    ImplementTeacherDetails teacherDetails = new ImplementTeacherDetails();
                    teacherDetails.SetValues(data[0],data[1],data[2]);
                    Console.WriteLine("\n ID:" + data[0] + ", Name:" + data[1] + ", Class And Session:" + data[2]);
                }
                Console.WriteLine("------------------------------------------------------------------------------------------");
                Console.WriteLine("Enter the Id of the teacher to be updated");
                string id1 = Console.ReadLine();
                Console.WriteLine("Enter the Name, Class and session of the teacher to be upadated");
                string name1 = Console.ReadLine();
                string class1 = Console.ReadLine();
                ImplementTeacherDetails teacherDetails1 = new ImplementTeacherDetails();
                teacherDetails1.UpdateDetails(id1, name1, class1);

                Console.WriteLine("-----------------------------Teachers Details After Updation------------------------------");
                string[] contents1 = File.ReadAllLines(filename);
                foreach (var content1 in contents1)
                {
                    string[] data = content1.Split(", ");
                    Console.WriteLine("\n ID:" + data[0] + ", Name:" + data[1] + ", Class And Session:" + data[2]);
                }
                Console.WriteLine("------------------------------------------------------------------------------------------");
            }
        }
    }
}
