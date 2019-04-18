using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LoaderScript : MonoBehaviour {

	private Slider loaderSlider;
	//private float sliderValue;

	public Text loadValue;
	public float loadTimeIncrement = 0.05f;


	// Use this for initialization
	void Start () {
		loaderSlider = GetComponent<Slider>();
		loaderSlider.value = 0;
		loadValue.text = "0";
	}
	
	// Update is called once per frame
	void Update () {
		float newValue = loaderSlider.value += loadTimeIncrement * Time.deltaTime;
		float myValue = newValue*100;
		int myNewValue = Mathf.RoundToInt(myValue);
		Debug.Log(myNewValue);
		loadValue.text = (myNewValue).ToString();
	}
}
