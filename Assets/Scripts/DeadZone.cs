using UnityEngine;
using UnityEngine.Events;

public class DeadZone : MonoBehaviour
{
    [SerializeField] private Transform _respaunPoint;
    public event UnityAction DeadZoneEnter;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("DeadZone"))
        {
            OnDeadZoneEnter();
        }
    }

    private void OnDeadZoneEnter()
    {
        DeadZoneEnter?.Invoke();
        transform.position = _respaunPoint.position;
    }
}
