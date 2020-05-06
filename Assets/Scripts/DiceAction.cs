using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceAction : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("BOOM", 0.5f,0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BOOM(){
        if(GameObject.Find("GM").GetComponent<GM>().enemys.Count > 0){
            GameObject obj = Instantiate(bullet);
            obj.transform.position = transform.position + new Vector3(0,0,-10);
            obj.GetComponent<BulletAction>().target = GameObject.Find("GM").GetComponent<GM>().enemys[0];
        }
        
    }
}
