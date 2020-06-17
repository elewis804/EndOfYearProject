//possible to create a program that can add cards to gameplay by taking into account color, number / image, 
//and then placing it over a blank tempelate

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Deck : MonoBehaviour
{
    public List<Card> deck = new List<Card>();
    public Deck()
    {
        for (int x = 0; x < 10; x++)
        {
            if (x == 0)
            {
                deck.Add(new Card((string)x.ToString(), Color.blue));
                deck.Add(new Card((string)x.ToString(), Color.red ));
                deck.Add(new Card((string)x.ToString(), Color.yellow ));
                deck.Add(new Card((string)x.ToString(), Color.green ));
            }
            else
            {
                for (int y = 0; y < 2; y++)
                {
                    deck.Add(new Card((string)x.ToString(), Color.blue ));
                    deck.Add(new Card((string)x.ToString(), Color.red ));
                    deck.Add(new Card((string)x.ToString(), Color.yellow ));
                    deck.Add(new Card((string)x.ToString(), Color.green ));
                }
            }
        }

        for (int x = 0; x < 2; x++)
        {
            deck.Add(new Card("Draw2", Color.blue);
            deck.Add(new Card("Draw2", Color.green));
            deck.Add(new Card("Draw2", Color.yellow));
            deck.Add(new Card("Draw2", Color.red));

            deck.Add(new Card("Reverse", Color.blue));
            deck.Add(new Card("Reverse", Color.red));
            deck.Add(new Card("Reverse", Color.green));
            deck.Add(new Card("Reverse", Color.yellow));

            deck.Add(new Card("Skip", Color.blue));
            deck.Add(new Card("Skip", Color.red);
            deck.Add(new Card("Skip", Color.yellow));
            deck.Add(new Card("Skip", Color.green));
        }

        deck.Add(new Card("Draw4",Color.black));
        deck.Add(new Card("Draw4",Color.black));
        deck.Add(new Card("Draw4", Color.black));
        deck.Add(new Card("Draw4", Color.black));

        deck.Add(new Card("Draw2", Color.black));
        deck.Add(new Card("Draw2", Color.black));
        deck.Add(new Card("Draw2", Color.black));
        deck.Add(new Card("Draw2", Color.black));
    }

    public Card getRandomCard()
    {
        Random x = new Random();
        Card y = deck[x.Next(0, 108)];
        deck.Remove(y);
        return y;
    }

    
}
