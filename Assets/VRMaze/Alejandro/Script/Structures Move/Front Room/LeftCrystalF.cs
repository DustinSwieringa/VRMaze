using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XR.CoreUtils;

public class LeftCrystalF : MonoBehaviour
{
    OpenTheElevator gemsCollected;
    LightFour lightFour;
    CrystalSecondRoom secondDoorDown;
    [SerializeField]
    private GameObject pointLight;
    [SerializeField]
    private GameObject elevatorDoor;
    [SerializeField]
    private GameObject secondCrystal;
    // Start is called before the first frame update
    void Awake()
    {
        gemsCollected = elevatorDoor.GetComponent<OpenTheElevator>();
        secondDoorDown = secondCrystal.GetComponent<CrystalSecondRoom>();
        lightFour = pointLight.GetComponent<LightFour>();
    }


    void Update()
    {
        if (gemsCollected.gemsCollected == 4)
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

        lightFour.lightFourOn = true;
        secondDoorDown.DoorPickerLeft = 2;
        gemsCollected.gemsCollected += 1;
        Destroy(gameObject);
    }
}
