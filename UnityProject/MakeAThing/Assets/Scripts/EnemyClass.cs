using UnityEngine;
using System.Collections;

public class EnemyClass : MonoBehaviour {

    public float maxHealth;
    public float health;

    public float damage;

    public float speed;

    private Transform target;

	// Use this for initialization
	void Awake ()
    {
        health = maxHealth;
        target = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        Vector2 dir = target.position - transform.position;
        transform.rotation = Quaternion.LookRotation(dir);    
    }
}
