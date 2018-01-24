using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

	public static UIManager instance;
	public Text scoreText;
	public GameObject gameOverPanel;
	public GameObject startPanel;
	public GameObject gameOverText;
	public Text highScoreText;

	void Awake () {
		if (instance == null) {
			instance = this;
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = ScoreManager.instance.score.ToString();		
	}

	public void GameStart () {
		startPanel.SetActive(false);
	}

	public void GameOver() {
		gameOverText.SetActive(true);
		highScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
		gameOverPanel.SetActive(true);
	}

	public void Replay() {
		SceneManager.LoadScene("Level_01");
	}

	public void Menu() {
		SceneManager.LoadScene("Menu");
	}


}
