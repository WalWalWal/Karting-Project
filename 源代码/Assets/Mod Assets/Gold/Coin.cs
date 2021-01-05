using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public Text GoldCount;
    public AudioClip GoldSound;

    private void OnTriggerEnter(Collider other)      
    {          
        //Debug.Log("you met one coin");       
        if (other.tag == "Player")     
        {      
            int i = int.Parse(GoldCount.text);     
            GoldCount.text = (i + 1).ToString();    
            GetComponent<Collider>().enabled = false;    
            gameObject.GetComponent<Animator>().enabled = true;

            if (GoldSound)
            {
                AudioUtility.CreateSFX(GoldSound, transform.position, AudioUtility.AudioGroups.Collision, 0f);
            }
        }    
    }
       
    void Update()        
    {      
        transform.Rotate(0.0f, 90 * Time.deltaTime, 0.0f, Space.World);       
    }
} 