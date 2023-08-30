using UnityEngine;

public class Ball : MonoBehaviour
{
    public float _speed;
    private Rigidbody2D _rb2d;

    private void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        StartPosition();
    }
    void StartBall()
    {
        float x = Random.Range(0, 2) == 0 
            ? -1 
            : 1;
        float y = Random.Range(0, 2) == 0 
            ? -1 
            : 1;
        _rb2d.velocity = new Vector2(_speed * x, _speed * y);
    }

    public void StartPosition()
    {
        StartBall();
        Vector3 _startPosition = new Vector3(0, 0);
        transform.position = _startPosition;
    }
}
