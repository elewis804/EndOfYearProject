using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class RunGame : MonoBehaviour
{
    public List<gameObject> deck = new List<gameObject>();
    public int turnInc = 1;
    public int turn = 1;


	void Start()
    {
        foreach (Transform t in GameObject.Find("Cards").transform)
        {
            deck.Add(t.gameObject);
        }


        
        ButtonScript.SetDeck(d);

    }
}