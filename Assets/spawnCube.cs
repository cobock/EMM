﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCube : MonoBehaviour
{
    public GameObject cubePrefab;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(cubePrefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
