using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    
    public float OnscrennDelay = 3f;
    void Start()
    {
        Destroy(this.gameObject, OnscrennDelay);
    }


}
