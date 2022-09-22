using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum LocomotionType
{
    None = 0,
    Teleportation,
    Continuous,
}

public class LocomotionController : MonoBehaviour
{
    public LocomotionType CurrentLocomotionType { get; private set; }

    [SerializeField]
    private LocomotionType _defaultLocomotionSystem;

    [Header("Teleportation Locomotion")]
    [SerializeField]
    private GameObject _teleportLocomotion;

    [Header("Continuous Locomotion")]
    [SerializeField]
    private GameObject _continuousLocomotion;

    public void SwitchSystem(LocomotionType locomotionType)
    {
        if (locomotionType == CurrentLocomotionType)
            return;

        _teleportLocomotion.SetActive(locomotionType == LocomotionType.Teleportation);
        _continuousLocomotion.SetActive(locomotionType == LocomotionType.Continuous);
        CurrentLocomotionType = locomotionType;
    }

    private void Start()
    {
        SwitchSystem(_defaultLocomotionSystem);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ContinuousMovement"))
        {
            SwitchSystem(LocomotionType.Continuous);
        }
        else if (other.CompareTag("TeleportMovement"))
        {
            SwitchSystem(LocomotionType.Teleportation);
        }
        else if (other.CompareTag("NoMovement"))
        {
            SwitchSystem(LocomotionType.None);
        }
    }
}