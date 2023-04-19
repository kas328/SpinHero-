using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Boom : MonoBehaviour
{
    Collider2D[] colliders;
    [SerializeField] float boomRange;
    [SerializeField] int damage;
    [SerializeField] float power;

    public void DoBoom()
    {
        colliders = Physics2D.OverlapCircleAll(transform.position, boomRange);
        Vector2 dir = (PlayerManager.Instance.Player.position - transform.position).normalized;

        foreach (Collider2D collider in colliders)
        {
            if(collider.tag.Contains("Player"))
            {
                collider.transform.DOMove(dir * power, 0.2f).SetEase(Ease.InSine, 50, 1);
                collider.GetComponent<HPComponent>().CurrentHP -= damage;
            }
        }
    }
}
