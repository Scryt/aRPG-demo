using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public float health = 100f;

    public Image health_Img;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float amount)
    {
        health -= amount;

        health_Img.fillAmount = health / 100f;
        
        print("Enemy took damage, health is " + health);
        
        if (health <= 0)
        {
            
        }
    }
}
