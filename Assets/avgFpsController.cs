using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avgFpsController : MonoBehaviour
{
    //calculate the average fps in the past 1 second and display it
    float timeElapsed = 0.0f;
    int frameCount = 0;

    //List of delta times
    List<float> deltaTimes = new List<float>();
    void Start()
    {
        timeElapsed += Time.deltaTime;
    }
    void Update()
    {
        timeElapsed += Time.deltaTime;
        frameCount++;
        deltaTimes.Add(Time.deltaTime);


        if (timeElapsed >= 1)
        {
            TextMesh tm = GetComponent<TextMesh>();
            float time = 0.0f;
            int count = 0;
            //calculate the average fps
            for (int i = deltaTimes.Count - 1; i >= 0; i--)
            {
                time += deltaTimes[i];
                count++;
                if (time >= 1)
                {
                    tm.text = "average: " + (count / time).ToString();
                    break;
                }
            }
        }
    }
}
