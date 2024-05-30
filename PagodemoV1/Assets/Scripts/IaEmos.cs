using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IaEmos : MonoBehaviour
{
    [SerializeField] private NavMeshAgent Emos;
    [SerializeField] private Transform Pagode;
    [SerializeField] private GameManager _GameManager;

    void Start()
    {
        Emos = GetComponent<NavMeshAgent>();
        Pagode = GameObject.FindWithTag("Pagode").transform;
        _GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    void Update()
    {
        Emos.SetDestination(Pagode.position);
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pagode"))
        {
            //StartCoroutine(DestroyFriend());
        }
        if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.K))
        {
            DestroyEmo();
        }
    }
    IEnumerator DestroyFriend()
    {
        yield return new WaitForSeconds(15);
        _GameManager.NumOfFollowFriends--;
        Destroy(gameObject);
    }
    public void DestroyEmo()
    {
        Destroy(gameObject);
    }
}
