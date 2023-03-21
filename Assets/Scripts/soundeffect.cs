using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundeffect : MonoBehaviour
{
    public AudioSource lighattack;
    public AudioSource strike;
    public AudioSource jumpattack;
    public AudioSource hit;
    public AudioSource jump;

    void LightAttackSound()
    {
        lighattack.Play();
    }

    void StrikeSound()
    {
        strike.Play();
    }

    void JumpAttackSound()
    {
        jumpattack.Play();
    }

    void HitSound()
    {
        hit.Play();
    }

    void JumpSound()
    {
        jump.Play();
    }

}
