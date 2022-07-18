using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float aliveTime;
    public float damage;
    public float moveSpeed;
    // public GameObject _bulletSpawn;
    // [SerializeField]
    // public GameObject enemyTriggered;


    // Start is called before the first frame update
    void Start()
    {
        aliveTime = 5.0f;
        damage=10.0f;
        moveSpeed=30.0f;
        // this.transform.rotation=_bulletSpawn.transform.rotation;
        
    }

    // Update is called once per frame
    void Update()
    {
        aliveTime-=1*Time.deltaTime;
        if (aliveTime<=0)
        {
            Destroy(this.gameObject);
        }
                // this.gameObject.GetComponent<Rigidbody>().AddForce(0.0f,0.0f,19.0f);


        this.transform.Translate(Vector3.forward * Time.deltaTime *moveSpeed);
        
        // Shorthand for writing Vector3(0, 0, 1).


    }

    // private void OnTriggerEnter(Collider other) {
    //     Debug.Log("Walls Trigerred");
    //     if (other.gameObject.CompareTag("Walls"))
    //     {
    //         Debug.Log("Walls");
    //         Color black = new Color(0.0f, 0.0f, 0.0f,1.0f);
    //         other.gameObject.GetComponent<Renderer>().material.color=black;
    //         Destroy(this.gameObject);
            
    //     }
    // }

    

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Walls"))
        {
            // Debug.Log("Walls");
            Color black = new Color(0.0f, 0.0f, 0.0f,1.0f);
            other.gameObject.GetComponent<Renderer>().material.color=black;
            Destroy(this.gameObject);
            
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Enemy");
            // Color black = new Color(0.0f, 0.0f, 0.0f,1.0f);
            Color newColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),1.0f);
            
            other.gameObject.GetComponent<Renderer>().material.color=newColor;
            Destroy(this.gameObject);
            //accessing other class
            // enemyTriggered.GetComponent<Enemy>().health-=damage;
            Enemy.health-=damage;
            Debug.Log(Enemy.health);
            
        }
            
        
    }
}
