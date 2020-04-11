﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    float timer = 15.0f;
    public GameObject Score;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0.0f)
        {
            // 残り秒数を格納
            timer -= Time.deltaTime;
            // 残り秒数を表示
            GetComponent<Text>().text = string.Format("残り {0:F1}", timer); 
        }
        // 時間切れ時の処理
        else
        {
            // 終了を表示
            GetComponent<Text>().text = "Time UP!!"; 
            // 終了日時を記録させる
            Score.GetComponent<ScoreController>().SetDateTime();
        }
    }
}
