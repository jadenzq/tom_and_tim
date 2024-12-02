using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject[] hearts;
    private int life;
    private bool dead;
    public static Health instance;
    void Start(){
        life = hearts.Length;
        instance = this;
    }
    void Update(){
        if(dead == true){

        }
    }

    public void TakeDamage(int d){
        life -= d;
        Destroy(hearts[life].gameObject);
        if(life < 1){
            dead = true;
        }
    }
}
