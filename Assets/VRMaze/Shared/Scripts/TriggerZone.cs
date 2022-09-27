using UnityEngine;
using UnityEngine.Events;

public class TriggerZone : MonoBehaviour
{
    public UnityEvent OnTriggered;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer != 3)
            return;

        OnTriggered?.Invoke();
        Destroy(gameObject);
    }
}
