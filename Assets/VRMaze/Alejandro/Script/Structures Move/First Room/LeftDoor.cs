using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftDoor : MonoBehaviour
{
    CrystalSecondRoom secondDoorDown;
    RandomWallDown WallDown;
    [SerializeField]
    private GameObject firstCrystal;
    [SerializeField]
    private GameObject secondCrystal;

    // Start is called before the first frame update
    void Awake()
    {
        WallDown = firstCrystal.GetComponent<RandomWallDown>();
        secondDoorDown = secondCrystal.GetComponent<CrystalSecondRoom>();
    }

    // Update is called once per frame
    void Update()
    {
        if (WallDown.randomDoorPicker == 3)
        {
            transform.position += new Vector3(0, -1 * WallDown.speedWallDown * Time.deltaTime, 0);
            secondDoorDown.DoorPickerLeft = +1;

        }
        if (transform.position.y < -24)
        {
            WallDown.randomDoorPicker = 0;
        }
    }
}
