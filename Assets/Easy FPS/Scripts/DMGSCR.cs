using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DMGSCR : MonoBehaviour
{
    public int damage = 2;
    public float damageInterval = 1.0f;
    public HPDMGSCRIPT playerHealth;

    private float damageTimer = 0f;

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            damageTimer += Time.deltaTime;
            if (damageTimer >= damageInterval)
            {
                playerHealth.TakeDamage(damage);
                damageTimer = 0f;
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            damageTimer = 0f;
        }
    }
}       
