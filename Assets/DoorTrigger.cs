using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public GameObject door;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // when object has entered the trigger
    private void OnTriggerEnter(Collider other)
    {
        door.GetComponent<DoorMove>().isOpening = true;
    }

    // when object leaves trigger
    private void OnTriggerExit(Collider other)
    {
        door.GetComponent<DoorMove>().isOpening = false;
    }


}
