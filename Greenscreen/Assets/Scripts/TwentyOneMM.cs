﻿using UnityEngine;
using System.Collections;

public class TwentyOneMM : MonoBehaviour {

    public GameObject mainMenu;
    public GameObject lensMenu;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnSelect()
    {
        Debug.Log("Switching to 21 mm");
        lensMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
}
