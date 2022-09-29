using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XR.CoreUtils;

public class RightCrystalF : MonoBehaviour
{
    OpenTheElevator gemsCollect;
    CrystalThirdRoom sDoorDown;
    LightSix lightSix;
    [SerializeField]
    private GameObject pointLight;
    [SerializeField]
    private GameObject elevatorGate;
    [SerializeField]
    private GameObject thirdCrystal;
    // Start is called before the first frame update
    void Awake()
    {
        gemsCollect = elevatorGate.GetComponent<OpenTheElevator>();
        sDoorDown = thirdCrystal.GetComponent<CrystalThirdRoom>();
        lightSix = pointLight.GetComponent<LightSix>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gemsCollect.gemsCollected == 4)
        {
            Destroy(gameObject);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer != 3)
            return;

        XROrigin origin = other.gameObject.GetComponent<XROrigin>();
        if (origin == null)
            return;

        lightSix.lightSixOn = true;
        sDoorDown.DoorPickerRight = 2;
        gemsCollect.gemsCollected += 1;
        Destroy(gameObject);
    }
}