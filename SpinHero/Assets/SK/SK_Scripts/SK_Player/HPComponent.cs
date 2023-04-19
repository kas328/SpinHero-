using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using JHS;
using UnityEngine.SceneManagement;

public class HPComponent : HPFrame
{
    public Text hpText;
    int invincibleTime = 1;
    [SerializeField] Collider2D[] weaponColliders;
    [SerializeField] string playerDieSound;

    private void Update()
    {
        hpText.rectTransform.rotation = Quaternion.Euler(0, 0, 0); // 이동 시 체력 숫자 회전 방지
    }
    protected override void OnTakeDamage(float delta)
    {
        isInvincible = true;
        foreach (var weaponCollider in weaponColliders)
        {
            weaponCollider.enabled = false;
        }
        StartCoroutine(Co_Invincible());
    }
    protected override void RefreshUIElement()
    {
        hpText.text = CurrentHP.ToString();
    }
    protected override void OnDeath()
    {
        SoundManager.instance.PlaySoundEffect(playerDieSound);
        SceneManager.LoadScene("SK_GameOverScene");
    }

    IEnumerator Co_Invincible()
    {
        yield return new WaitForSeconds(invincibleTime);
        isInvincible = false;
        foreach (var weaponCollider in weaponColliders)
        {
            weaponCollider.enabled = true;
        }
    }

    protected override void OnSpawn()
    {
        isInvincible = false;
    }
}
