using UnityEngine;
using System.Collections;

public class targetFollow : MonoBehaviour {

    public Transform target;
    public float speed;
    private float step;

	// Use this for initialization
	void Start () {
        //target = GetComponentInParent<Transform>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector3 center = (transform.position + target.position + mousePos) / 3;

        step = speed * Time.deltaTime;
        transform.position = Vector3.Lerp(transform.position, center, step);
	}
}
