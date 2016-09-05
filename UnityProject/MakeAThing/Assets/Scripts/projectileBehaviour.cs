using UnityEngine;
using System.Collections;

public class projectileBehaviour : MonoBehaviour {

    public float time;
    private float currAge;
    public float speed;
    public AnimationCurve speedCurve;	
	
	// Update is called once per frame
	void Update ()
    {
        currAge += Time.deltaTime;

        float curveValue = speedCurve.Evaluate(1.0f - (currAge/time));

        Transform trans = transform;
        trans.position += (transform.up) * (speed * curveValue) * Time.deltaTime;
        transform.position = trans.position;

        time -= Time.deltaTime;

        if (time < 0)
            Destroy(gameObject);
	}
}
