using UnityEngine;

public class Ball : MonoBehaviour
{
    private float _speed = -40f;
    private Rigidbody2D _rb2d;
    private Vector2 _direction;

    private void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
        _direction = new Vector2(-1, -1);
    }

    void FixedUpdate()
    {
        _rb2d.velocity = _direction * 5f; 
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.gameObject.CompareTag("Platform"))
        //{
            _direction = -_direction; // »змен€ем направление движени€ на противоположное
        //}

    }
}
