using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour 
{
	public float addScale = 0.2f;

	private int x;
	private int y; //Position of cube in gem[,] of GenerateBoard

	private Vector3 myScale = new Vector3(1f,1f,1f);

	private bool selected = false;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void setX(int x)
	{
		this.x = x;
	}

	void setY(int y)
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
}
