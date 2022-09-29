using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XR.CoreUtils;

public class GateCloseTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject moveGate;
    [SerializeField]
    private AudioSource source;
    private bool gateClosed = false;
    [SerializeField]
    private float speed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gateClosed == true)    
        {
            moveGate.transform.position += new Vector3(0, 1 * speed * Time.deltaTime, 0);
        }

        if (moveGate.transform.position.y > 0)
        {
           // Debug.Log("closededed");
            gateClosed = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer != 3)
            return;

        XROrigin origin = other.gameObject.GetComponent<XROrigin>();
        if (origin == null)
            return;

//        Debug.Log("open");
        gateClosed = true;
        source.Play();

        

    }

}
