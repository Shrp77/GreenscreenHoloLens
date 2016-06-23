using UnityEngine;
using System.Collections;

public class Scene1 : MonoBehaviour {

    public Material scene1;
    //public GameObject greenScreen;
    //public GreenScreen g1;
    public GameObject g1;

    // Use this for initialization
    void Start () {
        //g1 = GreenScreen.GetInstance();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnSelect()
    {
        //g1.swapMaterial(scene1);
        g1.GetComponent<Renderer>().material = scene1;
    }
}
