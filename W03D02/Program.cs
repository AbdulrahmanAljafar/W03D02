using System;
using System.IO;
using System.Text;

namespace W03D02
{
   /* class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\abdul\OneDrive\سطح المكتب\abdulrahman\hi22.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
                TextWriter tw = new StreamWriter(path);
                tw.WriteLine("The very first line!");
                tw.Close();
            }
            else if (File.Exists(path))
            {
                TextWriter tw = new StreamWriter(path);
                tw.WriteLine("The next line!");
                tw.Close();
            }
        }
    }*/

    class ConsoleApplication
    {
        const string fileName = "C:\\Users\\abdul\\student.std";

        static void Main()
        {
            WriteDefaultValues();
            DisplayValues();
        }

        public static void WriteDefaultValues()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                writer.Write("63 68");
                writer.Write("Abdulrahman");
                writer.Write(25);
                writer.Write("2.97/4");
                writer.Write(true);
            }
        }

        public static void DisplayValues()
        {
            string id_number;
            string name;
            int age;
            string GPA;
            bool showStatusBar;

            if (File.Exists(fileName))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
                {

                    id_number = reader.ReadString();
                    name = reader.ReadString();
                    age = reader.ReadInt32();
                    GPA= reader.ReadString();
                    showStatusBar = reader.ReadBoolean();
                }

                Console.WriteLine( id_number);
                Console.WriteLine( name);
                Console.WriteLine( age);
                Console.WriteLine(GPA);
                Console.WriteLine("Show status bar: " + showStatusBar);
            }
        }
    }
}
