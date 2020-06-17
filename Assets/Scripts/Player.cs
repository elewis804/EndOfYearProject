
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
    public List<Card> hand = new List<Card>();
    public Deck deck = new Deck();
    

        //SHOULD THE DECK OBJECT STILL EXIST? MIGHT BE POSSIBLE TO STILL HAVE PLAYERS SHARE THE SAME DECK IF
        //I 
    

    public void Update()
    {

    }

    public void Start() {
        SetDeck();
    }
    
    

    public void SetDeck()
    {
        
    }


    public void DrawHand(Deck d)
    {
        for (int x = 0; x < 7; x++)
        {
            Draw(d);
        }
    }

    public void Draw()
    {
        hand.Add(getRandomCard());
    }

}

    

