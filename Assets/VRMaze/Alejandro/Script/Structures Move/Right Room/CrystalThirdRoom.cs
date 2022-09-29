using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XR.CoreUtils;

public class CrystalThirdRoom : MonoBehaviour
{
    OpenTheElevator gemsCollected;
    LightThree lightThree;
    [SerializeField]
    private GameObject pointLight;
    [SerializeField]
    public int DoorPickerRight = 0;
    [SerializeField]
    private GameObject elevatorDoor;
    // Start is called before the first frame update
    void Awake()
    {
        gemsCollected = elevatorDoor.GetComponent<OpenTheElevator>();
        lightThree = pointLight.GetComponent<LightThree>();

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

        gemsCollected.gemsCollected += 1;
        lightThree.lightThreeOn = true;
        DoorPickerRight += 1;
        Destroy(gameObject);


    }
}
