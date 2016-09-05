using UnityEngine;
using System.Collections;

public class playerLookat : MonoBehaviour {

    private Transform target;

	// Use this for initialization
	void Start ()
    {
        target = gameObject.transform;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector2 dir = (mousePos - (Vector2)transform.position).normalized;
        target.up = dir;
	}
}
