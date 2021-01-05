using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KartColor : MonoBehaviour
{
    public Material NewColor;
    public Material KartBody;

    public void ChangeColor()
    {
        KartBody.color = NewColor.color;
        KartBody.SetFloat("_Metallic", NewColor.GetFloat("_Metallic"));
    }
}
