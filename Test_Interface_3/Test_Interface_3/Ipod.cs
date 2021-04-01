using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_3
{
    class Ipod : MusicFile, MusicPlayerInterface
    {
        public Ipod() { }
        public Ipod(string title, string artist, int yearOfRelease, int durationInSeconds):base(title, artist, yearOfRelease, durationInSeconds)
        {
            Title = title;
            Artist = artist;
            YearOfRelease = yearOfRelease;
            DurationInSeconds = durationInSeconds;
        }
        public void Play(bool on)
        {
            if (on)
            {
                Console.WriteLine("On");
            }
            else
            {
                Console.WriteLine("Off");
            }
        }

        public void PlayNext()
        {
            Console.WriteLine("Title {0} & Artist {1}", Title, Artist);
        }

        public void PlayPrevious()
        {
            Console.WriteLine("Title {0} & Artist {1}", Title, Artist);
        }

        public void SetVolume(int loudness)
        {
            Console.WriteLine("Loudness: " + loudness);
        }

        public void Switch(bool on)
        {
            if (on)
            {
                Console.WriteLine("On");
            }
            else
            {
                Console.WriteLine("Off");
            }
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Artist: " + Artist);
            Console.WriteLine("Year of Release: " + YearOfRelease);
            Console.WriteLine("Duration in Seconds: " + DurationInSeconds);
        }
    }
}
