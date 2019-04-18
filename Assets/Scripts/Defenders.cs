using UnityEngine;
using System.Collections;

public class Defenders : MonoBehaviour {

	private StarDisplay starDisplay;
	public int starCost = 10;

	// Use this for initialization
	void Start () {
		starDisplay = GameObject.FindObjectOfType<StarDisplay>();
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	void AddStars(int amount)
	{
		starDisplay.AddStars(amount);
	}
}
