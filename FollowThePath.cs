using UnityEngine;
using System.Collections;

public class FollowThePath : MonoBehaviour {

    private AudioSource audioSource;

    public Transform[] waypoints;
    public AudioClip walksound;

    [SerializeField]
    private float moveSpeed = 1f;

    [HideInInspector]
    public int waypointIndex = 0;

    public bool moveAllowed = false;

	// Use this for initialization
	private void Start () {
        transform.position = waypoints[waypointIndex].transform.position;
        this.audioSource = this.gameObject.AddComponent<AudioSource>();
        this.audioSource.clip = this.walksound;
        this.audioSource.loop = false;
        this.audioSource.Play();
    }
	
	// Update is called once per frame
	private void Update () {

        if (moveAllowed)
        {
            Move();
        }
        
    }
    private void Move()
    {
        if (waypointIndex <= waypoints.Length - 1)
        {
           // this.audioSource.Play();
            transform.position = Vector2.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, moveSpeed * Time.deltaTime);

            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;
            }
            
        }
        
    }
}
