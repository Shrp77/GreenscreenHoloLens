using UnityEngine;
using System.Collections;

public class LensMenu : MonoBehaviour
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

    public void switchToMainMenu()
    {
        lensMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void OnSelect()
    {
        lensMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void changeTo16mm()
    {
        Debug.Log("Switching to 16 mm");
    }

    public void changeTo21mm()
    {
        Debug.Log("Switching to 21 mm");
    }

    public void changeTo28mm()
    {
        Debug.Log("Switching to 28 mm");
    }

    public void changeTo35mm()
    {
        Debug.Log("Switching to 35 mm");
    }

    public void changeTo50mm()
    {
        Debug.Log("Switching to 50 mm");
    }

    public void changeTo85mm()
    {
        Debug.Log("Switching to 85 mm");
    }
}
