using UnityEngine;

public class MiddleZone : MonoBehaviour
{
    public Transform _objectTransform;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            _objectTransform = collision.transform;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            _objectTransform = null;
        }
    }
}
