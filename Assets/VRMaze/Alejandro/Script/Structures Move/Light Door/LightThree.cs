using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightThree : MonoBehaviour
{
    public Light yellow;
    public bool lightThreeOn = false;
    // Start is called before the first frame update
    void Start()
    {
        yellow = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (lightThreeOn == true)
        {
            yellow.enabled = true;
        }
    }
}
