using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class renderManipulator : MonoBehaviour
{
    public UniversalRendererData feature;
    public float timer;
    // Start is called before the first frame update
    private void Awake()
    {
        feature.rendererFeatures[1].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer == 1)
        {
            feature.rendererFeatures[1].SetActive(false);
        }
       
    }
}
