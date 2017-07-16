using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour {

	public static Transform[] gridSquares;

	void Awake(){
		gridSquares = new Transform[transform.childCount];
		for (int i = 0;i < gridSquares.Length;i++)
		{
			gridSquares[i] = transform.GetChild(i);
			gridSquares[i].tag = "gridBox";
		}
	}
}
