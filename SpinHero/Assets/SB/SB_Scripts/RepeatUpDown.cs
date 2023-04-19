using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatUpDown : MonoBehaviour
{
    /* float upMax = 0.2f; //좌로 이동가능한 (x)최대값
     float downMax = -0.2f; //우로 이동가능한 (x)최대값
     float currentPosition; //현재 위치(x) 저장
     float direction = 0.6f; //이동속도+방향

     void Start()
     {
         currentPosition = transform.position.y;
     }

     void Update()
     {
         currentPosition += Time.deltaTime * direction;

         if (currentPosition >= upMax)
         {
             direction *= -1;
             currentPosition = upMax;
         }

         //현재 위치(x)가 우로 이동가능한 (x)최대값보다 크거나 같다면
         //이동속도+방향에 -1을 곱해 반전을 해주고 현재위치를 우로 이동가능한 (x)최대값으로 설정

         else if (currentPosition <= downMax)
         {
             direction *= -1;
             currentPosition = downMax;
         }
         //현재 위치(x)가 좌로 이동가능한 (x)최대값보다 크거나 같다면
         //이동속도+방향에 -1을 곱해 반전을 해주고 현재위치를 좌로 이동가능한 (x)최대값으로 설정
         transform.Translate(new Vector3(transform.position.x, currentPosition, transform.position.z) * Time.deltaTime);
         //"Stone"의 위치를 계산된 현재위치로 처리
     }*/
    int a = 1;
    void Update()
    {
        if (transform.position.y < -0.2f)
        {
            a = 1;
        }
        else if (transform.position.y > 0.2f)
        {
            a = -1;
        }

        transform.Translate(Vector3.up * 1.0f * Time.deltaTime * a);
    }
}
