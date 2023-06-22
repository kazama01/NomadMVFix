using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxChanger : MonoBehaviour
{
    public Material mats;
    public float val;
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
       
        mats.SetFloat("_Float", val);
    }
}
