using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightDoor : MonoBehaviour
{
    CrystalThirdRoom secondDoorDown;
    RandomWallDown WallDown;
    [SerializeField]
    private GameObject firstCrystal;
    [SerializeField]
    private GameObject thirdCrystal;

    // Start is called before the first frame update
    void Awake()
    {
        WallDown = firstCrystal.GetComponent<RandomWallDown>();
        secondDoorDown = thirdCrystal.GetComponent<CrystalThirdRoom>();
    }

    // Update is called once per frame
    void Update()
    {
        if (WallDown.randomDoorPicker == 2)
        {
            transform.position += new Vector3(0, -1 * WallDown.speedWallDown * Time.deltaTime, 0);
            secondDoorDown.DoorPickerRight = +1;
        }
        if (transform.position.y < -24)
        {
            WallDown.randomDoorPicker = 0;
        }
    }
}
