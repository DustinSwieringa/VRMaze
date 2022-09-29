using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorControl : MonoBehaviour
{
    LiftMovement liftMovement;
    [SerializeField]
    private GameObject lift;
    // Start is called before the first frame update
    void Awake()
    {
        liftMovement = lift.GetComponent<LiftMovement>();
    }

    private void OnCollisionEnter(Collision collision)
    {
     if (collision.gameObject.name == "ray_01")
        {
         //   Debug.Log("touchdown");
            Destroy(collision.gameObject);
            liftMovement.elevatorMove = true;
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
