using System;
using System.Collections.Generic;
using System.Media;
using UnityEngine;
using UnityEngine.UI;

public class Middle : MonoBehaviour
{
    public List<gameObject> pile = new List<gameObject>();
    public gameObject P1 = new Player();
    public gameObject P2 = new Player();
    public int turnInc = 1;
    public int turn = 1;
    public gameObject display1;
    public gameObject display2;

    void Start()
    {
        P1.DrawHand();
        P2.DrawHand();
    }

    void Update()
    {
        if (Deck.gameDeck.Count == 0)
        {
            Deck.Shuffle(pile);
        }

        if (P1.hand.Count < 1 && P1.drawn)
        {
            P1.score++;
            Reset();
        }
        if (P2.hand.Count < 1 && P2.drawn)
        {
            P2.score++;
            Reset();
        }
    }

    public void Reset()
    {
        turn = 1;
        turnInc = 1;
        P1.hand.Clear();
        P2.hand.Clear();
        P1.DrawHand();
        P2.DrawHand();
    }

    
}