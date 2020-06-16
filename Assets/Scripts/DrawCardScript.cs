using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCardScript : MonoBehaviour {

    public GameObject Card;
    public GameObject PlayerArea;
    public GameObject EnemyArea;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void onClick(){
        GameObject playerCard = Instantiate(Card, new Vector3(0,0,0), Quaternion.identity);
        Card c = playerCard.GetComponent<Card>();
        c.SetUpCard("Seven", Color.blue,null);
        playerCard.transform.SetParent(PlayerArea.transform, false);
    }
}
