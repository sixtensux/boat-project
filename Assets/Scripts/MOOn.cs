using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOOn : MonoBehaviour
{

    private float rotateSpeed = 0.5f;
    private float radius = 4.8f;

    private Vector2 _centre;
    private float _angle;

    private void Start()
    {
        _centre = GameObject.Find("Planet").GetComponent<Transform>().transform.position;
    }

    private void Update()
    {

        _angle += rotateSpeed * Time.deltaTime;

        var offset = new Vector2(Mathf.Sin(_angle), Mathf.Cos(_angle)) * radius;
        transform.position = _centre + offset;
    }
}
