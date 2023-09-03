using TMPro;
using UnityEngine;

public class ScorePlayer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scorePlayer;
    [SerializeField] private TextMeshProUGUI _scoreEnemy;

    [SerializeField] private GameObject _playerZone;
    [SerializeField] private GameObject _enemyZone;

    [SerializeField] private TextMeshProUGUI _result;
    [SerializeField] private GameObject _menu;
    [SerializeField] private PlayerControll _playerControl;

    private bool _enZ;
    private bool _plZ;

    private Ball _reloadRound;
    private int _point = 0;

    private void Awake()
    {
        _reloadRound = GameObject.Find("Ball").GetComponent<Ball>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var currentZone = collision.gameObject.CompareTag("PlayerZone") ? 
        if (collision.gameObject.CompareTag("PlayerZone"))
        {
            _point += 1;
            _scorePlayer.text = _point.ToString();
            RestartScrip();
            if (_point >= 10)
            {
                _playerControl._speed = 0;
                collision.gameObject.SetActive(false);
                _result.text = "You Win";
                _menu.SetActive(true);
            }
        }
        if (collision.gameObject.CompareTag("EnemyZone"))
        {
            _point += 1;
            _scoreEnemy.text = _point.ToString();
            RestartScrip();
            if (_point >= 10)
            {
                _playerControl._speed = 0;
                collision.gameObject.SetActive(false);
                _result.text = "You Lose";
                _menu.SetActive(true);
            }
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
