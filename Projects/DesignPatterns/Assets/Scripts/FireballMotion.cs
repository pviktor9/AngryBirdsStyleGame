﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballMotion : MonoBehaviour
{
    [SerializeField] private float Speed = 5.0f;

    void Update()
    {
        var pos = this.transform.position;
        pos.x += this.Speed * Time.deltaTime;
        this.transform.position = pos;
    }
}
