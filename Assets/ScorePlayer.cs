using TMPro;
using UnityEngine;

public class ScorePlayer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _score;
    [SerializeField] private Transform _startPosition;
    private int _point = 0;

    private void Awake()
    {
        _startPosition = GetComponent<Transform>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            _point += 1;
            _score.text = _point.ToString();
            _startPosition.position = new Vector2(0, 5);
        }
    }
}
