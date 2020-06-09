using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCardScript : MonoBehaviour {

    public GameObject Card1;
    public GameObject Card2;
    public GameObject PlayerArea;
    public GameObject EnemyArea;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void onClick(){
        GameObject playerCard = Instantiate(Card1, new Vector3(0,0,0), Quaternion.identity);
        playerCard.transform.SetParent(PlayerArea.transform, false);
    }
}
