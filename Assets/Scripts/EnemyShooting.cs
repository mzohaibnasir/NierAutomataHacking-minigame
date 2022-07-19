using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bulletSpawn;
    private Transform _bullet;
    private GameObject bulletObj;


    // public float fireRate;
    // Start is called before the first frame update
    void Start()
    {
                StartCoroutine(Enemyfire());

    //  InvokeRepeating("Fire",0f,1.0f);   //(fn,start time, difference)
    }

    // Update is called once per frame
    void Update()
    {
            //  InvokeRepeating("Fire",0f,1.0f);   //(fn,start time, difference)


        // while (Player.is_alive == true)
        // {
            // Invoke("Enemyfire",7.0f);

        // }

        // if (this.gameObject == null)
        // {
        //     StopCoroutine(Enemyfire());

        
    }

    IEnumerator Enemyfire(){
        // Debug.Log("Enumerator");
        while (this.gameObject)
        {
            // fire();
            Instantiate(bullet, bulletSpawn.transform.position, Quaternion.identity);

            // Instantiate(bullet, bulletSpawn.transform.position, Quaternion.identity);
            // Debug.Log("Condition");
            // yield return new waitForSeconds(5);
            yield return new WaitForSeconds(1);


        }

        yield return null;

    }

    // public void fire(){
        // _bullet= Instantiate(bullet.transform, bulletSpawn.transform.position, Quaternion.identity);
        // Instantiate(bullet, bulletSpawn.transform.position, Quaternion.identity);
        // bulletObj= Instantiate(bullet, bulletSpawn.transform.position, Quaternion.identity);
        // _bullet= bulletObj.transform;
        // _bullet.rotation = bulletSpawn.transform.rotation;//Transform

        
        //because everything is related to transform //(toMakeCopyOf, position, rotation)
    // }
}

