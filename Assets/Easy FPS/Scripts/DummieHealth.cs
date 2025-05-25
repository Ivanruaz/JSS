using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummieHealth : MonoBehaviour
{
    [Tooltip("Количество попаданий до уничтожения")]
    public int hitsToDestroy = 7;

    private int currentHits = 0;

    [Tooltip("Префаб крови при попадании")]
    public GameObject bloodEffect;

    public void TakeHit(Vector3 hitPoint, Vector3 hitNormal)
    {
        currentHits++;

        // Создаём кровь
        if (bloodEffect != null)
        {
            Instantiate(bloodEffect, hitPoint, Quaternion.LookRotation(hitNormal));
        }

        // Удаляем объект, если получено нужное количество попаданий
        if (currentHits >= hitsToDestroy)
        {
            Destroy(gameObject);
        }
    }
}
