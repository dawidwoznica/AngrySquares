using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionKegController : MonoBehaviour
{

    public ParticleSystem KegExplosion;

    void OnDestroy()
    {
        Instantiate(KegExplosion, transform.position, transform.rotation);
    }
}
