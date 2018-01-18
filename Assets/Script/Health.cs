using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public int startingHealth = 100;
    public int currentHealth;

    bool damaged;
    bool isDead;
	// Use this for initialization
	void Start () {
        currentHealth = startingHealth;
	}
	
	// Update is called once per frame
	void Update () {

        //If we took damage...
        if (damaged)
        {
            //here we should set a death notification
        }
        else
        {
            //transition back to no damage
        }

        //reset the damaged flag
        damaged = false;
	}

    public void TakeDamage (int amount)
    {
        //use this to set a flash/damage animation in our damaged method
        damaged = true;
      
        // reduce player health by damage amount.
        currentHealth -= amount;
        
        //check if we are dead.
        if(currentHealth <= 0 && !isDead)
        {
            //our method deciding how we die yay
            Death();
        }
    }

    //turn off all our shit
    void Death()
    {
        isDead = true;
    }
}
