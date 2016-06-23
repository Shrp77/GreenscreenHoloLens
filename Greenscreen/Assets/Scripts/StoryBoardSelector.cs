using UnityEngine;
using System.Collections;

public class StoryBoardSelector : MonoBehaviour {

	public Material NonSelectedMaterial;
	public Material SelectedMaterial;

	private Renderer myRenderer;

	void Start()
	{
		myRenderer = GetComponent<Renderer> ();
		myRenderer.material = NonSelectedMaterial;
	}

	void OnSelect()
	{
		myRenderer.material = SelectedMaterial;
	}

	void UnselectAll()
	{
		myRenderer.material = NonSelectedMaterial;
	}
}
