using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_3
{
    abstract class MusicFile
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public int YearOfRelease { get; set; }
        public int DurationInSeconds { get; set; }
        public MusicFile() { }
        public MusicFile(string title,string artist,int yearOfRelease,int durationInSeconds)
        {
            Title = title;
            Artist = artist;
            YearOfRelease = yearOfRelease;
            DurationInSeconds = durationInSeconds;
        }
        public void ChangeTitle(string title)
        {
            Console.WriteLine("Title: " + title);
        }
        virtual public void ShowInfo()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Artist: " + Artist);
            Console.WriteLine("Year of Release: " + YearOfRelease);
            Console.WriteLine("Duration in Seconds: " + DurationInSeconds);
        }
    }
}
