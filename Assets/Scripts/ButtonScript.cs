using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour {

    public GameObject Card;
    public GameObject PlayerArea;
    public GameObject EnemyArea;
    public GameObject CardArea;
    public GameObject playerCard;
    public Deck d;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    /*
     * No reason to implement this method now that Deck lists are static
     * 
    public void SetDeck(Deck deck)
    {
        d = deck;
    }
    */
    public void onDrawClick(){
        GameObject playerCard = Instantiate(Card, new Vector3(0, 0, 0), Quaternion.identity);
        Card c = playerCard.GetComponent<Card>();
        c.SetUpCard("Seven", Color.blue);
        playerCard.transform.SetParent(PlayerArea.transform, false);
    }

    public void onPlayClick()
    {
        playerCard.transform.SetParent(CardArea.transform, false);
    }
}
