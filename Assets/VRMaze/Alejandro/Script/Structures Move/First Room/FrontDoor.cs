using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontDoor : MonoBehaviour
{
    RandomWallDown WallDown;
    [SerializeField]
    private GameObject firstCrystal;

    // Start is called before the first frame update
    void Awake()
    {
        WallDown = firstCrystal.GetComponent<RandomWallDown>();
    }

    // Update is called once per frame
    void Update()
    {
        if (WallDown.randomDoorPicker == 1)
        {
            transform.position += new Vector3(0, -1 * WallDown.speedWallDown * Time.deltaTime, 0);
        }
        if (transform.position.y < -24)
        {
            //Debug.Log("door front down");
            WallDown.randomDoorPicker = 0;
        }
    }
}
