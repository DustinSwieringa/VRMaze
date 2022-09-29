using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XR.CoreUtils;

public class Squeek : MonoBehaviour
{
    [SerializeField]
    private AudioSource squeek;
    // Start is called before the first frame update
    void Start()
    {
        squeek.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer != 3)
            return;

        XROrigin origin = other.gameObject.GetComponent<XROrigin>();
        if (origin == null)
            return;
        squeek.Play();

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
