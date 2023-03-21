using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class win3 : MonoBehaviour
{
    public GameObject player;
    Text score_text;
    public GameObject uiScore;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player && !ScenesManager.win)
        {
            ScenesManager.win = true;
            ScenesManager.finish = true;
            score_text = uiScore.GetComponent<Text>();
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        ScenesManager.win = false;
        ScenesManager.lose = false;
        ScenesManager.finish = false;
        ScenesManager._level = 3;
        ScenesManager._score = 0;
    }

    void Update()
    {
        if (ScenesManager.win)
        {
            ScenesManager._score = (float)Math.Round(1000 / Convert.ToDouble(score_text.text), 2);
            StartCoroutine(ScenesManager.updateProgress());
            ScenesManager.Instance.LoadScene(ScenesManager.Scene.WinScreen3);
        }
    }
}
