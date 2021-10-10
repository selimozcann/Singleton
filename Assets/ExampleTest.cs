using System;
using UnityEngine;
public class ExampleTest : MonoBehaviour
{
    private void OnEnable()
    {
        GameManager.Instance.ObjectActive();
    }
    private void OnDisable()
    {
        GameManager.Instance.DisActiveObject();   
    }
}
