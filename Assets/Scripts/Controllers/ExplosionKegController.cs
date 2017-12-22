using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionKegController : MonoBehaviour
{

    void OnDestroy()
    {
        Instantiate(GameManager.KegManager.KegExplosion, transform.position, transform.rotation);
    }
}
