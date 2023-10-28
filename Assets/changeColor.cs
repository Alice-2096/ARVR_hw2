using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    // public Material InactiveMaterial;
    // public Material GazedAtMaterial;

    public void Start()
    {
        SetColorRed(false);
    }

    /// This method is called by the Main Camera when it starts gazing at this GameObject.
    public void OnPointerEnter()
    {
        SetColorRed(true);
    }

    public void OnPointerExit()
    {
        SetColorRed(false);
    }

    private void SetColorRed(bool gazedAt)
    {
        GetComponent<Renderer>().material.color = gazedAt ? Color.red : Color.blue;
    }
}



