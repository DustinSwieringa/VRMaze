using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XR.CoreUtils;

public class MusicOff : MonoBehaviour
{
    Music music;
    [SerializeField]
    private GameObject musicToggle;
    // Start is called before the first frame update
    void Awake()
    {
        music = musicToggle.GetComponent<Music>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer != 3)
            return;

        XROrigin origin = other.gameObject.GetComponent<XROrigin>();
        if (origin == null)
            return;

        music.musicON = false;
    }
}
