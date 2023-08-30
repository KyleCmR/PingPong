using TMPro;
using UnityEngine;

public class ScoreComputer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _score;

    private Ball _reloadRound;
    private int _point = 0;

    private void Awake()
    {
        _reloadRound = GameObject.Find("Ball").GetComponent<Ball>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            _point += 1;
            _score.text = _point.ToString();
            RestartScrip();
        }
    }

    void RestartScrip()
    {
        if (_reloadRound != null)
        {
            _reloadRound.StartPosition();
        }
    }
}
