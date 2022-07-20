using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Player : MonoBehaviour
{
    public static float playerHealth;
    public TextMeshProUGUI playerHealthText;
    public TextMeshProUGUI losingText;


    // public static bool is_alive;
    // Start is called before the first frame update
    void Start()
    {
        // losingText.SetActive(false);
        // losingText.enabled = false;
        // losingText.gameObject.GetComponent<Renderer>().enabled = false;

        playerHealth=100.0f;
        // is_alive=true;
    }

    // Update is called once per frame
    void Update()
    {
        playerHealthText.text="Player:"+ playerHealth;

        if (playerHealth<=0)
        {
            Destroy(this.gameObject);
            Debug.Log("Player destroyed");
            losingText.text= "You got served";
            // losingText.enabled = true;
                    // losingText.gameObject.GetComponent<Renderer>().enabled = true;


            // is_alive=false;
        }
    }
}
