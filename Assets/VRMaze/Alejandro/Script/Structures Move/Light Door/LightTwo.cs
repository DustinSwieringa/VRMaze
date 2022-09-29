using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTwo : MonoBehaviour
{
    public Light red;
    public bool lightTwoOn = false;
    // Start is called before the first frame update
    void Start()
    {
        red = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (lightTwoOn == true)
        {
            red.enabled = true;
        }
    }
}
