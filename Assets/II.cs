using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class II : MonoBehaviour
{
    // Start is called before the first frame update
    public float random_point_radius=100;
    Vector3 random_point;
    public Transform player;
    public GameObject random_point_prefab;
    Transform near_player;
    Transform my_transform;
    Transform target;
    NavMeshAgent agent;
    NavMeshPath nav_mesh_path;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        my_transform = GetComponent<Transform>;
        target = random_point_radius;
        near_player = Instantiate()
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
