using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraZoomController : MonoBehaviour
{

    private Camera cam;
    [SerializeField] private float targetZoomIn;
    private float targetZoomOut;



    // Start is called before the first frame update
    void Start()
    {

        cam = Camera.main;
        targetZoomOut = cam.orthographicSize;

    }


    // Update is called once per frame
    void Update()
    {
        if (cam.orthographicSize == targetZoomOut  && Input.GetKeyDown(KeyCode.M))
        {

            cam.orthographicSize = targetZoomIn;
            
            
        }

        else if(cam.orthographicSize == targetZoomIn && Input.GetKeyDown(KeyCode.M))
        {
            cam.orthographicSize = targetZoomOut;
        }
        
    }
}   


    
    
