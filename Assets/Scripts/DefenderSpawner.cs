using UnityEngine;
using System.Collections;

public class DefenderSpawner : MonoBehaviour {

	public Camera gameCamera;
	public float timeAfterDestroy = 10f;

	Ray ray;

	private Vector3 worldPoint;
	private float mouseX,mouseY;
	private GameObject Parent;
	private StarDisplay starDisplay;
	private enum Status {currentStatus};

	// Use this for initialization
	void Start () {
		starDisplay = GameObject.FindObjectOfType<StarDisplay>();
		Parent = GameObject.Find("Defenders");
		if(!Parent)
		{
			Parent = new GameObject("Defenders");
		}
	}

	// Update is called once per frame
	void Update () {
			mouseX = Input.mousePosition.x;
			mouseY = Input.mousePosition.y;
		worldPoint = gameCamera.ScreenToWorldPoint(new Vector3(mouseX,mouseY,0));
	}

	void OnMouseDown()
	{
		//Input.simulateMouseWithTouches = true;
		Vector2 rawPos = CameraScreenToWorldPoint();
		Vector2 roundedPos = SnapToGrid(rawPos);
		int defenderCost = Button.selectedDefender.GetComponent<Defenders>().starCost;
		if(starDisplay.UseStars(defenderCost) == StarDisplay.Status.SUCCESS)
		{
			GameObject Def = Instantiate(Button.selectedDefender, roundedPos, Quaternion.identity) as GameObject;
			Def.transform.parent = Parent.transform;
			if(Def.tag == "Defenders")
			{
				Destroy(Def, timeAfterDestroy);
			}
		}else{
			Debug.Log("Insufficient Stars");
		}
	}

	Vector2 SnapToGrid(Vector2 rawWorldPos)
	{
		int newX = Mathf.RoundToInt(rawWorldPos.x);
		int newY = Mathf.RoundToInt(rawWorldPos.y);
		return new Vector2(newX,newY);
	}

	Vector3 CameraScreenToWorldPoint()
	{
		return worldPoint;
	}
}
