using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    // ����� �� ���� (�������� � � �����, � � ���������)
    public void exiter()
    {
        Debug.Log("������ ����� �� ����");
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
