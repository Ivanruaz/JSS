using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HPDMGSCRIPT : MonoBehaviour
{
    public int health;
    public int maxHealth = 10;

    public int damage = 2;

    public TextMesh healthText; // ������ ��� ���������� � ������ � ������� ������ � TextMesh � ����������

    void Start()
    {
        health = maxHealth;
        UpdateHealthText();  // ��������� ����� ��� ������
    }

    void Update()
    {
        // ������ �� ������ �����
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        UpdateHealthText();  // ��������� ����� ��� ��������� �����

        if (health <= 0)
        {
            Debug.Log("Menu");
            UnityEngine.Cursor.lockState = CursorLockMode.Confined;
            SceneManager.LoadScene("death");
            Debug.Log("You Death!");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Dummie")
        {
            TakeDamage(damage);
        }
    }

    void UpdateHealthText()
    {
        if (healthText != null)
        {
            healthText.text = "HP: " + health.ToString();
        }
    }
}
