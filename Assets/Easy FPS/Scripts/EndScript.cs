using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Триггер сработал с объектом: " + other.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("Игрок коснулся блока, загружаем сцену");
            SceneManager.LoadScene("win");
            Cursor.lockState = CursorLockMode.None;
        }
    }

}
