//possible to create a program that can add BackCards to gameplay by taking into account color, number / image, 
//and then placing it over a blank tempelate

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Deck : MonoBehaviour
{
    public static List<BackCard> deck = new List<BackCard>();
    public void Start()
    {
        for (int x = 0; x < 10; x++)
        {
            if (x == 0)
            {
                deck.Add(new BackCard((string)x.ToString(), "blue"));
                deck.Add(new BackCard((string)x.ToString(), "red" ));
                deck.Add(new BackCard((string)x.ToString(), "yellow" ));
                deck.Add(new BackCard((string)x.ToString(), "green" ));
            }
            else
            {
                for (int y = 0; y < 2; y++)
                {
                    deck.Add(new BackCard((string)x.ToString(), "blue" ));
                    deck.Add(new BackCard((string)x.ToString(), "red" ));
                    deck.Add(new BackCard((string)x.ToString(), "yellow" ));
                    deck.Add(new BackCard((string)x.ToString(), "green" ));
                }
            }
        }

        for (int x = 0; x < 2; x++)
        {
            deck.Add(new BackCard("Draw2", "blue"));
            deck.Add(new BackCard("Draw2", "green"));
            deck.Add(new BackCard("Draw2", "yellow"));
            deck.Add(new BackCard("Draw2", "red"));

            deck.Add(new BackCard("Reverse", "blue"));
            deck.Add(new BackCard("Reverse", "red"));
            deck.Add(new BackCard("Reverse", "green"));
            deck.Add(new BackCard("Reverse", "yellow"));

            deck.Add(new BackCard("Skip", "blue"));
            deck.Add(new BackCard("Skip", "red"));
            deck.Add(new BackCard("Skip", "yellow"));
            deck.Add(new BackCard("Skip", "green"));
        }

        deck.Add(new BackCard("Draw4",null));
        deck.Add(new BackCard("Draw4",null));
        deck.Add(new BackCard("Draw4", null));
        deck.Add(new BackCard("Draw4", null));

        deck.Add(new BackCard("Draw2", null));
        deck.Add(new BackCard("Draw2", null));
        deck.Add(new BackCard("Draw2", null));
        deck.Add(new BackCard("Draw2", Color.black));
    }

    public Card getRandomCard()
    {
        Random x = new Random();
        BackCard y = deck[x.Next(0, 108)];
        deck.Remove(y);
        return y;
    }

    
}
