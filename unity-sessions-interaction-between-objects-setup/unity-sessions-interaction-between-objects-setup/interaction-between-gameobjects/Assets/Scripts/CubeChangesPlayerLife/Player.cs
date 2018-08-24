using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public int life = 10;
    public Texture tex;
        

        void OnGUI()
        {
            GUI.Label(new Rect(10, 10, 100, 50), new GUIContent("Player: "+life, tex));
        }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
