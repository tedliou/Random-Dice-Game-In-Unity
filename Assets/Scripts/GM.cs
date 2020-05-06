using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{
    public GameObject spawnPos,middlePos,endPos, enemy;
    public List<GameObject> enemys = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn(){
        GameObject obj = Instantiate(enemy);
        obj.transform.position = spawnPos.transform.position;
        obj.GetComponent<EnemyMove>().startPos = spawnPos;
        obj.GetComponent<EnemyMove>().middlePos = middlePos;
        obj.GetComponent<EnemyMove>().EndPos = endPos;
        enemys.Add(obj);
    }
}
