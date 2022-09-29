using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFive : MonoBehaviour
{
    public Light blue;
    public bool lightFiveOn = false;
    // Start is called before the first frame update
    void Start()
    {
        blue = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (lightFiveOn == true)
        {
            blue.enabled = true;
        }
    }
}
