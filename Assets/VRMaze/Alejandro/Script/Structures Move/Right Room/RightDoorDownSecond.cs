using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightDoorDownSecond : MonoBehaviour
{
    CrystalThirdRoom secondDoorDown;
    [SerializeField]
    private GameObject thirdCrystal;
    [SerializeField]
    private float speedWallDown = 2.0f;

    // Start is called before the first frame update
    void Awake()
    {
        secondDoorDown = thirdCrystal.GetComponent<CrystalThirdRoom>();
    }

    // Update is called once per frame
    void Update()
    {
        if (secondDoorDown.DoorPickerRight == 2)
        {
            transform.position += new Vector3(0, -1 * speedWallDown * Time.deltaTime, 0); ;

        }
        if (transform.position.y < -24)
        {
            secondDoorDown.DoorPickerRight = 0;
        }
    }
}
