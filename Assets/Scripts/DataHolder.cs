using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataHolder
{
    public static int health {set;get;} = 100;
    public static int energy {set;get;} = 50;
    public static int numMana {get;set;} = 0;
    public static void reduceHealth(int x){
        health -= x;
        Debug.Log("Health currently at: " + health);
    }
    public static void increaseHealth(){
        if(health < 100){health++;}
        Debug.Log("Health currently at: " + health);
    }
    public static void gainEnergy(){
        energy += 10;
        if(energy > 200){energy = 200;}
        numMana--;
        Debug.Log("Energy currently at: " + energy);
    }
    public static void addMana(){
        numMana++;
        Debug.Log("Plopped down another mana.");
    }
}
