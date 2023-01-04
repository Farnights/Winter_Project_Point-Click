using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game Menu")]
public class AppDatas : ScriptableObject
{
    public Vector3 posExitHouse;
    public Vector3 posEnterHouse;
    public Vector3 posStart;
    public int previousScene;
}
