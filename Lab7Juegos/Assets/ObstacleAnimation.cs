using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ObstacleAnimation : MonoBehaviour
{

	public float speed = .1f;
	public float strength = 4f;
	private float randomOffset;

	public Transform target;
	public Transform target1;
	public Transform target3;

	NavMeshAgent agent;
	// Use this for initialization
	void Start()
	{
		agent = GetComponent<NavMeshAgent>();
		randomOffset = Random.Range(0f, 1f);
	}

	// Update is called once per frame
	void Update()
	{
		agent.SetDestination(target.position);
		agent.SetDestination(target1.position);
		agent.SetDestination(target3.position);
		Vector3 pos = transform.position;
		pos.x = Mathf.Sin(Time.time * speed + randomOffset) * strength;
		transform.position = pos;
	}
}