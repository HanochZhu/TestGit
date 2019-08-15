using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TestDllInAndroid;
using UnityEngine.UI;

public class TestDllAndroid : MonoBehaviour
{

    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        TestDllInAndroid.Program td = new TestDllInAndroid.Program();
        int a = td.GetANumber("ssss");

        text.text = a.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
