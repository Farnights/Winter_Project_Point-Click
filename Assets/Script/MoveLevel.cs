using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class MoveLevel : MonoBehaviour
{
    public int sceneBuildIndex;
    [SerializeField] private AppDatas _appDatas;
    [SerializeField] private GameObject _player;
    private int _indexScene;
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            _indexScene = SceneManager.GetActiveScene().buildIndex;
            _appDatas.previousScene = _indexScene;
            print("switching scene to" + sceneBuildIndex);
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        }
        
        
    }
}
