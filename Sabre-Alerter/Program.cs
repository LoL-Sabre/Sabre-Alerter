using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;

namespace Sabre_Alerter
{
    class Program
    {
        static void Main(string[] args)
        {
            string versionToLookFor = Console.ReadLine();
            while(true)
            {
                using (WebClient wc = new WebClient())
                {
                    string versions = wc.DownloadString("http://l3cdn.riotgames.com/releases/pbe/projects/lol_game_client/releases/releaselisting_PBE");
                    if(versions.Contains(versionToLookFor))
                    {
                        Console.WriteLine(versionToLookFor);
                        System.Media.SystemSounds.Beep.Play();
                    }
                }
                Thread.Sleep(5000);
            }
        }
    }
}
