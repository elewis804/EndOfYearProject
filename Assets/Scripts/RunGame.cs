using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class RunGame : MonoBehaviour
{
    public List<gameObject> deck = new List<gameObject>();
    


	void Start()
    {
       
        
        ButtonScript.SetDeck(d);

    }
}