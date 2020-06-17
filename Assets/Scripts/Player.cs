
//possible to create a program that can add cards to gameplay by taking into account color, number / image, 
//and then placing it over a blank tempelate

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;



    public class Player : MonoBehaviour
    {
        public int score = 0;
        public List<Card> hand = new List<Card>();
        
        public Player(Deck d)
        {
            for (int x = 0; x < 7; x++)
            {
                Draw(d);
            }
        }

        public void Draw(Deck deck)
        {
           // hand.Add(deck.getRandomCard());
        }

        public static void Main()
        {
            Deck d = new Deck();
            Player p = new Player(d);
            //To do - learn foreach loops and implement a test to print all the card names in a player's hand
            foreach (Card c in p.hand)
            {
                Console.WriteLine(c.Name());
            }
        }

    }


