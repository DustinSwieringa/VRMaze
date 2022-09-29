
using UnityEngine;
using Unity.XR.CoreUtils;


public class StopMovement : MonoBehaviour
{
    Test onStartMove;
    [SerializeField]
    private AudioSource source;
    [SerializeField]
    GameObject moveInteractable;
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private int music = 0;

    void Awake()
    {
        onStartMove = moveInteractable.GetComponent<Test>();
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    //void Update()
    //{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer != 3)
            return;

        XROrigin origin = other.gameObject.GetComponent<XROrigin>();
        if (origin == null)
            return;

       // Debug.Log("oof");
        onStartMove.walkingStart = true;
        if (music == 0)
        {
            source.Play();
            music += 1;
        }

    }
}
