using UnityEngine;

public class AI_Platform : MonoBehaviour
{
    public Transform _target; // ������� ������, �� ������� ����� �������
    public MiddleZone _middleZone;
    private Vector3 _startPosition;
    public float _speed;
    private void Awake()
    {
        _middleZone = GameObject.FindFirstObjectByType<MiddleZone>();
    }
    private void Start()
    {
        _startPosition = new Vector3 (0,5);
        transform.position = _startPosition;
    }
    void Update()
    {
        Vector3 _newPosition = transform.position; // �������� ������� ������� �������, ������� ������ �������
        Vector3 _currentPosition = transform.position;
        _currentPosition.x = _target.position.x;


        if (_middleZone._objectTransform != null)
        {
            _newPosition = Vector3.MoveTowards(transform.position, _currentPosition, _speed * Time.deltaTime);
            transform.position = _newPosition; // ������������� ����� ������� �������, ������� ������ �������
        }
        else if (_middleZone._objectTransform == null)
        {
            _newPosition = Vector3.MoveTowards(transform.position, _startPosition, _speed * Time.deltaTime);

            transform.position = _newPosition;
        }
    }
}
