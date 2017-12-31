using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public void KegDestroyed()
    {
        GameManager.PlayerManager.KegsLeft--;
    }

    public void CannonBalShot()
    {
        GameManager.PlayerManager.CannonBallsLeft--;
    }

    public void Reset(int cannonBalls, int kegs)
    {
        GameManager.PlayerManager.CannonBallsLeft = cannonBalls;
        GameManager.PlayerManager.KegsLeft = kegs;
    }
}
