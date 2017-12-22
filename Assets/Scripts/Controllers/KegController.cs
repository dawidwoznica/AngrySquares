using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KegController : MonoBehaviour
{


    void OnParticleCollision(GameObject other)
    {
        Destroy(gameObject);
    }

    void OnDestroy()
    {
        Instantiate(GameManager.KegManager.KegParts, transform.position, transform.rotation);
    }


}
