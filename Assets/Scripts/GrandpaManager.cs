using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrandpaManager : MonoBehaviour
{

    [SerializeField] private AudioSource backgroundMusicSource;
    
    private Animator animator;
    private String currPlay;
    
    public bool grandpaInfusedWithPiss, dead;
    public int grandpaHealth;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        currPlay = "breathe no pee";
        grandpaHealth = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (grandpaHealth == 0 && !grandpaInfusedWithPiss)
        {
            dead = true;
            GrandpaIsFuckingDead();
        }
        else if (grandpaHealth == 0 && grandpaInfusedWithPiss)
        {
            dead = true;
            GrandpaIsFuckingDeadAndPissInfused();
        }
    }

    public void InfuseWithPiss()
    {
        animator.SetTrigger("aliveAndPissInfused");
        grandpaInfusedWithPiss = true;
        currPlay = "breathe pee";
        return;
    }
    public void GrandpaIsFuckingDead()
    {
        animator.SetTrigger("deadNoPee");
        dead = true;
        currPlay = "still no pee";
        backgroundMusicSource.enabled = false;
        return;
    }
    public void GrandpaIsFuckingDeadAndPissInfused()
    {
        animator.SetTrigger("deadAndPissInfused");
        grandpaInfusedWithPiss = true;
        dead = true;
        currPlay = "still pee";
        backgroundMusicSource.enabled = false;
        return;
    }
}