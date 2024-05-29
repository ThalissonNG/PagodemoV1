using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IaFriends : MonoBehaviour
{
    [SerializeField] private NavMeshAgent Friends;
    [SerializeField] private Transform Player;

    [SerializeField] private bool IsFriends;
    [SerializeField] private bool PlayerIsRange;

    public PlayerMovement _PlayerMovement;

    void Start()
    {
        Friends = GetComponent<NavMeshAgent>();
        Player = GameObject.FindWithTag("Player").transform;

        _PlayerMovement = Player.GetComponent<PlayerMovement>();
    }
    void Update()
    {
        FollowPlayer();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerIsRange = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerIsRange = false;
        }
    }
    private void FollowPlayer()
    {
        if (PlayerIsRange && Input.GetKeyDown(KeyCode.I))
        {
            IsFriends = true;
        }

        if (IsFriends)
        {
            Friends.SetDestination(Player.position);
        }
    }
}
