using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("������� �������� � ��������: " + other.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("����� �������� �����, ��������� �����");
            SceneManager.LoadScene("win");
            Cursor.lockState = CursorLockMode.None;
        }
    }

}
