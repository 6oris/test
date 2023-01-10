using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Health
    private int Health = 10;

    // Damage
    public void GetDamage(int damage){
        Health -= damage;
        print("Health player: " + Health);
    }
}
