using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(menuName = "Game Menu")]
public class AppDatas : ScriptableObject
{
    public Vector3 posExitHouse;
    public Vector3 posEnterHouse;
    public Vector3 posStart;
    public int previousScene;

    public int itemStore = 0;
}
