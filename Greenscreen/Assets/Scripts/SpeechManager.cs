using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class SpeechManager : MonoBehaviour
{
    public GameObject StoryBoard;
    public GameObject AssetsBoard;
	public GameObject Stage;
    private KeywordRecognizer keywordRecognizer;
    private readonly Dictionary<string, Action> keywords = new Dictionary<string, Action>();

    public GameObject Lens18mm;
    public GameObject Lens21mm;
    public GameObject Lens28mm;
    public GameObject Lens35mm;
    public GameObject Lens50mm;
    public GameObject Lens85mm;

    // Use this for initialization
    private void Start()
    {
        keywords.Add("Place Story Board", PlaceStoryBoard);
        keywords.Add("Place Assets Board", PlaceAssetsBoard);
        keywords.Add("Place Stage", PlaceStage);

        keywords.Add("Lens 18", Set18mmLens);
        keywords.Add("Lens 21", Set21mmLens);
        keywords.Add("Lens 28", Set28mmLens);
        keywords.Add("Lens 35", Set35mmLens);
        keywords.Add("Lens 50", Set50mmLens);
        keywords.Add("Lens 85", Set85mmLens);
        keywords.Add("Lens Menu", ShowLensMenu);


        keywordRecognizer = new KeywordRecognizer(keywords.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += KeywordRecognizer_OnPhraseRecognized;
        keywordRecognizer.Start();
    }

    private void Set18mmLens()
    {
        Lens18mm.SetActive(true);
        Lens21mm.SetActive(false);
        Lens28mm.SetActive(false);
        Lens35mm.SetActive(false);
        Lens50mm.SetActive(false);
        Lens85mm.SetActive(false);
    }

    private void Set21mmLens()
    {
        Lens18mm.SetActive(false);
        Lens21mm.SetActive(true);
        Lens28mm.SetActive(false);
        Lens35mm.SetActive(false);
        Lens50mm.SetActive(false);
        Lens85mm.SetActive(false);
    }

    private void Set28mmLens()
    {
        Lens18mm.SetActive(false);
        Lens21mm.SetActive(false);
        Lens28mm.SetActive(true);
        Lens35mm.SetActive(false);
        Lens50mm.SetActive(false);
        Lens85mm.SetActive(false);
    }

    private void Set35mmLens()
    {
        Lens18mm.SetActive(false);
        Lens21mm.SetActive(false);
        Lens28mm.SetActive(false);
        Lens35mm.SetActive(true);
        Lens50mm.SetActive(false);
        Lens85mm.SetActive(false);
    }

    private void Set50mmLens()
    {
        Lens18mm.SetActive(false);
        Lens21mm.SetActive(false);
        Lens28mm.SetActive(false);
        Lens35mm.SetActive(false);
        Lens50mm.SetActive(true);
        Lens85mm.SetActive(false);
    }

    private void Set85mmLens()
    {
        Lens18mm.SetActive(false);
        Lens21mm.SetActive(false);
        Lens28mm.SetActive(false);
        Lens35mm.SetActive(false);
        Lens50mm.SetActive(false);
        Lens85mm.SetActive(true);
    }

    private void KeywordRecognizer_OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        Action keywordAction;
        if (keywords.TryGetValue(args.text, out keywordAction))
        {
            keywordAction.Invoke();
        }
    }

    private void PlaceStoryBoard()
    {
		PlaceObject (StoryBoard);
	}

    private void PlaceAssetsBoard()
    {
		PlaceObject (AssetsBoard);
	}

    private void PlaceStage()
    {
		PlaceObject (Stage);
    }

	private void PlaceObject(GameObject go)
	{
		var headPosition = Camera.main.transform.position;
		var gazeDirection = Camera.main.transform.forward;

		RaycastHit hitInfo;
		if (Physics.Raycast (headPosition, gazeDirection, out hitInfo)) 
		{
			go.transform.position = hitInfo.point;
			go.transform.rotation = Quaternion.FromToRotation (Vector3.up, hitInfo.normal);
			go.SetActive (true);
		} 
	}

    private void ShowLensMenu()
    {
    }
}