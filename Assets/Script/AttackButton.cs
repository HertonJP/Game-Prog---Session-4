using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackButton : MonoBehaviour
{
    public Animator anim;
    void Update()
    {
        
        
    }
    public void Attack()
    {
        anim.SetTrigger("isAttack");
    }
}
