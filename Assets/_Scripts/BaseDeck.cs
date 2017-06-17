using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseDeck : MonoBehaviour {


    public List<string> typeofpower = new List<string>();
	// Use this for initialization
	void Start () {
        typeofpower.Add("damage");
        typeofpower.Add("shield");
        typeofpower.Add("damage");
        typeofpower.Add("shield");
        typeofpower.Add("damage");
        typeofpower.Add("shield");
        typeofpower.Add("damage");
        typeofpower.Add("shield");
        typeofpower.Add("damage");
        typeofpower.Add("shield");
        typeofpower.Add("mana");
        typeofpower.Add("mana");
        typeofpower.Add("mana");
        typeofpower.Add("mana");
        typeofpower.Add("mana");
        typeofpower.Add("mana");
        typeofpower.Add("mana");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
