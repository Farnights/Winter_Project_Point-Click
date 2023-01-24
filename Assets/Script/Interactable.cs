using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public GameObject clue;
    public bool playerInRange;
    [SerializeField] private AppDatas _appDatas;
    [SerializeField] private ItemDatas _itemDatas;


    

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && playerInRange)
        {
            if (clue.activeInHierarchy && _itemDatas.itemOwned == false)
            {
                clue.SetActive(false);
                _appDatas.itemStore++;
                _itemDatas.itemOwned = true;
            }
            
            
        }
        
        if (_itemDatas.itemOwned == true)
        {
                clue.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }
}
