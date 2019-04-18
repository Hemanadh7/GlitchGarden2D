using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour {

	private Text starText;
	private int stars = 100;
	public enum Status {SUCCESS,FAILURE};

	// Use this for initialization
	void Start () {
		starText = GetComponent<Text>();
		starText.text = stars.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public Status UseStars(int amount)
	{
		if(stars >= amount)
		{
			stars -= amount;
			UpdateDisplay();
			return Status.SUCCESS;
		}
		return Status.FAILURE;
	}

	public void AddStars(int amount)
	{
		stars += amount;
		UpdateDisplay();
	}

	private void UpdateDisplay()
	{
		starText.text = stars.ToString();
	}
}
