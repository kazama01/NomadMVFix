using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class freeCamActivate : MonoBehaviour
{
    public GameObject cineMachine;
    public FreeCamera scriptCam;

    void Start()
    {


    }
    void Update()
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                cineMachine.SetActive(false);
                scriptCam.enabled = true;
                Debug.Log("C");
            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                cineMachine.SetActive(true);
                scriptCam.enabled = false;
                Debug.Log("Space");
            }
        }
    }
