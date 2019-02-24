using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.Win32;

namespace Advence.Lesson_6
{
    public partial class Practice
    {
        /// <summary>
        /// AL6-P1/7-DirInfo. Вывести на консоль следующую информацию о каталоге “c://Program Files”:
        /// Имя
        /// Дата создания
        /// </summary>
        public static void AL6_P1_7_DirInfo()
        {   
                        var dirInfo = new DirectoryInfo("C://Program Files");
                        Console.WriteLine(dirInfo.Name);
                        Console.WriteLine(dirInfo.CreationTime);
        }


        /// <summary>
        /// AL6-P2/7-FileInfo. Получить список файлов каталога и для каждого вывести значение:
        /// Имя
        /// Дата создания
        /// Размер 
        /// </summary>
        public static void AL6_P2_7_FileInfo()
        {
            var dirInfo = new DirectoryInfo("d://ITAcademy/03-12-2018/GIT/A-4(6)-Files, Streams, Serialziation/Advence.Lesson 6");
            var files = dirInfo.GetFiles("*.cs");
            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine(files[i].Name);
                Console.WriteLine(files[i].CreationTime);
                Console.WriteLine(files[i].Length);
            }
        }

        /// <summary>
        /// AL6-P3/7-CreateDir. Создать пустую директорию “c://Program Files Copy”.
        /// </summary>
        public static void AL6_P3_7_CreateDir()
        {
            var dir = Directory.CreateDirectory("c://Program Files Copy34");
            Console.WriteLine(dir.Name);
            Console.WriteLine(dir.CreationTime);
        }


        /// <summary>
        /// AL6-P4/7-CopyFile. Скопировать первый файл из Program Files в новую папку.
        /// </summary>
        public static void AL6_P4_7_CopyFile()
        {
            var dirInfo = new DirectoryInfo("d://ITAcademy/03-12-2018/GIT/A-4(6)-Files, Streams, Serialziation/Advence.Lesson 6");
            var files = dirInfo.GetFiles("*.cs");
            files[0].CopyTo("c://Program Files Copy34/" + files[0].Name);
        }

        /// <summary>
        /// AL6-P5/7-FileChat. Написать программу имитирующую чат. 
        /// Пускай в ней будут по очереди запрашивается реплики для User 1 и User 2 (используйте цикл из 5-10 итераций).  Сохраняйте данные реплики с ником пользователя и датой в файл на диске.
        /// </summary>
        public static void AL6_P5_7_FileChat()
        {
            for (int i = 0; i < 10; i++)
            {
                string s;
                if (i%2 == 0) Console.Write("User 1: ");
                else Console.Write("User 2: ");
                s = Console.ReadLine();

                var adapter = new StreamWriter("D://History.txt", true);
                adapter.Write(DateTime.Now.ToShortDateString());
                adapter.Write(" ");
                if (i%2 == 0) adapter.Write("User 1: ");
                else adapter.Write("User 2: ");
                adapter.Write(s);
                adapter.WriteLine();
                adapter.Close();
               


            }
        }

        /// <summary>
        /// AL6-P6/7-ConsoleSrlz. (Демонстрация). 
        /// Сериализовать обьект класса Song в XML.Вывести на консоль.
        /// Десериализовать XML из строковой переменной в объект.
        /// </summary>
        public static void AL6_P6_7_ConsoleSrlzn()
        {
            Song song = new Song()
            {
                Title = "Title 1",
                Duration = 247,
                Lyrics = "Lyrics 1"
            };
           
        }

        /// <summary>
        /// AL6-P7/7-FileSrlz.
        /// Отредактировать предыдущий пример для поддержки сериализации и десериализации в файл.
        /// </summary>
        public static void AL6_P7_7_FileSrlz()
        {

        }

    }
}
