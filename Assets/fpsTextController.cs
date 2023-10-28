using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsTextController : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        //get the text component

    }

    // Update is called once per frame
    void Update()
    {
        TextMesh tm = GetComponent<TextMesh>();
        //set the text to the current fps
        tm.text = "fps: " + (1.0f / Time.deltaTime).ToString();
    }
}
