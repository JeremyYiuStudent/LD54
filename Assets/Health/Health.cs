using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Image FillImage;
    public float CurrentHealth;
    public float MaxHealth;
    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = 100;
        MaxHealth = 100;
    }

    // Update is called once per frame
    void Update()
    {
        FillImage.fillAmount = CurrentHealth/100;
    }

     public void ReduceHP(int x)
    {
        FillImage.fillAmount = (CurrentHealth - x) / 100;
    }

}
