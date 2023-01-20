using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxHealth;
    public float maxThirst;
    public float maxHunger;

    public float thirstIncreaseRate;
    public float hungerIncreaseRate;

    private float health;
    private float thirst;
    private float hunger;

    public bool dead;

    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (!dead) {
            thirst += thirstIncreaseRate * Time.deltaTime;
            hunger += hungerIncreaseRate * Time.deltaTime;
        }

        if (thirst >= maxThirst) {
            Die(0);
        }
        if (hunger >= maxHunger) {
            Die(1);
        }
    }

    public void Die(int index) {
        dead = true;
        switch (index) {
            case 0:
            Debug.Log("you died from thirst");
                break;
            case 1:
            Debug.Log("you died from hunger");
                break;

        }
    }
}
