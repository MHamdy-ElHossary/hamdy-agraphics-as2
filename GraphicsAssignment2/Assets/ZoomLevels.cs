using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomLevels : MonoBehaviour
{

    public Camera cam;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            cam.fieldOfView -= 20;
            if (cam.fieldOfView < 30)
            {
                cam.fieldOfView = 80;
            }
        }

        
        
    }
}
