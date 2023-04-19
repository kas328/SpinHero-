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
    #region 효과음 재생
    // _name이 넘어오면 Sound의 name과 일치하는지 확인 후 일치하면 Sound의 AudioClip을 AudioSource에 넣어서 재생
    public void PlaySoundEffect(string _name)
    {
        for (int i = 0; i < soundEffects.Length; i++)
        {
            if(_name == soundEffects[i].name)
            {
                for (int j = 0; j < audioSourceSoundEffects.Length; j++) // 재생중이지 않은 AudioSource 찾기
                {
                    if(!audioSourceSoundEffects[j].isPlaying)
                    {
                        playSoundName[j] = soundEffects[i].name; // 재생중인 audioSource와 이름 일치화
                        audioSourceSoundEffects[j].clip = soundEffects[i].audioClip;
                        audioSourceSoundEffects[j].Play();
                        return;
                    }
                }
                Debug.Log("모든 AudioSource가 사용중입니다.");
                return;
            }
        }
        Debug.Log(_name + "사운드가 SoundManager에 등록되지 않았습니다.");
    }
    #endregion
    #region 효과음 전부 멈추기
    public void StopAllSoundEffect()
    {
        for (int i = 0; i < audioSourceSoundEffects.Length; i++)
        {
            audioSourceSoundEffects[i].Stop();
        }
    }
    #endregion
    #region 효과음 멈추기
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
        Debug.Log("재생 중인" + _name + "사운드가 없습니다.");
    }
    #endregion
}
