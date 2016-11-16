using UnityEngine;
using System.Collections;

public class HeadBob : MonoBehaviour {
	public bool bIsHeadDown=false;
	private Vector2 PositionHeadUp;
	private Vector2 PositionHeadDown;
	private float waitTime = 0.1f;

	// Use this for initialization
	void Start () {
		PositionHeadUp = gameObject.transform.position;
		PositionHeadDown = PositionHeadUp;
		PositionHeadDown.x += 0.5f;
		PositionHeadDown.y -= 0.5f;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown && !bIsHeadDown) { //! is the same as = false
			gameObject.transform.position = PositionHeadDown;
			bIsHeadDown=true;
			//Debug.Log ("Bob");
			StartCoroutine("CheckHeadUp");
		}
	
			
		
		//if (Input.GetKeyDown(KeyCode.LeftArrow))
		//{
		//	Vector3 position = this.transform.position;
		//	position.x--;
		//	this.transform.position = position;
		//}
	}

	IEnumerator CheckHeadUp()
	{
		yield return new WaitForSeconds(waitTime);
		gameObject.transform.position = PositionHeadUp;
		//Debug.Log ("Up");
		bIsHeadDown=false;
	}
}
