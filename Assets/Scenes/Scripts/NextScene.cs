using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    [SerializeField] string scenename;
    public void GoScene()
    {
        SceneManager.LoadScene(scenename);
    }
}
