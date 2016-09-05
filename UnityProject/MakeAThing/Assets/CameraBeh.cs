﻿using UnityEngine;
using System.Collections;

public class CameraBeh : MonoBehaviour {

    public Transform target;
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        Vector3 temp = transform.position;
        temp.x = target.position.x;
        temp.y = target.position.y;

        transform.position = temp;
	}
}
