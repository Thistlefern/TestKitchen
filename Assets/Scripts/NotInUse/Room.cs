using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    public int sizeW;
    public int sizeL;
    public bool containsStairs;
    public bool dangerous;
    public int numberOfExits;

    public void NewRoom()
    {
        sizeW = Random.Range(5, 10);
        sizeL = Random.Range(5, 20);
    }
}