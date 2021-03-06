﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public AudioClip button;
    public AudioClip startbutton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ゲームを始めるボタンを押したらゲームシーンに切り替え
    public void StartButtonClick()
    {
        AudioSource.PlayClipAtPoint(startbutton, new Vector3(0, 0, 0));
        Invoke("StartButtonClick2", 1.2f);
    }
    void StartButtonClick2()
    {
        SceneManager.LoadScene("Main");
    }

    // 履歴を見るボタンを押したら履歴シーンに切り替え
    public void HistoryButtonClick()
    {
        AudioSource.PlayClipAtPoint(button, new Vector3(0, 0, 0));
        Invoke("HistoryButtonClick2", 1.2f);
    }
    void HistoryButtonClick2()
    {
        SceneManager.LoadScene("History");
    }

    // ホームボタンを押したらTopシーンに切り替え
    public void HomeButtonClick()
    {
        AudioSource.PlayClipAtPoint(button, new Vector3(0, 0, 0));
        Invoke("HomeButtonClick2", 1.2f);
    }
    void HomeButtonClick2()
    {
        SceneManager.LoadScene("Top");
    }
}
