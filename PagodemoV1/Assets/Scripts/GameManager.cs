using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public int NumOfFollowFriends;
    [SerializeField] public int NumOfFriendsInPagode;

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
