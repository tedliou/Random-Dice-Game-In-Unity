using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject startPos, middlePos, EndPos;
    public TextMesh lifeText;
    public float speedValue;
    public int life = 10;
    List<Vector3> path = new List<Vector3>(); 
    int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 v = startPos.transform.position;
        while(v.y<middlePos.transform.position.y){
            path.Add(v += new Vector3(0,speedValue,0));
        }
        
        while(v.x<EndPos.transform.position.x){
            path.Add(v += new Vector3(speedValue,0,0));
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        lifeText.text = life.ToString();
        transform.position = path[index];
        index++;
        
        if(index == path.Count){
            GameObject.Find("GM").GetComponent<GM>().enemys.Remove(this.gameObject);
            Destroy(this.gameObject);
        }
    }

    /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Bullet"){
            Destroy(other.gameObject);
            life -= 1;
            if(life <= 0){
                GameObject.Find("GM").GetComponent<GM>().enemys.Remove(this.gameObject);
                Destroy(this.gameObject);
                
            }
        }
    }
}
