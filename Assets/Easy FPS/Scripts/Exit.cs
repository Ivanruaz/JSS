using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    // Выход из игры (работает и в билде, и в редакторе)
    public void exiter()
    {
        Debug.Log("Вызван выход из игры");
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
