using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouWin : MonoBehaviour
{
    [SerializeField] private TMP_Text _youWin;
    [SerializeField] private string _text;
    [SerializeField] private AppDatas _appDatas;


    private void Update()
    {
        if (_appDatas.itemStore == 7)
        {
            SceneManager.LoadScene("FinalScreen", LoadSceneMode.Single);
        }
    }
}

