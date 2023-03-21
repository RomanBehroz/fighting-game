using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Attack : MonoBehaviour
{
    private float timeBtwAttack;
    private float startTimeBtwAttack;

    public Transform attackPos;
    public LayerMask whatIsEnemies;
    public float attackRangeLight = 2f;
    public float attackRangeHeavy = 2.4f;
    public int lightDamage = 10;
    public int heavyDamage = 20;

    // Update is called once per frame
    void Update()
    {
        if (timeBtwAttack <= 0)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0)) 
            {
                // Light attack
                Collider2D[] enemyToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRangeLight, whatIsEnemies);
                for (int i = 0; i < enemyToDamage.Length; i++)
                {
                    enemyToDamage[i].GetComponent<SwordNinja>().TakeDamage(lightDamage);
                }
            }
            else if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                // Heavy attack
                Collider2D[] enemyToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRangeHeavy, whatIsEnemies);
                for (int i = 0; i < enemyToDamage.Length; i++)
                {
                    enemyToDamage[i].GetComponent<SwordNinja>().TakeDamage(heavyDamage);
                }
            }
            else
            {
                timeBtwAttack -= Time.deltaTime;
            }
            timeBtwAttack = startTimeBtwAttack;
        }
        else
        {
            timeBtwAttack -= Time.deltaTime;
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRangeLight);
        Gizmos.DrawWireSphere(attackPos.position, attackRangeHeavy);
    }
}
