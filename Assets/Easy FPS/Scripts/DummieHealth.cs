using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummieHealth : MonoBehaviour
{
    [Tooltip("���������� ��������� �� �����������")]
    public int hitsToDestroy = 7;

    private int currentHits = 0;

    [Tooltip("������ ����� ��� ���������")]
    public GameObject bloodEffect;

    public void TakeHit(Vector3 hitPoint, Vector3 hitNormal)
    {
        currentHits++;

        // ������ �����
        if (bloodEffect != null)
        {
            Instantiate(bloodEffect, hitPoint, Quaternion.LookRotation(hitNormal));
        }

        // ������� ������, ���� �������� ������ ���������� ���������
        if (currentHits >= hitsToDestroy)
        {
            Destroy(gameObject);
        }
    }
}
