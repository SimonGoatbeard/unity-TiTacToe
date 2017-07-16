using UnityEngine;
using System.Collections;

public class Controlls : MonoBehaviour {
	public GameObject xPlayer;
	public GameObject oPlayer;
	private bool changePlayer=false;
	Ray ray = new Ray();
	RaycastHit hit = new RaycastHit();
	int cPosition=4;
	public GameObject playerCursor;
	bool uAxis=false;
	bool dAxis=false;
	bool lAxis=false;
	bool rAxis=false;
	bool startBool=false;
	public GameObject startPrefab;
	public GameObject startEmptyPrefab;
	bool startOnce1=true;
	bool startOnce2=false;
	bool buttonDown=true;
	public GameObject gridBehaviour;
	
	// Update is called once per frame
	void Update () {
			MouseController();
			//KeyboardController();
		if(!startBool)
		{
			if(startOnce1)
			{
				GameObject.Destroy(GameObject.FindGameObjectWithTag("start1"));
				GameObject.Instantiate(startPrefab,new Vector3(0,-2.2f,0),Quaternion.identity);
				startOnce2=true;
				startOnce1=false;
				return;
			}
		}
		if(startBool)
		{
			if(startOnce2)
			{
				GameObject.Destroy(GameObject.FindGameObjectWithTag("start0"));
				GameObject.Instantiate(startEmptyPrefab,new Vector3(0,-2.2f,0),Quaternion.identity);
				startOnce2=false;
				startOnce1=true;
				return;
			}
		}
	}

	void MouseController(){
		if(Input.GetMouseButton(0)&&buttonDown)
		{
			ray= Camera.main.ScreenPointToRay(Input.mousePosition);
			if(Physics.Raycast(ray,out hit))
			{
				if(hit.transform.tag == "reset")
				{
					gridBehaviour.GetComponent<GridBehaviour>().reset();
				}
				if(hit.transform.tag == "start0")
				{
					startBool=true;
				}
				if(startBool)
				{
					if(hit.transform.tag == "gridBox")
					{
						Vector2 temp = hit.transform.position;
						temp.x = hit.point.x;
						temp.y = hit.point.y;
						if(changePlayer)
						{
							GameObject.Instantiate(xPlayer,new Vector3(hit.transform.position.x,hit.transform.position.y, -3),Quaternion.identity);
							hit.transform.tag="gridBoxX";
							changePlayer = false;
							return;
						}
						if(!changePlayer)
						{
							GameObject.Instantiate(oPlayer,new Vector3(hit.transform.position.x,hit.transform.position.y, -3),Quaternion.identity);
							hit.transform.tag="gridBoxO";
							changePlayer=true;
							return;
						}
					}
				}
			}
			buttonDown=false;
			return;
		}
		if(Input.GetMouseButtonUp(0))
		{
			buttonDown=true;
			return;
		}
	}

	void PhoneController(){
		if(Input.GetMouseButton(0))
		{
			ray= Camera.main.ScreenPointToRay(Input.mousePosition);
			if(Physics.Raycast(ray,out hit))
			{
				if(hit.transform.tag == "gridBox")
				{
					Vector2 temp = hit.transform.position;
					temp.x = hit.point.x;
					temp.y = hit.point.y;
					if(changePlayer)
					{
						GameObject.Instantiate(xPlayer,new Vector3(hit.transform.position.x,hit.transform.position.y, -3),Quaternion.identity);
						hit.transform.tag="gridBoxX";
						changePlayer = false;
						return;
					}
					if(!changePlayer)
					{
						GameObject.Instantiate(oPlayer,new Vector3(hit.transform.position.x,hit.transform.position.y, -3),Quaternion.identity);
						hit.transform.tag="gridBoxO";
						changePlayer=true;
						return;
					}
				}
			}
		}
	}

