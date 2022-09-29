using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSix : MonoBehaviour
{
    public Light green;
    public bool lightSixOn = false;
    // Start is called before the first frame update
    void Start()
    {
        green = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (lightSixOn == true)
        {
            green.enabled = true;
        }
    }
}
