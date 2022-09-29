using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Test onStartMove;
    [SerializeField]
    GameObject moveInteractable;
    [SerializeField]
    private float speed = 2.0f;
    [SerializeField]
    private GameObject endPoint;


    // Start is called before the first frame update
    void Awake()
    {
        onStartMove = moveInteractable.GetComponent<Test>();
    }

    // Update is called once per frame
    void Update()
    {
        if (onStartMove.walkingStart == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPoint.transform.position, speed * Time.deltaTime);
        }

    }

   void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == endPoint)        
        {
            onStartMove.walkingStart = true;
           // Debug.Log("oofeerino");
        }
    }
}
