using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Platform : MonoBehaviour
{
    //[SerializeField] private GameObject _ball;
    public Transform target; // Целевой объект, за которым нужно следить

    void Update()
    {
        if (target != null)
        {
            Vector3 newPosition = transform.position; // Получаем текущую позицию объекта, который должен следить

            newPosition.x = target.position.x; // Устанавливаем новое значение только для X позиции, чтобы сохранить Y и Z значения

            transform.position = newPosition; // Устанавливаем новую позицию объекта, который должен следить
        }
    }
}
