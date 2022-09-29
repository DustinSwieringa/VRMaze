using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XR.CoreUtils;

public class RandomWallDown : MonoBehaviour
{
    OpenTheElevator gemsCollected;
    LightOne lightOne;
    [SerializeField]
    private GameObject pointLight;
    [SerializeField]
    public bool playInstCrys = false;
    [SerializeField]
    public int randomDoorPicker = 0;
    [SerializeField]
    public float speedWallDown = 2.0f;
    [SerializeField]
    private GameObject elevatorDoor;
    // Start is called before the first frame update
    void Awake()
    {
        gemsCollected = elevatorDoor.GetComponent<OpenTheElevator>();
        lightOne = pointLight.GetComponent<LightOne>();
    }

    // Update is called once per frame
    void Update()
    {
        if (randomDoorPicker > 0)
        {
            playInstCrys = true;
            Destroy(gameObject);
            lightOne.lightOn = true;
            gemsCollected.gemsCollected += 1;
        }
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

        randomDoorPicker = Random.Range(1, 4);
        // Debug.Log(randomDoorPicker + "door number");


    }
}
