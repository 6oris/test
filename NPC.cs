using System.Collections;
using UnityEngine;

public class NPC : MonoBehaviour
{
    // Здоровье
    public int hp = 5;
    //Уровень
    public int lvl = 2;
    //Скорость
    public float speed = 0.5f;
    //Обьект
    public GameObject npc;
    // вектор
    private Vector3 a;
    void Start()
    {
        a = npc.transform.position;
    }

    async void Update()
    {
        if(Input.GetKey ("w")) {
            a.z += speed * Time.deltaTime;
            npc.transform.position = a;
        }
        if(Input.GetKey ("s")) {
            a.z -= speed * Time.deltaTime;
            npc.transform.position = a;
        }
    }
}
