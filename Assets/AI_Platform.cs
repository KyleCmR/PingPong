using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Platform : MonoBehaviour
{
    public Transform target; // Целевой объект, за которым нужно следить
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
        Vector3 newPosition = transform.position; // Получаем текущую позицию объекта, который должен следить

        if (_middleZone._objectTransform != null)
        {
            newPosition.x = target.position.x; // Устанавливаем новое значение только для X позиции, чтобы сохранить Y и Z значения

            transform.position = newPosition; // Устанавливаем новую позицию объекта, который должен следить
        }
        else if (_middleZone._objectTransform == null)
        {
            transform.position = Vector3.Lerp(_startPosition, newPosition, 0);
        }
    }
}
