﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour {

    public float enemyMaxHealth;
    float currentHealth;


	// Use this for initialization
	void Start () {
        currentHealth = enemyMaxHealth;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void addDamage(float damage)
    {
        currentHealth -= damage;
        if(currentHealth == 0)
        {
            enemyDies();
        }
    }

    void enemyDies()
    {

        Destroy(gameObject);


    }
}