using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class AttackButton : MonoBehaviour
{
    public Animator anim;
    public GameObject rawImageVideo;

    public void Attack()
    {
        anim.SetTrigger("isAttack");
    }

    public void invokeVideo()
    {
        Invoke("playVideo", 2.0f);
    }
    public void playVideo()
    {
        rawImageVideo.SetActive(true);
    }
}
