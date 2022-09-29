using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XR.CoreUtils;

public class Test : MonoBehaviour
{
    [SerializeField]
    public AudioSource source;
    [SerializeField]
    public GameObject player;
   // [SerializeField]
   // private GameObject endPoint;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();

    }

  //  [SerializeField]
   // private float speed = 2.0f;
    //[SerializeField]
    //  public float timeMovingFwrd = 10;

    public bool walkingStart = false;


    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer != 3)
            return;

        XROrigin origin = other.gameObject.GetComponent<XROrigin>();
        if (origin == null)
            return;

        source.Play();

        walkingStart = false;
    }


    private void Update()
    {

        // if (timeMovingFwrd > 0)
        {
          //  if (walkingStart == false)
            //    return;

           // player.transform.position = Vector3.MoveTowards(transform.position, endPoint.transform.position, speed * Time.deltaTime);
            //( 0,0,1 * speed * Time.deltaTime);
            //.position = new Vector3(1, 100, 3);
            //(transform.forward * speed * Time.deltaTime, Space.World);
          //  source.Play();
            // timeMovingFwrd -= Time.deltaTime;
            //  }
            //  else
            //  {
            //  walkingStart = false;
            //  }
        }
    }
}
