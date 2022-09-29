using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftDoorDownSecond : MonoBehaviour
{
    CrystalSecondRoom secondDoorDown;
    [SerializeField]
    private GameObject secondCrystal;
    [SerializeField]
    private float speedWallDown = 2.0f;

    // Start is called before the first frame update
    void Awake()
    {
        secondDoorDown = secondCrystal.GetComponent<CrystalSecondRoom>();
    }

    // Update is called once per frame
    void Update()
    {
        if (secondDoorDown.DoorPickerLeft == 2)
        {
            transform.position += new Vector3(0, -1 * speedWallDown * Time.deltaTime, 0);;

        }
        if (transform.position.y < -24)
        {
            secondDoorDown.DoorPickerLeft = 0;
        }
    }
}
