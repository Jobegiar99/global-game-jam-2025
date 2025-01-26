using UnityEngine;
using System.Collections;

public class QuitGame : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();  
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
