using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy;

    [SerializeField]
    private float playerHP = 100;
    private float playerUnarmedDamage = 10;
    private float playerSpeed = 10;
    private float armorRatio = 1;
    private float playerDamage = 10;

    public float PlayerSpeed { get => playerSpeed; set => playerSpeed = value; }
    public float PlayerHP { get => playerHP; set => playerHP = value; }

    public void TakeDamage(float damage)
    {
        Debug.Log("enemy->Player");
        //playerHP -= damage * armorRatio;
        //Destroy(gameObject);
        //LifeCheck();
    }
    private void LifeCheck()
    {
        if (playerHP <= 0)
            Destroy(gameObject);
    }
    //private void OnCollisionEnter(Collision other)
    //{
    //    if (other.collider.tag == "Type1")
    //    {
    //        enemy.GetComponent<Enemy>().TakeDamage(playerDamage);
    //    }
    //}

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody rigidbody = hit.collider.attachedRigidbody;

        if (hit.collider.attachedRigidbody.tag == "Enenmy")
        {
            enemy.GetComponent<Enemy>().TakeDamage(playerDamage);
        }
    }
}
