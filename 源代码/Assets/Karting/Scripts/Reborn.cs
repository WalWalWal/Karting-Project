using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reborn : MonoBehaviour
{
    public GameObject kart;
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("you met one coin");
        if (other.tag == "Player")
        {
            kart.transform.localRotation = new Quaternion(0, 180, 0, 0);
            kart.transform.position = new Vector3(-87, 10, 29);
        }
    }
}
