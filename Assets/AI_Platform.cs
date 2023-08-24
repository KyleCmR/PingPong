using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Platform : MonoBehaviour
{
    //[SerializeField] private GameObject _ball;
    public Transform target; // ������� ������, �� ������� ����� �������

    void Update()
    {
        if (target != null)
        {
            Vector3 newPosition = transform.position; // �������� ������� ������� �������, ������� ������ �������

            newPosition.x = target.position.x; // ������������� ����� �������� ������ ��� X �������, ����� ��������� Y � Z ��������

            transform.position = newPosition; // ������������� ����� ������� �������, ������� ������ �������
        }
    }
}
