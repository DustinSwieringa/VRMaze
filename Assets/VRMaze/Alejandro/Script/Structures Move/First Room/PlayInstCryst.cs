using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XR.CoreUtils;

public class PlayInstCryst : MonoBehaviour
{
    [SerializeField]
    private int play = 0;
    [SerializeField]
    private AudioSource instructions;

    // Start is called before the first frame update
    void Awake()
    {
        instructions = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer != 3)
            return;

        XROrigin origin = other.gameObject.GetComponent<XROrigin>();
        if (origin == null)
            return;

        play += 1;
        // Debug.Log(randomDoorPicker + "door number")

    }
    private void Update()
    {
        if(play ==1)
        {
            instructions.Play();
            play += 1;
        }
    }
}
