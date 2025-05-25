using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HPDMGSCRIPT : MonoBehaviour
{
    public int health;
    public int maxHealth = 10;

    public int damage = 2;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int amount)
    {
        health -= amount;

        if (health <= 0)
        {
            Debug.Log("Menu");
            UnityEngine.Cursor.lockState = CursorLockMode.Confined;
            SceneManager.LoadScene("menu");
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
}
