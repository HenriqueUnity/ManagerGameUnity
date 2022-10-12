using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    [SerializeField] string scenename;

    public void LoadLevelButton()
    {
        SceneManager.LoadScene(scenename);
    }
}
