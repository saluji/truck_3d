﻿using UnityEngine;

public class Rotate : MonoBehaviour
{

    public float speed = 10;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime, Space.World);
    }
}
