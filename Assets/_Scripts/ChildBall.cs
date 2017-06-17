using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildBall : BaseBall {


    public string name, type;
    public bool canReUse;

    public GameObject Deck;
    public List<string> Deckname;

    public int randomnum;
	// Use this for initialization
	void Start () {
        Deckname = Deck.GetComponent<BaseDeck>().typeofpower;
        randomnum = Random.Range(0, Deckname.Count);
        CreateObject(name, Deckname[randomnum], canReUse);
    }
	
	// Update is called once per frame
	void Update () {
        
	}
}
