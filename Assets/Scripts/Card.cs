using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//possible to create a program that can add cards to gameplay by taking into account color, number / image, 
//and then placing it over a blank tempelate


public class Card : MonoBehaviour
{
    private Image myImage;
    public string effect;
    public Text myText;

    public void Awake()
    {
        myImage = GetComponent<Image>();
        
    }

    public void SetUpCard(string name, Color color, string effect) {
        myText.text = name;
        myImage.color = color;
        this.effect = effect;
    }

    public string Name()
    {
        return myText.text;
    }
}

