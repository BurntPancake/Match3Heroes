using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour 
{
	public float addScale = 0.3f;

	private int x;
	private int y; //Position of cube in gem[,] of GenerateBoard

	private Vector3 myScale = new Vector3(1,1,1);
	private Vector3 prefabPos = new Vector3(-3,-3,0);

	private bool selected = false;

	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void SetX(int x)
	{
		this.x = x;
	}

	void SetY(int y)
	{
		this.y = y;
	}

	void OnMouseOver()
	{
		if(!selected)
		{		
			//Hovering block effect
			iTween.ScaleTo(gameObject, new Vector3(myScale.x+addScale, myScale.y+addScale), 0.1f);
		}

	}
	
	
	void OnMouseExit()
	{
		if(!selected)
		{		
			//Exit hovering effect
		iTween.ScaleTo(gameObject, new Vector3(myScale.x, myScale.y), 0.1f);
		}
	}

	void SetSelected()//Start animation when selected
	{
		if(selected == false)
		{
			selected = true;
			iTween.MoveBy(this.gameObject, 
			              iTween.Hash("y",0.2, "easeType","easeInOutExpo", "loopType","pingPong", "time",0.6, "name","selectMoveEffect"));
			iTween.ScaleAdd(this.gameObject, 
			                iTween.Hash("x",0.1, "y",0.1, "easeType","easeInOutExpo", "loopType","pingPong", "time",0.6, "name","selectScaleEffect"));
		}
	}

	void SetUnselected()//Stop animation when deselected
	{
		if(selected == true)
		{
			selected = false;
			gameObject.transform.localScale = myScale;
			gameObject.transform.position = new Vector3(prefabPos.x + this.x,
			                                            prefabPos.y + this.y,0);
			iTween.Stop(this.gameObject);
		}
	}
}
