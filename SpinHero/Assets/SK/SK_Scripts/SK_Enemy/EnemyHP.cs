using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using JHS;

public class EnemyHP : HPFrame
{
    GameObject scoreManagerObj;
    ScoreManager scoreManager;
    //public Text hpText;
    [SerializeField] int score;
    [SerializeField] GameObject dieEffect;

    private void Awake()
    {
        scoreManagerObj = GameObject.Find("ScoreManager");
        scoreManager = scoreManagerObj.GetComponent<ScoreManager>();
    }

    private void Update()
    {
        //hpText.rectTransform.rotation = Quaternion.Euler(0, 0, 0); // �̵� �� ü�� ���� ȸ�� ����
    }
    protected override void OnTakeDamage(float delta)
    {
        // �ִϸ��̼�, �ǰ�ȿ�� ��
    }
    protected override void RefreshUIElement()
    {
        //hpText.text = CurrentHP.ToString();
    }
    protected override void OnDeath()
    {
        GameObject _dieEffect = Instantiate(dieEffect);
        _dieEffect.transform.position = transform.position;
        _dieEffect.transform.rotation = transform.rotation;
        scoreManager.Score += score;
        Destroy(gameObject);
    }
}
