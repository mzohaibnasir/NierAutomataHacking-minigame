using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Enemy : MonoBehaviour
{
    public static float enemyHealth;
    public TextMeshProUGUI enemyHealthText;
    public TextMeshProUGUI winingText;

    // Start is called before the first frame update
    void Start()
    {
        enemyHealth=100.0f;
    }

    // Update is called once per frame
    void Update()
    {
        enemyHealthText.text="Enemy:"+enemyHealth;
       if (enemyHealth<=0)
        {
            Destroy(this.gameObject);
            Debug.Log("Enemy destroyed");
            // win="You got served!"
            // is_alive=false;
            winingText.text="You WON";
        }
    }
}
