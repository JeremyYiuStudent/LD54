using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataHolder
{
    public static int health {set;get;} = 100;
    public static int energy {set;get;} = 100;
    public static int numMana {get;set;} = 0;
    public static void reduceHealth(int x){
        health -= x;
        if(health <= 0){
            Cursor.visible = true; 
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene ("GameOver");
        }
    }
    public static void increaseHealth(){
        if(health < 100){health+=1;}
    }
    public static void gainEnergy(){
        energy += 10;
        if(energy > 200){energy = 200;}
        numMana--;
    }
    public static void addMana(){
        numMana++;
    }
}
