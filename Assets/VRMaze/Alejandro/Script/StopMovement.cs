
using UnityEngine;
using Unity.XR.CoreUtils;


public class StopMovement : MonoBehaviour
{
    Test onStartMove;
    [SerializeField]
    GameObject moveInteractable;
    [SerializeField]
    private GameObject player;

    void Awake()
    {
        onStartMove = moveInteractable.GetComponent<Test>();
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

    }
}
