using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XR.CoreUtils;

public class MiddleCryslatF : MonoBehaviour
{
    OpenTheElevator gemsCollected;
    LightFive lightFive;
    [SerializeField]
    private GameObject pointLight;
    [SerializeField]
    private GameObject elevatorDoor;
    // Start is called before the first frame update
    void Awake()
    {
        gemsCollected = elevatorDoor.GetComponent<OpenTheElevator>();
        lightFive = pointLight.GetComponent<LightFive>();
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

        lightFive.lightFiveOn = true;
        gemsCollected.gemsCollected += 1;
        Destroy(gameObject);
    }
}
