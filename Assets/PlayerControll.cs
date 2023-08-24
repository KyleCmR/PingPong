using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    [SerializeField] public float _speed = 0.15f;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
           transform.position -= new Vector3(_speed, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(_speed, 0);
        }
    }
}
