using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ChangeHat : MonoBehaviour
{
    public GameObject displayKart;
    public GameObject pfb;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            ChangeHats();
            gameObject.SetActive(false);
        } 
    }

    public void ChangeHats()
    {
        while (displayKart.transform.childCount > 0)
        {
            DestroyImmediate(displayKart.transform.GetChild(0).gameObject);
        }


        GameObject displayInstance = Instantiate(pfb);

        displayInstance.transform.parent = displayKart.transform;
        displayInstance.transform.localScale = new Vector3(1, 1, 1);
        displayInstance.transform.rotation = new Quaternion(0, 0, 0, 0);
        displayInstance.transform.localPosition = new Vector3(0, 0, 0);
    }
}
