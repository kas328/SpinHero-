using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPower : MonoBehaviour
{
    [SerializeField] int attackPower;
    [SerializeField] string attackSound;

    private void Awake()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Contains("Enemy"))
        {
            collision.GetComponent<EnemyHP>().CurrentHP -= attackPower;
            SoundManager.instance.PlaySoundEffect(attackSound);
        }

        if (collision.tag.Contains("Projectile"))
        {
            SoundManager.instance.PlaySoundEffect(attackSound);
        }
    }
}
