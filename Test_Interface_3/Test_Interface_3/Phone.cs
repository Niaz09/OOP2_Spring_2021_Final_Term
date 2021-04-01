using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_3
{
    class Phone : MusicFile, MusicPlayerInterface, RadioPlayerInterface
    {
        

        public Phone() { }
        public Phone(string title, string artist, int yearOfRelease, int durationInSeconds):base(title,artist,yearOfRelease,durationInSeconds)
        {
            Title = title;
            Artist = artist;
            YearOfRelease = yearOfRelease;
            DurationInSeconds = durationInSeconds;
            

        }
        public void ChangeChannel()
        {
            Console.WriteLine("Channel has been changed");

        }

        public void Play(bool on)
        {
            bool off = false;
            if (off)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(on);
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

        public void Retune(double frequency)
        {
            Console.WriteLine("Frequency: " + frequency);
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
