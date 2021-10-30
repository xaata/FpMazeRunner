using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    [SerializeField]
    protected float enemyHP = 20;
    protected float enemyDamage = 50;
    protected float enemySpeed = 5;

    public virtual void TakeDamage(float damage)
    {
        Debug.Log("player->enemy");
        //enemyHP -= damage;
        //Destroy(gameObject);
        //LifeCheck();
    }
    protected void LifeCheck()
    {
        if (enemyHP <= 0)
            Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            player.GetComponent<Player>().TakeDamage(enemyDamage);
        }
    }
}
