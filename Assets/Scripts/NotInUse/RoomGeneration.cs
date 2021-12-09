using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomGeneration : MonoBehaviour
{
    int numberOfRooms;
    public Room[] rooms;

    // Start is called before the first frame update
    void Start()
    {
        numberOfRooms = Random.Range(3, 8);
        rooms = new Room[numberOfRooms];
        for(int i = 0; i < numberOfRooms; i++)
        {
            rooms[i].NewRoom();
            Debug.Log(rooms[i].sizeL);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}