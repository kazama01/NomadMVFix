using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class layerChange : MonoBehaviour
{
    public float valTrigger;
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (valTrigger == 1)
        {
            gameObject.layer = default;
        }
    }
}
