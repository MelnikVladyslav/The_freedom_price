using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public Slider loadingSlider;

    public Text loadingText;

    private float loadingSpeed = 0.5f;

    private float targetValue;

    private AsyncOperation operation;

    void Start()
    {
        loadingSlider.value = 0.0f;

        if (SceneManager.GetActiveScene().name == "Load")
        {
            StartCoroutine(AsyncLoading(2));
        }
    }

    IEnumerator AsyncLoading(int id)
    {
        operation = SceneManager.LoadSceneAsync(id);
        operation.allowSceneActivation = false;

        yield return operation;
    }

    // Update is called once per frame
    void Update()
    {
        targetValue = operation.progress;

        if (operation.progress >= 0.9f)
        {
            targetValue = 1.0f;
        }

        if (targetValue != loadingSlider.value)
        {
            loadingSlider.value = Mathf.Lerp(loadingSlider.value, targetValue, Time.deltaTime * loadingSpeed);
            if (Mathf.Abs(loadingSlider.value - targetValue) < 0.01f)
            {
                loadingSlider.value = targetValue;
            }
        }

        loadingText.text = ((int)(loadingSlider.value * 100)).ToString() + "%";

        if ((int)(loadingSlider.value * 100) == 100)
        {
            operation.allowSceneActivation = true;
        }
    }
}