	void KeyboardController(){
		if(Input.GetAxis("Horizontal")<0&&uAxis==false)
		{
			if(cPosition==0)
			{
				cPosition=9;
				return;
			}
			else
			{
				cPosition-=1;	
			}
			uAxis=true;
		}
		if(Input.GetAxis("Horizontal")>0&&dAxis==false)
		{
			if(cPosition==8)
			{
				cPosition=-1;
				return;
			}
			else
			{
				cPosition+=1;	
			}
			dAxis=true;
		}
		if(Input.GetAxis("Vertical")>0&&lAxis==false)
		{
			if(cPosition==0)
			{
				cPosition=9;
				return;
			}
			else
			{
				cPosition-=1;	
			}
			lAxis=true;
		}
		if(Input.GetAxis("Vertical")<0&&rAxis==false)
		{
			if(cPosition==8)
			{
				cPosition=-1;
				return;
			}
			else
			{
				cPosition+=1;	
			}
			rAxis=true;
		}
		if(Input.GetAxis("Horizontal")==0&&uAxis==true){uAxis=false;}
		if(Input.GetAxis("Horizontal")==0&&dAxis==true){dAxis=false;}
		if(Input.GetAxis("Vertical")==0&&lAxis==true){lAxis=false;}
		if(Input.GetAxis("Vertical")==0&&rAxis==true){rAxis=false;}

		playerCursor.transform.position=new Vector3(Grid.gridSquares[cPosition].transform.position.x,Grid.gridSquares[cPosition].transform.position.y,playerCursor.transform.position.z);
		if(Input.GetAxis("Jump")!=0)
		{
			if(Grid.gridSquares[cPosition].tag=="gridBox")
			{
					if(changePlayer)
					{
						GameObject.Instantiate(xPlayer,new Vector3(Grid.gridSquares[cPosition].transform.position.x,Grid.gridSquares[cPosition].transform.position.y, -3),Quaternion.identity);
						Grid.gridSquares[cPosition].tag="gridBoxX";
						changePlayer = false;
						return;
					}
					if(!changePlayer)
					{
						GameObject.Instantiate(oPlayer,new Vector3(Grid.gridSquares[cPosition].transform.position.x,Grid.gridSquares[cPosition].transform.position.y, -3),Quaternion.identity);
						Grid.gridSquares[cPosition].tag="gridBoxO";
						changePlayer=true;
						return;
					}	
			}
		}
	}

	void PadController(){
		if(Input.GetAxis("Horizontal")<0&&uAxis==false)
		{
			if(cPosition==0)
			{
				cPosition=9;
				return;
			}
			else
			{
				cPosition-=1;	
			}
			uAxis=true;
		}
		if(Input.GetAxis("Horizontal")>0&&dAxis==false)
		{
			if(cPosition==8)
			{
				cPosition=-1;
				return;
			}
			else
			{
				cPosition+=1;	
			}
			dAxis=true;
		}
		if(Input.GetAxis("Vertical")>0&&lAxis==false)
		{
			if(cPosition==0)
			{
				cPosition=9;
				return;
			}
			else
			{
				cPosition-=1;	
			}
			lAxis=true;
		}
		if(Input.GetAxis("Vertical")<0&&rAxis==false)
		{
			if(cPosition==8)
			{
				cPosition=-1;
				return;
			}
			else
			{
				cPosition+=1;	
			}
			rAxis=true;
		}
		if(Input.GetAxis("Horizontal")==0&&uAxis==true){uAxis=false;}
		if(Input.GetAxis("Horizontal")==0&&dAxis==true){dAxis=false;}
		if(Input.GetAxis("Vertical")==0&&lAxis==true){lAxis=false;}
		if(Input.GetAxis("Vertical")==0&&rAxis==true){rAxis=false;}

		playerCursor.transform.position=new Vector3(Grid.gridSquares[cPosition].transform.position.x,Grid.gridSquares[cPosition].transform.position.y,playerCursor.transform.position.z);
		if(Input.GetAxis("Jump")!=0)
		{
			if(Grid.gridSquares[cPosition].tag=="gridBox")
			{
				if(changePlayer)
				{
					GameObject.Instantiate(xPlayer,new Vector3(Grid.gridSquares[cPosition].transform.position.x,Grid.gridSquares[cPosition].transform.position.y, -3),Quaternion.identity);
					Grid.gridSquares[cPosition].tag="gridBoxX";
					changePlayer = false;
					return;
				}
				if(!changePlayer)
				{
					GameObject.Instantiate(oPlayer,new Vector3(Grid.gridSquares[cPosition].transform.position.x,Grid.gridSquares[cPosition].transform.position.y, -3),Quaternion.identity);
					Grid.gridSquares[cPosition].tag="gridBoxO";
					changePlayer=true;
					return;
				}	
			}
		}

	}


}
