﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player!=null)
        {
                    transform.LookAt(player.transform);

        }
    }
}
