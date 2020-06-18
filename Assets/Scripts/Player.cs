
//possible to create a program that can add cards to gameplay by taking into account color, number / image, 
//and then placing it over a blank tempelate

using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{

    public int score = 0;
    public List<gameObject> hand = new List<gameObject>();
    private bool drawn = false;

    
   
    

    public void Update()
    {
        if (hand.Count < 1 && drawn)
        {
            score++;
        }
    }

    public void Start() {
        //SetDeck();
        DrawHand();
    }
    
    
    /*
    public void SetDeck(Deck d)
    {
        this.deck = d;
    }
    */

    public void DrawHand()
    {
        for (int x = 0; x < 7; x++)
        {
            Draw();
        }
        drawn = true;
    }

    public void Draw()
    {
        hand.Add(Deck.getRandomCard());
    }

}

    

