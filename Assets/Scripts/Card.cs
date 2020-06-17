using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Card : MonoBehaviour
{
    private Image myImage;
    public string color;
    public Text myText;

    public void Awake()
    {
        myImage = GetComponent<Image>();
        
    }

    public void SetUpCard(string name, Color color) {
        myText.text = name;
        myImage.color = color;
    }

    public void Copy(BackCard c)
    {
        myText.text = c.name;
        color = c.color;
    }

    public void Swap(string color)
    {
        this.color = color;
    }

    public string Name()
    {
        return myText.text;
    }

    public bool Equals(Card c)
    {
        if (Name().Equals(c.Name()) || color.Equals(c.color))
            return true;
        else
            return false;
    }
}

