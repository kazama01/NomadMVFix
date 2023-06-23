using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class renderManipulator : MonoBehaviour
{
    public UniversalRendererData feature;
    public int renderTarget;
    public float timer;
    public bool bol;
    // Start is called before the first frame update
    private void Awake()
    {
        if(feature == false && bol == true)
        {
            feature.rendererFeatures[renderTarget].SetActive(true);
        }
        else { feature.rendererFeatures[renderTarget].SetActive(false);}
    }

    // Update is called once per frame
    void Update()
    {
        if (timer == 1)
        {
            feature.rendererFeatures[renderTarget].SetActive(false);
        }
        else
        {
            feature.rendererFeatures[renderTarget].SetActive(true) ;
        }
       
    }
}
