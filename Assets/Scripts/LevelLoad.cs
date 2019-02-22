using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoad : MonoBehaviour {

    public GameObject LoadingScreen;
    private int degree = 5;
    public GameObject wheel;
    void Update()
    {
        Rotation();

    }
    public void levelLoad(int index)
    {
        LoadingScreen.SetActive(true);
        index = 1;
        StartCoroutine(LoadAsyncronasly(index));
    }
    IEnumerator LoadAsyncronasly(int index  )
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(index);
        Rotation();
        while (!operation.isDone)
        {
            Rotation();
        }
        if (!operation.isDone)
        {
            Rotation();
            yield return null;
        }
    }
    void Rotation()
    {
        wheel.transform.Rotate(0, 0, degree * Time.deltaTime);
        degree += 5;
    }
}
