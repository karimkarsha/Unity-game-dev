using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColourOnCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Color randomlySelectedColor = GetRandomColor();
        GetComponent<Renderer>().material.color = randomlySelectedColor;
    }


    private Color GetRandomColor() => new Color(

            r: UnityEngine.Random.Range(0f, 1f),
            g: UnityEngine.Random.Range(0f, 1f),
            b: UnityEngine.Random.Range(0f, 1f));
}
