using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour
{
    [Tooltip("Furthest distance bullet will look for target")]
    public float maxDistance = 1000000f;

    RaycastHit hit;

    [Tooltip("Prefab of wall damage hit. The object needs 'LevelPart' tag to create decal on it.")]
    public GameObject decalHitWall;

    [Tooltip("Decal will need to be slightly in front of the wall so it doesn't cause rendering problems. Recommended 0.01 - 0.1.")]
    public float floatInfrontOfWall = 0.05f;

    [Tooltip("Put Weapon and Player layers to ignore bullet raycast.")]
    public LayerMask ignoreLayer;

    void Update()
    {
        // Выполняем Raycast вперёд
        if (Physics.Raycast(transform.position, transform.forward, out hit, maxDistance, ~ignoreLayer))
        {
            // Попадание по стене
            if (hit.transform.CompareTag("LevelPart"))
            {
                if (decalHitWall != null)
                {
                    Instantiate(decalHitWall, hit.point + hit.normal * floatInfrontOfWall, Quaternion.LookRotation(hit.normal));
                }
            }
            // Попадание по дамми
            else if (hit.transform.CompareTag("Dummie"))
            {
                DummieHealth dummie = hit.transform.GetComponent<DummieHealth>();
                if (dummie != null)
                {
                    dummie.TakeHit(hit.point, hit.normal);
                }
            }

            // Удаляем пулю после попадания
            Destroy(gameObject);
        }

        // Удаляем пулю через 0.1 сек, если никуда не попала
        Destroy(gameObject, 0.1f);
    }
}
