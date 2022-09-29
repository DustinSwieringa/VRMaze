using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XR.CoreUtils;

public class Music : MonoBehaviour
{
    [SerializeField]
    public bool musicON = true;
    [SerializeField]
    private AudioSource music;

    // Start is called before the first frame update
    void Awake ()
    {
        music.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer != 3)
            return;

        XROrigin origin = other.gameObject.GetComponent<XROrigin>();
        if (origin == null)
            return;

        music.Play();
    }

    private void Update()
    {
        if (musicON == false)
        {
            Destroy(gameObject);
        }
    }
}
