using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Card : MonoBehaviour
{
    private Image myImage;
   
    public Text myText;

    public void Awake()
    {
        myImage = GetComponent<Image>();
        
    }

    public void SetUpCard(string name, Color color) {
        myText.text = name;
        myImage.color = color;
        
    }

    public string Name()
    {
        return myText.text;
    }

    public bool Equals(Card c)
    {
        if (Name().Equals(c.Name()) || myImage.color == c.myImage.color)
            return true;
        else
            return false;
    }
}

