using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Practice_0605_2 : MonoBehaviour
{
    private string name = "��ȣ��";
    private int age = 2;
    private string hobby = "����";
    private int height = 186;
    private float weight = 123.4f;
    private string MBTI = "INFJ";
    private string favoriteFood = "�ܹ���";
    private string job = "������ ��ȹ��";
    private string Education = "�������б�";
    private string The_Big_3_record = "460";


    public TMP_Text infoText;

    // ���� �ε���
    private int currentIndex = 0;

    // ����� �� �پ��� ����
    private List<string> infoLines = new List<string>();

    void OnEnable()
    {
        InitInfoLines();
        infoText.text  = "";  
    }

    private void InitInfoLines()
    {
        infoLines.Clear();
        infoLines.Add("�ȳ��ϼ���. �� �̸��� " + name + "�Դϴ�.");
        infoLines.Add("�� ���̴� " + age + "�� �Դϴ�.");
        infoLines.Add("�� ��̴� " + hobby + "�Դϴ�.");
        infoLines.Add("�� Ű�� " + height + "cm �Դϴ�.");
        infoLines.Add("�� �����Դ� " + weight + "kg �Դϴ�.");
        infoLines.Add("�� MBTI�� " + MBTI + "�Դϴ�.");
        infoLines.Add("���� �����ϴ� ������ " + favoriteFood + "�Դϴ�.");
        infoLines.Add("���� ����ϴ� ������ " + job + "�Դϴ�.");
        infoLines.Add("�� ������ ������ " + Education + "�Դϴ�.");
        infoLines.Add("�� 3�� � ����� " + The_Big_3_record + "�Դϴ�.");
    }

    // ��ư Ŭ�� �� ȣ��
    public void PrintNextInfo()
    {
        if (currentIndex < infoLines.Count)
        {
            infoText.text = infoLines[currentIndex];
            currentIndex++;
        }
        else
        {
            infoText.text = "��� ������ ����߽��ϴ�!";
            currentIndex = 0;  // �ٽ� ó������ �ݺ��� ���� �ְ�, ���⼭ ���絵 �˴ϴ�.
        }
    }
}
