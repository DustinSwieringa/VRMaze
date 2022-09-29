using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftMovement : MonoBehaviour
{
    [SerializeField]
    public bool elevatorMove = false;
    [SerializeField]
    private float speed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (elevatorMove == true)
        {
           transform.position += new Vector3(0, 1 * speed * Time.deltaTime, 0);
        }

        if (transform.position.y >= 12.6)
        {
            elevatorMove = false;
        }
    }
}
