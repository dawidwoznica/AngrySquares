using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KegController : MonoBehaviour
{

    public ParticleSystem KegParts;


    void OnDestroy()
    {
        Instantiate(KegParts, transform.position, transform.rotation);
    }


}
