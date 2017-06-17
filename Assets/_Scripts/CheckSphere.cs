using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckSphere : MonoBehaviour {
    public TextMeshProUGUI TypeArea;
    public TextMeshProUGUI NameArea;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.F1)) {
           // Application.CaptureScreenshot("H:\Pics\ScreenShot.png");
            Debug.Log("Took ScreenShot");
        }
	}

    public void OnTriggerEnter(Collider other) {
        if(other.tag == "Player") {
            TypeArea.text = "Type: " + this.GetComponent<ChildBall>().type.ToString();
            NameArea.text = "Name: " + this.GetComponent<ChildBall>().name.ToString();
        }
    }

    public void OnTriggerExit(Collider other) {
        if (other.tag == "Player") {
            TypeArea.text = "";
            NameArea.text = "";
        }
    }
}
