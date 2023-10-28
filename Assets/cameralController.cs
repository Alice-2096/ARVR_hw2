using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameralController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obj = null; // the object that is currently being looked at
    void Start()
    {

    }
    private void Update()
    {
        // detect if ray intersects with any GameObjects
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 15.0f))
        {
            if (hit.transform.gameObject != null && hit.transform.gameObject.layer == 3)
            {
                if (obj != null)
                {
                    obj.SendMessage("OnPointerExit");
                }
                obj = hit.transform.gameObject; // the object hit by the raycast
                obj.SendMessage("OnPointerEnter");
            }
        }
        else
        {
            // No GameObject detected 
            if (obj != null)
            {
                obj.SendMessage("OnPointerExit"); // call OnPointerExit() on the object that was previously hit
            }
            obj = null;
        }
    }




}
