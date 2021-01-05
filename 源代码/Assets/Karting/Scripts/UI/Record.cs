using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using KartGame.UI;

public class Record : MonoBehaviour
{
    public string coin;
    public string time;
    public string lastScene;

void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    public void SaveRecord()
    {
        if (GameObject.FindWithTag("Record"))
        {
            coin = GameObject.FindWithTag("Record").GetComponent<Text>().text;
        }

        if (GameObject.FindWithTag("Record2"))
        {
            time = (GameObject.FindWithTag("Record2").GetComponent<TextMeshProUGUI>()).text;
        }

        lastScene = SceneManager.GetActiveScene().name;
    }

    public void Update()
    {
        if (SceneManager.GetActiveScene().name == "WinScene" || SceneManager.GetActiveScene().name == "LoseScene")
        {
            if (GameObject.Find("RestartButton"))
            {
                GameObject.Find("RestartButton").GetComponent<LoadSceneButton>().SceneName = lastScene;
            }

            if (lastScene == "Level2")
            {
                if (GameObject.Find("NextButton"))
                {
                    GameObject.Find("NextButton").SetActive(false);
                }
            }

            if (GameObject.Find("Time"))
            {
                if (lastScene == "Level2")
                    GameObject.Find("Time").GetComponent<TextMeshProUGUI>().text = "Time: Not Available";
                else
                    GameObject.Find("Time").GetComponent<TextMeshProUGUI>().text = "Time: " + time;
            }

            if (GameObject.Find("Gold"))
            {
                GameObject.Find("Gold").GetComponent<TextMeshProUGUI>().text = "Coin: " + coin;
            }

            Destroy(this.gameObject);
        }
    }
}
