using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendDamage : MonoBehaviour
{
    [SerializeField] int damage;
    [SerializeField] string attackSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag.Contains("Player"))
        {
            PlayerManager.Instance.Player.GetComponent<HPComponent>().CurrentHP -= damage;
            SoundManager.instance.PlaySoundEffect(attackSound);
            print(damage);
            gameObject.SetActive(false);
        }
    }
}
