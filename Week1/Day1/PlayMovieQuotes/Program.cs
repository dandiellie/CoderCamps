using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PlayMovieQuotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Random myRand = new Random();

            //check network connection
            if(NetworkInterface.GetIsNetworkAvailable()==false)
            {
                Console.WriteLine("Please check the Network Connection.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            //initialize an array of 3 .wav files
            SoundPlayer[] player = new SoundPlayer[3];
            player[0] = new SoundPlayer("http://www.wavsource.com/snds_2015-07-05_1837925197659629/movies/misc/shrek_tic_tacs.wav");
            player[1] = new SoundPlayer("http://www.wavsource.com/snds_2015-07-05_1837925197659629/movie_stars/schwarzenegger/deep_trouble.wav");
            player[2] = new SoundPlayer("http://www.wavsource.com/snds_2015-07-05_1837925197659629/movie_stars/grant/arsenic_insanity.wav");

            //make a random selection
            int selection = myRand.Next(3);
                
            //play the selected .wav file
            player[selection].PlaySync();
        }
    }
}
