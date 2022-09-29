using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTheElevator : MonoBehaviour
{
    [SerializeField]
    private AudioSource inst;
    [SerializeField]
    public int gemsCollected = 0;
    [SerializeField]
    private float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        inst.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(gemsCollected);
        if (gemsCollected==4)
        {
            inst.Play();
            transform.position += new Vector3(0, -1 * speed * Time.deltaTime, 0);
        }
        if (transform.position.y < -24)
        {
           // Debug.Log("Elevator Open");
           gemsCollected = 0;
        }
    }
}
