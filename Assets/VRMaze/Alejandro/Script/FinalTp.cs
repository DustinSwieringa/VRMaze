using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XR.CoreUtils;

public class FinalTp : MonoBehaviour
{
    [SerializeField]
    private Transform _teleportPosition;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer != 3)
            return;

        XROrigin origin = other.gameObject.GetComponent<XROrigin>();
        if (origin == null)
            return;

        Vector3 targetPosition = _teleportPosition.position;
        targetPosition.y += origin.CameraInOriginSpaceHeight;
        origin.MoveCameraToWorldLocation(targetPosition);
    }
}
