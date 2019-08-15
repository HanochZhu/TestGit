using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Timers;
using System;

public class Testframe : MonoBehaviour
{

    float time = 5f;
    float curtime = 0f;
    GameObject cube;

    private void Awake()
    {
        Color32 c = new Color32();
        Color color = new Color();
        Application.targetFrameRate = 30;
    }

    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = Vector3.zero;
    }



    // Update is called once per frame
    void Update()
    {
        Debug.Log("update");

        curtime += Time.deltaTime;
        if (curtime > time)
        {
            GameObject.Destroy(cube);
            curtime = 0f;
        }

    }

    private void FixedUpdate()
    {
        //Debug.Log("fixed update");
    }
}
