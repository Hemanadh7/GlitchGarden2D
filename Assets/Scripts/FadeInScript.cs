using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeInScript : MonoBehaviour {

	public Image fadePanel;
	public float fadeinDuration;

	void Update()
	{
		if(Time.time <= fadeinDuration + 3f)
		{
			fadePanel.CrossFadeAlpha(0f,fadeinDuration,true);
		}
		else
		{
			gameObject.SetActive(false);
		}
	}
}
