﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createSphere : MonoBehaviour {

    void Start()
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = new Vector3(0, 1.5f, 0);

        GameObject capsule = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        capsule.transform.position = new Vector3(2, 1, 0);
    }
}
