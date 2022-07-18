using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bulletSpawn;
    private Transform _bullet;
    private GameObject bulletObj;


    public float fireRate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnFire()
    {
        fire();
    }

    public void fire(){
        // _bullet= Instantiate(bullet.transform, bulletSpawn.transform.position, Quaternion.identity);
        bulletObj= Instantiate(bullet, bulletSpawn.transform.position, Quaternion.identity);
        _bullet= bulletObj.transform;
        _bullet.rotation = bulletSpawn.transform.rotation;//Transform

        
        //because everything is related to transform //(toMakeCopyOf, position, rotation)
    }
}
