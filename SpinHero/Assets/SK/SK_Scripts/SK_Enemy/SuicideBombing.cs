using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuicideBombing : MonoBehaviour
{
    MoveToTarget moveToTarget;
    int boomCount;
    [SerializeField] GameObject boomObject;

    [SerializeField] float boomTimer;
    [SerializeField] string boomSound;
    [SerializeField] GameObject boomEffect;
    private void Awake()
    {
        moveToTarget = GetComponent<MoveToTarget>();
    }

    void Update()
    {
        BoomMaker();
        BoomTransform();
    }

    void BoomMaker()
    {
        if (Vector3.Distance(transform.position, PlayerManager.Instance.Player.position) <= moveToTarget.attackRange && boomCount < 1)
        {
            boomCount++;
            Instantiate(boomObject);
            Invoke("UseBoom", boomTimer);
            gameObject.SetActive(false);
        }
    }
    void UseBoom()
    {
        SoundManager.instance.PlaySoundEffect(boomSound);
        boomObject.GetComponent<Boom>().DoBoom();
        BoomEffect();
        Destroy(gameObject);
    }
    void BoomTransform()
    {
        boomObject.transform.position = transform.position;
    }

    void BoomEffect()
    {
        GameObject _boomEffect = Instantiate(boomEffect);
        _boomEffect.transform.position = transform.position;
        _boomEffect.transform.rotation = transform.rotation;
    }
}
