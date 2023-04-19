using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    #region Singleton
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    #endregion
    #region Field
    [SerializeField] AudioSource[] audioSourceSoundEffects;
    [SerializeField] AudioSource audioSourceBgm;

    [SerializeField] Sound[] soundEffects;
    [SerializeField] Sound[] bgms;

    [SerializeField] string[] playSoundName;
    #endregion
    #region ȿ���� ���
    // _name�� �Ѿ���� Sound�� name�� ��ġ�ϴ��� Ȯ�� �� ��ġ�ϸ� Sound�� AudioClip�� AudioSource�� �־ ���
    public void PlaySoundEffect(string _name)
    {
        for (int i = 0; i < soundEffects.Length; i++)
        {
            if(_name == soundEffects[i].name)
            {
                for (int j = 0; j < audioSourceSoundEffects.Length; j++) // ��������� ���� AudioSource ã��
                {
                    if(!audioSourceSoundEffects[j].isPlaying)
                    {
                        playSoundName[j] = soundEffects[i].name; // ������� audioSource�� �̸� ��ġȭ
                        audioSourceSoundEffects[j].clip = soundEffects[i].audioClip;
                        audioSourceSoundEffects[j].Play();
                        return;
                    }
                }
                Debug.Log("��� AudioSource�� ������Դϴ�.");
                return;
            }
        }
        Debug.Log(_name + "���尡 SoundManager�� ��ϵ��� �ʾҽ��ϴ�.");
    }
    #endregion
    #region ȿ���� ���� ���߱�
    public void StopAllSoundEffect()
    {
        for (int i = 0; i < audioSourceSoundEffects.Length; i++)
        {
            audioSourceSoundEffects[i].Stop();
        }
    }
    #endregion
    #region ȿ���� ���߱�
    public void StopSoundEffect(string _name)
    {
        for (int i = 0; i < audioSourceSoundEffects.Length; i++)
        {
            if(playSoundName[i] == _name)
            {
                audioSourceSoundEffects[i].Stop();
                return;
            }
        }
        Debug.Log("��� ����" + _name + "���尡 �����ϴ�.");
    }
    #endregion
}
