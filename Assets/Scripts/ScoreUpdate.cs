using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour {

	public Text player1Score;
	public Text player2Score;
	public Text lastWinner;

	// Update is called once per frame
	void Update () {
		player1Score.text=PlayerPrefs.GetInt("Player1Score").ToString();
		player2Score.text=PlayerPrefs.GetInt("Player2Score").ToString();
		lastWinner.text=PlayerPrefs.GetString("LastWinner");
	}
}
