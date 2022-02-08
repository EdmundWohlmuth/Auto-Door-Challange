using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public GameObject door;
    bool open;
    float movement;

    // Start is called before the first frame update
    void Start()
    {
        movement = 2.5f;
    }

    // when object has entered the trigger
    private void OnTriggerEnter(Collider other)
    {
        door.transform.position =
            new Vector3(door.transform.position.x, door.transform.position.y + movement, door.transform.position.z);
        open = false;
    }

    // when object leaves trigger
    private void OnTriggerExit(Collider other)
    {
        door.transform.position =
            new Vector3(door.transform.position.x, door.transform.position.y - movement, door.transform.position.z);
        open = true;
    }


}
