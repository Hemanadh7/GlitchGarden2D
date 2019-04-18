using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Button : MonoBehaviour {

	public GameObject defenderPrefab;
	public static GameObject selectedDefender;

	private Text costText;
	private Button[] buttonArray;

	// Use this for initialization
	void Start () {
		buttonArray = GameObject.FindObjectsOfType<Button>();
		costText = GetComponentInChildren<Text>();
		costText.text = defenderPrefab.GetComponent<Defenders>().starCost.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnMouseDown()
	{
		foreach (Button thisButton in buttonArray)
		{
			thisButton.GetComponent<SpriteRenderer>().color = Color.black;
		}

		SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
		spriteRenderer.color = Color.white;
		selectedDefender = defenderPrefab;
	}
}
