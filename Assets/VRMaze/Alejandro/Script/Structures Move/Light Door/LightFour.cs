using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFour : MonoBehaviour
{
    public Light purple;
    public bool lightFourOn = false;
    // Start is called before the first frame update
    void Start()
    {
        purple = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (lightFourOn == true)
        {
            purple.enabled = true;
        }
    }
}
