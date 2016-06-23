using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{
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

    public void switchToLensMenu()
    {
        lensMenu.SetActive(true);
        mainMenu.SetActive(false);
    }

    // Called by GazeGestureManager when the user performs a Select gesture
    public void OnSelect()
    {
        mainMenu.SetActive(false);
        lensMenu.SetActive(true);
    }
}
