using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatUpDown : MonoBehaviour
{
    /* float upMax = 0.2f; //�·� �̵������� (x)�ִ밪
     float downMax = -0.2f; //��� �̵������� (x)�ִ밪
     float currentPosition; //���� ��ġ(x) ����
     float direction = 0.6f; //�̵��ӵ�+����

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

         //���� ��ġ(x)�� ��� �̵������� (x)�ִ밪���� ũ�ų� ���ٸ�
         //�̵��ӵ�+���⿡ -1�� ���� ������ ���ְ� ������ġ�� ��� �̵������� (x)�ִ밪���� ����

         else if (currentPosition <= downMax)
         {
             direction *= -1;
             currentPosition = downMax;
         }
         //���� ��ġ(x)�� �·� �̵������� (x)�ִ밪���� ũ�ų� ���ٸ�
         //�̵��ӵ�+���⿡ -1�� ���� ������ ���ְ� ������ġ�� �·� �̵������� (x)�ִ밪���� ����
         transform.Translate(new Vector3(transform.position.x, currentPosition, transform.position.z) * Time.deltaTime);
         //"Stone"�� ��ġ�� ���� ������ġ�� ó��
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
