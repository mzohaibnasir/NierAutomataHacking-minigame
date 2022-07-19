using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletMovement : MonoBehaviour
{
    // public float aliveTime;
    // public float damage;

    public float moveSpeed;
    // public GameObject _bulletSpawn;
    // [SerializeField]
    public GameObject playerTriggered;
    private Rigidbody playerRigidbody;


    // Start is called before the first frame update
    void Start()
    {
        // aliveTime = 5.0f;
        // damage=10.0f;
        moveSpeed=30.0f;
        // this.transform.rotation=_bulletSpawn.transform.rotation;
        playerRigidbody=playerTriggered.GetComponent<Rigidbody>();
        //  this.transform.LookAt(playerRigidbody.transform.position);


        
    }

    // Update is called once per frame
    void Update()
    {
        // this.transform.Translate (0, moveSpeed, 0, Space.Self);
        // playerRigidbody.AddForce(transform.forward*50.0f);
        // playerRigidbody.AddForce(transform.forward*50.0f, ForceMode.Impulse);

        // playerRigidbody.velocity= playerTriggered.gameObject.transform.position*20.0f;
        // playerRigidbody.MovePosition(transform.position *Time.deltaTime );
        // Debug.Log("BulletMovement");
        // transform.LookAt(playerObj.transform.position); //direction
        // aliveTime -= 1*Time.deltaTime;
        // if (aliveTime<=0)
        // {
        //     Destroy(this.gameObject);
        // }
                // this.gameObject.GetComponent<Rigidbody>().AddForce(0.0f,0.0f,19.0f);

        transform.LookAt(playerTriggered.transform);
        // Debug.Log("BulletMovement"+ position);
        this.transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
        // Debug.Log("Current position:"+playerTriggered.gameObject.transform.position);   
        // this.transform.Translate(playerTriggered.gameObject.transform.position * Time.deltaTime *moveSpeed);
        //  this.transform.Translate(transform.forward * Time.deltaTime *moveSpeed);
        

        // this.transform.position
        // this.GetComponent<Rigidbody>().AddForce(playerTriggered.gameObject.transform.position);
        // this.transform.Translate(Vector3.forward * Time.deltaTime *moveSpeed);

        // this.transform.Translate(playerTriggered.transform.position * Time.deltaTime *moveSpeed);

        
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

    

    // private void OnCollisionEnter(Collision other) {
        // if (other.gameObject.CompareTag("Walls"))
        // {
        //     // Debug.Log("Walls");
        //     Color black = new Color(0.0f, 0.0f, 0.0f,1.0f);
        //     other.gameObject.GetComponent<Renderer>().material.color=black;
        //     Destroy(this.gameObject);
            
        // }

        // if (other.gameObject.CompareTag("Enemy"))
        // {
        //     Debug.Log("Enemy");
        //     // Color black = new Color(0.0f, 0.0f, 0.0f,1.0f);
        //     Color newColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),1.0f);
            
        //     other.gameObject.GetComponent<Renderer>().material.color=newColor;
        //     Destroy(this.gameObject);
        //     //accessing other class
        //     // enemyTriggered.GetComponent<Enemy>().health-=damage;
        //     Enemy.health-=damage;
        //     Debug.Log(Enemy.health);
            
        // }
            
        
    // }
}
