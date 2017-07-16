using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GridBehaviour : MonoBehaviour {

	bool noWinner=true;

	void Update () {
	
		if(Grid.gridSquares[0].tag=="gridBoxX"&&Grid.gridSquares[1].tag=="gridBoxX"&&Grid.gridSquares[2].tag=="gridBoxX")
		{
			PlayerPrefs.SetInt("Player2Score",PlayerPrefs.GetInt("Player2Score")+1);
			PlayerPrefs.SetString("LastWinner","Player 2");
			noWinner=false;
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
		if(Grid.gridSquares[3].tag=="gridBoxX"&&Grid.gridSquares[4].tag=="gridBoxX"&&Grid.gridSquares[5].tag=="gridBoxX")
		{
			PlayerPrefs.SetInt("Player2Score",PlayerPrefs.GetInt("Player2Score")+1);
			PlayerPrefs.SetString("LastWinner","Player 2");
			noWinner=false;
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
		if(Grid.gridSquares[0].tag=="gridBoxX"&&Grid.gridSquares[3].tag=="gridBoxX"&&Grid.gridSquares[6].tag=="gridBoxX")
		{
			PlayerPrefs.SetInt("Player2Score",PlayerPrefs.GetInt("Player2Score")+1);
			PlayerPrefs.SetString("LastWinner","Player 2");
			noWinner=false;
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
		if(Grid.gridSquares[1].tag=="gridBoxX"&&Grid.gridSquares[4].tag=="gridBoxX"&&Grid.gridSquares[7].tag=="gridBoxX")
		{
			PlayerPrefs.SetInt("Player2Score",PlayerPrefs.GetInt("Player2Score")+1);
			PlayerPrefs.SetString("LastWinner","Player 2");
			noWinner=false;
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
		if(Grid.gridSquares[6].tag=="gridBoxX"&&Grid.gridSquares[7].tag=="gridBoxX"&&Grid.gridSquares[8].tag=="gridBoxX")
		{
			PlayerPrefs.SetInt("Player2Score",PlayerPrefs.GetInt("Player2Score")+1);
			PlayerPrefs.SetString("LastWinner","Player 2");
			noWinner=false;
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
		if(Grid.gridSquares[2].tag=="gridBoxX"&&Grid.gridSquares[5].tag=="gridBoxX"&&Grid.gridSquares[8].tag=="gridBoxX")
		{
			PlayerPrefs.SetInt("Player2Score",PlayerPrefs.GetInt("Player2Score")+1);
			PlayerPrefs.SetString("LastWinner","Player 2");
			noWinner=false;
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}

		if(Grid.gridSquares[0].tag=="gridBoxX"&&Grid.gridSquares[4].tag=="gridBoxX"&&Grid.gridSquares[8].tag=="gridBoxX")
		{
			PlayerPrefs.SetInt("Player2Score",PlayerPrefs.GetInt("Player2Score")+1);
			PlayerPrefs.SetString("LastWinner","Player 2");
			noWinner=false;
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
		if(Grid.gridSquares[2].tag=="gridBoxX"&&Grid.gridSquares[4].tag=="gridBoxX"&&Grid.gridSquares[6].tag=="gridBoxX")
		{
			PlayerPrefs.SetInt("Player2Score",PlayerPrefs.GetInt("Player2Score")+1);
			PlayerPrefs.SetString("LastWinner","Player 2");
			noWinner=false;
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}


		if(Grid.gridSquares[0].tag=="gridBoxO"&&Grid.gridSquares[1].tag=="gridBoxO"&&Grid.gridSquares[2].tag=="gridBoxO")
		{
			PlayerPrefs.SetInt("Player1Score",PlayerPrefs.GetInt("Player1Score")+1);
			PlayerPrefs.SetString("LastWinner","Player 1");
			noWinner=false;
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
		if(Grid.gridSquares[3].tag=="gridBoxO"&&Grid.gridSquares[4].tag=="gridBoxO"&&Grid.gridSquares[5].tag=="gridBoxO")
		{
			PlayerPrefs.SetInt("Player1Score",PlayerPrefs.GetInt("Player1Score")+1);
			PlayerPrefs.SetString("LastWinner","Player 1");
			noWinner=false;
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
		if(Grid.gridSquares[0].tag=="gridBoxO"&&Grid.gridSquares[3].tag=="gridBoxO"&&Grid.gridSquares[6].tag=="gridBoxO")
		{
			PlayerPrefs.SetInt("Player1Score",PlayerPrefs.GetInt("Player1Score")+1);
			PlayerPrefs.SetString("LastWinner","Player 1");
			noWinner=false;
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
		if(Grid.gridSquares[1].tag=="gridBoxO"&&Grid.gridSquares[4].tag=="gridBoxO"&&Grid.gridSquares[7].tag=="gridBoxO")
		{
			PlayerPrefs.SetInt("Player1Score",PlayerPrefs.GetInt("Player1Score")+1);
			PlayerPrefs.SetString("LastWinner","Player 1");
			noWinner=false;
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
		if(Grid.gridSquares[6].tag=="gridBoxO"&&Grid.gridSquares[7].tag=="gridBoxO"&&Grid.gridSquares[8].tag=="gridBoxO")
		{
			PlayerPrefs.SetInt("Player1Score",PlayerPrefs.GetInt("Player1Score")+1);
			PlayerPrefs.SetString("LastWinner","Player 1");
			noWinner=false;
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
		if(Grid.gridSquares[2].tag=="gridBoxO"&&Grid.gridSquares[5].tag=="gridBoxO"&&Grid.gridSquares[8].tag=="gridBoxO")
		{
			PlayerPrefs.SetInt("Player1Score",PlayerPrefs.GetInt("Player1Score")+1);
			PlayerPrefs.SetString("LastWinner","Player 1");
			noWinner=false;
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}

		if(Grid.gridSquares[0].tag=="gridBoxO"&&Grid.gridSquares[4].tag=="gridBoxO"&&Grid.gridSquares[8].tag=="gridBoxO")
		{
			PlayerPrefs.SetInt("Player1Score",PlayerPrefs.GetInt("Player1Score")+1);
			PlayerPrefs.SetString("LastWinner","Player 1");
			noWinner=false;
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
		if(Grid.gridSquares[2].tag=="gridBoxO"&&Grid.gridSquares[4].tag=="gridBoxO"&&Grid.gridSquares[6].tag=="gridBoxO")
		{
			PlayerPrefs.SetInt("Player1Score",PlayerPrefs.GetInt("Player1Score")+1);
			PlayerPrefs.SetString("LastWinner","Player 1");
			noWinner=false;
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}


		if(GameObject.FindGameObjectsWithTag("gridBox").Length==0&&noWinner)
		{
			PlayerPrefs.SetString("LastWinner","DRAW");
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}


		PlayerPrefs.Save();
	}
	public void reset()
	{
		PlayerPrefs.SetInt("Player1Score",0);
		PlayerPrefs.SetInt("Player2Score",0);
		PlayerPrefs.SetString("LastWinner"," ");
		PlayerPrefs.Save();
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		return;
	}
}
