using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBall : MonoBehaviour {

    public Material Mana;
    public Material Shield;
    public Material Power;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CreateObject(string name, string type, bool infinateUse) {
        if(type == "Power"){
            this.GetComponent<Renderer>().material = Power;
        }else if(type == "Shield") {
            this.GetComponent<Renderer>().material = Shield;
        } else if (type == "Mana") {
            this.GetComponent<Renderer>().material = Mana;
        }
    }
}
