using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] public int NumOfFollowFriends;
    [SerializeField] public int NumOfFriendsInPagode;

    public float startTimer = 90f;
    public float currentTimer;

    private void Start()
    {
        currentTimer = startTimer;
    }

    private void Update()
    {
        Debug.Log(currentTimer);
        currentTimer -= Time.deltaTime;

        if (currentTimer <= 0 )
        {
            SceneManager.LoadScene(1);
        }

        if (NumOfFollowFriends < 0)
        {
            SceneManager.LoadScene(2);
        }

        if (NumOfFollowFriends < 0)
        {
            //NumOfFollowFriends = 0;
        }
    }
    public void FollowPlayer()
    {
        NumOfFollowFriends++;
    }

    public void FriendsInPagode()
    {
        NumOfFriendsInPagode = NumOfFollowFriends;
        NumOfFollowFriends = 0;
    }
}
