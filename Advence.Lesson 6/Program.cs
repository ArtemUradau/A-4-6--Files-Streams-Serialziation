using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Runtime.Serialization.Formatters.Binary;

namespace Advence.Lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song = new Song();

            song.Title = "Bla";
            song.Duration = 114;
            song.Lyrics = "La la la leid";

            Console.WriteLine("Object created");

            XmlSerializer formatter = new XmlSerializer(typeof(Song));

            using (FileStream fs = new FileStream("d://song.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, song);
                Console.WriteLine("Object serealized");
            }

            using (FileStream fs = new FileStream("d://song.xml", FileMode.OpenOrCreate))
            {
                Song unxml = (Song)formatter.Deserialize(fs);
                Console.WriteLine("Object deserialized");
            }

            Console.ReadLine();
        }         
    }
}