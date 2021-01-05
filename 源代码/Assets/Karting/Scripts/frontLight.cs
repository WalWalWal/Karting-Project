using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frontLight : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (UnityEngine.Input.GetKeyDown("r"))
        {
            if (GetComponent<Light>().enabled == true)
                GetComponent<Light>().enabled = false;
            else GetComponent<Light>().enabled = true;
        }
    }
}
