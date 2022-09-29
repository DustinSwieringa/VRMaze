using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XR.CoreUtils;

public class CrystalSecondRoom : MonoBehaviour
{
    OpenTheElevator gemsCollected;
    LightTwo lightTwo;
    [SerializeField]
    private GameObject pointLight;
    [SerializeField]
    public int DoorPickerLeft = 0;
    [SerializeField]
    private GameObject elevatorDoor;
    // Start is called before the first frame update
    void Awake()
    {
        gemsCollected = elevatorDoor.GetComponent<OpenTheElevator>();
        lightTwo = pointLight.GetComponent<LightTwo>();

    }

    // Update is called once per frame
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
        DoorPickerLeft += 1 ;
        lightTwo.lightTwoOn = true;
        Destroy(gameObject);


    }
}
