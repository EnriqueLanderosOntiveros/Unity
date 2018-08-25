using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour {
    public int Lifepoints = 100;
    public Texture texto;
     void OnGUI()
    {
        GUILayout.Label(texto);
        GUILayout.Label("Tienes " + Lifepoints + "Lifepoints;");
    }
    public void ReduceLife()
    {
        Lifepoints = Lifepoints - 1;
    }
    void OnMouseDown()
    {
        this.ReduceLife();   
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
