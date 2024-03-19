using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEditor;

public class Timer : MonoBehaviour

{

    public GameObject RestartLevel;
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remaininingTime;


    private void Update()
    {
        if (remaininingTime > 0)
        {
            remaininingTime -= Time.deltaTime;
        }

        else if (remaininingTime < 0)
        {
            remaininingTime = 0;
            Time.timeScale = 0;
            RestartLevel.SetActive(true);
        }
        int minutes = Mathf.FloorToInt(remaininingTime / 60);
        int seconds = Mathf.FloorToInt(remaininingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    private void Start()
    {
        RestartLevel.SetActive (false);
        Time.timeScale = 1;
    }
}



