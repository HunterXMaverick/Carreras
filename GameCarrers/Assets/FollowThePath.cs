using UnityEngine;

public class FollowThePath : MonoBehaviour
{

    public Transform[] waypoints;

    [SerializeField]
    //movimiento especial del jugador (f=float)
    private float moveSpeed = 1f;

    [HideInInspector]
    //traes el index
    public int waypointIndex = 0;

    //movimiento permitido
    public bool moveAllowed = false;

    private void Start()
    {
        //trae el punto con los index
        transform.position = waypoints[waypointIndex].transform.position;
    }

    // movimiento permitido 
    private void Update()
    {
        if (moveAllowed)
            Move();
    }


    private void Move()
    {

        if (waypointIndex <= waypoints.Length - 1)
        {
            // 
            transform.position = Vector2.MoveTowards(transform.position,
            waypoints[waypointIndex].transform.position,
            moveSpeed * Time.deltaTime);

            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;
            }
        }
    }
}