using TMPro;
using UnityEngine;

public class ScoreComputer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _score;
    [SerializeField] private TextMeshProUGUI _result;
    [SerializeField] private GameObject _menu;
    [SerializeField] private PlayerControll _playerControl;


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
