using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterColor : MonoBehaviour
{
    public Material NewColor;
    public Material CharColor;

    public void ChangeColor()
    {
        CharColor.color = NewColor.color;
        CharColor.SetFloat("_Metallic", NewColor.GetFloat("_Metallic"));
    }
}
