﻿using System;

namespace VariableOpdracht2
{
    internal class Program
    {
        //class variables & gebruik
        static void Main(string[] args)
        {

            //ga naar de file TwitchStream.cs in je solution explorer in visual studio
            TwitchStream twitchStream = new TwitchStream();

            //geef nu de stream de volgende waardes:
            //name, waarde: je favoriete streamer
            //lastStreamName, waarde: de streamname van de laatste keer
            //streamGame, waarde een nieuwe instance van Game (new Game("naam van de game hier"})
            //followers, waarde: hoeveel followers
            //automod, waarde: staat automod aan?

            twitchStream.StreamName = "Dumbasses play Apex legends once more";
            twitchStream.LastStreamName = "We getting dubs (No we aren't)";
            twitchStream.StreamGame = new Game("ApexLegends");
            twitchStream.Followers = 36;
            twitchStream.Automod = true;
        }
    }
}