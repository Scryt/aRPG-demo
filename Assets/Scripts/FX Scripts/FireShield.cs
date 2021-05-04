using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireShield : MonoBehaviour
{
    private PlayerHealth playerHealth;


    void Awake()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void OnEnable()
    {
        playerHealth.Shielded = true;
    }

    void OnDisable()
    {
        playerHealth.Shielded = false;
    }
}