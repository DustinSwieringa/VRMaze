using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XR.CoreUtils;

public class CastleMove : MonoBehaviour
{
    [SerializeField]
    private AudioSource instructions;
    [SerializeField]
    private bool playMusic = true;
    [SerializeField]
    GameObject moveCastle;
    private bool castleUp = false;
    [SerializeField]
    private float speed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        instructions = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (castleUp == true)
        {
            moveCastle.transform.position += new Vector3(0, 1 * speed * Time.deltaTime, 0);
        }

        if (moveCastle.transform.position.y > 13)
        {
           // Debug.Log("castle up");
            castleUp = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer != 3)
            return;

        XROrigin origin = other.gameObject.GetComponent<XROrigin>();
        if (origin == null)
            return;

       // Debug.Log("open");
        castleUp = true;
        if (playMusic == true)
        {
            instructions.Play();
            playMusic = false;
        }

    }

}