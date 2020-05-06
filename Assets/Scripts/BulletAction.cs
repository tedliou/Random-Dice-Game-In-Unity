﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAction : MonoBehaviour
{
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(target == null){
            Destroy(this.gameObject);
        }else{
            transform.position = Vector3.Lerp(transform.position, target.transform.position, 0.1f);
        }
    }
}
