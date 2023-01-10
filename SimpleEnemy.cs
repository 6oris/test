using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleEnemy : MonoBehaviour
{
    // Speed movement enemy
    public float speed;
    // target to enemy
    public Transform target;
    //Point attack from enemy
    public int playerDamage = 2;

    void Update(){
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        transform.LookAt(target.position);
        // Attack
    }
    private void OnTriggerEnter(Collider other) {
        Player player = other.GetComponent<Player>();

        player.GetDamage(playerDamage);
        transform.position += Vector3.forward * 4;
    }
}   
