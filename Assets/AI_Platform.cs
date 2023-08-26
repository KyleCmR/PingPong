using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Platform : MonoBehaviour
{
    public Transform target; // ������� ������, �� ������� ����� �������
    public MiddleZone _middleZone;
    private Vector3 _startPosition;

    private void Awake()
    {
        _middleZone = GameObject.FindFirstObjectByType<MiddleZone>();
    }
    private void Start()
    {
        _startPosition = new Vector3 (0,5);
    }
    void Update()
    {
        Vector3 newPosition = transform.position; // �������� ������� ������� �������, ������� ������ �������

        if (_middleZone._objectTransform != null)
        {
            newPosition.x = target.position.x; // ������������� ����� �������� ������ ��� X �������, ����� ��������� Y � Z ��������

            transform.position = newPosition; // ������������� ����� ������� �������, ������� ������ �������
        }
        else if (_middleZone._objectTransform == null)
        {
            transform.position = Vector3.Lerp(_startPosition, newPosition, 0);
        }
    }
}
