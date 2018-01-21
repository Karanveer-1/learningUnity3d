using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

	public static UIManager instance;
	public GameObject topPanel;
	public GameObject gameOverPanel;
	public Text score;
	public Text highScore1;
	public Text highScore2;
	public GameObject tapText;

	void Awake() {
		if (instance == null) {
			instance = this;
		} 
	}
	
	// Use this for initialization
	void Start () {
		highScore1.text = "High Score: " + PlayerPrefs.GetInt("highScore");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GameStart () {
		tapText.SetActive(false);
		topPanel.GetComponent<Animator>().Play("panelUp");
	}

	public void GameOver () {
		score.text = PlayerPrefs.GetInt("score").ToString();
		highScore2.text = PlayerPrefs.GetInt("highScore").ToString();
		gameOverPanel.SetActive(true);
	}

	public void Reset () {
		SceneManager.LoadScene("Level_01");
	}
}
