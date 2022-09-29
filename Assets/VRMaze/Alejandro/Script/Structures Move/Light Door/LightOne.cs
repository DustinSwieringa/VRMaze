using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOne : MonoBehaviour
{
    public Light pink;
    public bool lightOn = false;
    // Start is called before the first frame update
    void Start()
    {
        pink = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if(lightOn == true)
        {
            pink.enabled = true;
        }
    }
}
