using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonShow : MonoBehaviour
{
    public float waitTime = 2;

    void Start()
    {

        StartCoroutine(Intro());
    }

    IEnumerator Intro()
    {
        yield return new WaitForSeconds(waitTime);

        WebGLPluginJS.GameFinished();
    }
}
