using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice_0605 : MonoBehaviour
{
    private string name = "��ȣ��";
    private int age = 28;
    private string hobby = "����";
    private int height = 186;
    private float weight = 123.4f;
    private string MBTI = "INFJ";
    private string favoriteFood = "�ܹ���";
    private string job = "������ ��ȹ��";
    private string Education = "�������б�";
    private string The_Big_3_record = "460";


    void Start()
    {
        SelfIntroductuion();
        
    }

    public void SelfIntroductuion()
    {
        Debug.Log("�ȳ��ϼ���. �� �̸��� " + name + "�Դϴ�.");
        Debug.Log("�� ���̴� " + age + "�� �Դϴ�.");
        Debug.Log("�� ��̴� " + hobby + "�Դϴ�.");
        Debug.Log("�� Ű�� " + height + "cm �Դϴ�.");
        Debug.Log("�� �����Դ� " + weight + "kg �Դϴ�.");
        Debug.Log("�� MBTI�� " + MBTI + "�Դϴ�.");
        Debug.Log("���� �����ϴ� ������ " + favoriteFood + "�Դϴ�.");
        Debug.Log("���� ����ϴ� ������ " + job + "�Դϴ�.");
        Debug.Log("�� ������ ������ " + Education + "�Դϴ�.");
        Debug.Log("�� 3�� � ����� " + The_Big_3_record + "�Դϴ�.");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
