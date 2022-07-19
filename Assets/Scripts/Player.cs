using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static float health;
    public static bool is_alive;
    // Start is called before the first frame update
    void Start()
    {
        health=100.0f;
        is_alive=true;
    }

    // Update is called once per frame
    void Update()
    {
        if (health<=0)
        {
            Destroy(this.gameObject);
            is_alive=false;
        }
    }
}
