﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRiverControls : MonoBehaviour
{
    public RiverController river = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            river.moveRiver(Vector3.left * Time.deltaTime);
        }
    }
}
