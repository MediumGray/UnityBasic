using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    
    int count; // �̱� Ƚ�� ī��Ʈ

    private void Awake()
    {
        count = 0;
    }
    void Start()
    {
    }
    // Start is called before the first frame update

    public void Gacha()
    {
        // Ȯ���� 10%�� �α׿� '�����ĵ�'�� �̾Ҵ�!
        //Ȯ���� 20%�� �α׿� '����Ͼ�'�� �̾Ҵ�!
        //������ 70% Ȯ���� ''���η�'�� �̾Ҵ�!


        int randomValue = Random.Range(1, 101); //1�̻�  100������ ������ ���� �޾� ���ڴ�.(1 ~ 100)
        Debug.Log($"������ ���� : {randomValue} �Դϴ�.");
        if (8 <= count)
        {
            Debug.Log("�����ĵ带 �̾Ҵ�!");
            count = 0;
            return;
        }

        if (randomValue <= 3) //10%�� Ȯ�� 1~ 3 -> 3%
           {
                Debug.Log("�����ĵ带 �̾Ҵ�!");
            }
        else if(randomValue <= 12)//20%�� Ȯ�� 3~12 -> 10%
        {
                Debug.Log("����ϾƸ� �̾Ҵ�!");
            }
        else if (randomValue <= 32)//20%�� Ȯ�� 12~32 -> 20%                     
        {
                Debug.Log("ȫ���̸� �̾Ҵ�!");
        }
        else
        {
            Debug.Log("���ηո� �̾ƹ��ȴ�!");

        }
        count++;
    }
    public void Gacha10()
    {
        Debug.Log("----- 10���� �̱� START -----");
        for (int i = 0; i < 10; i++)
        {
            Debug.Log($"--- {i + 1}��° ��� ---");
            Gacha();
        }
    }

    public void GachaW()
    {
        int number = 0;
        int randomValue = Random.Range(1, 101); //1�̻�  100������ ������ ���� �޾� ���ڴ�.(1 ~ 100)
        Debug.Log($"������ ���� : {randomValue} �Դϴ�.");
        

        while (number < 10)
        {
            Debug.Log($"--- {number + 1}��° ��� ---");
            Gacha();
            number++;
        }
    }
    public int selectNumber;
    public void GachaSwitch()
    {

        // ����ġ ������ �ٲٱ�
        int randomValue = Random.Range(1, 101); //1�̻�  100������ ������ ���� �޾� ���ڴ�.(1 ~ 100)
        Debug.Log($"������ ���� : {randomValue} �Դϴ�.");
        
        
        switch (selectNumber)
        {
            case 0:
                Debug.Log("�����ĵ� �Ⱦ�!");
                {
                    if (randomValue <= 3) //10%�� Ȯ�� 1~ 3 -> 3%
                    {
                        Debug.Log("�����ĵ带 �̾Ҵ�!");
                    }
                    else if (randomValue <= 12)//20%�� Ȯ�� 3~12 -> 10%
                    {
                        Debug.Log("����ϾƸ� �̾Ҵ�!");
                    }
                    else if (randomValue <= 32)//20%�� Ȯ�� 12~32 -> 20%                     
                    {
                        Debug.Log("ȫ���̸� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("���ηո� �̾ƹ��ȴ�!");

                    }
                }
                break;
            case 1:
                Debug.Log("������ �Ⱦ�!");
                {
                    if (randomValue <= 3) //10%�� Ȯ�� 1~ 3 -> 3%
                    {
                        Debug.Log("�������� �̾Ҵ�!");
                    }
                    else if (randomValue <= 12)//20%�� Ȯ�� 3~12 -> 10%
                    {
                        Debug.Log("���Ƹ��� �̾Ҵ�!");
                    }
                    else if (randomValue <= 32)//20%�� Ȯ�� 12~32 -> 20%                     
                    {
                        Debug.Log("�ƴϽ��� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("���ηո� �̾ƹ��ȴ�!");
                    }
                }
                break;
            case 2:
                Debug.Log("ȫ�� �Ⱦ�!");
                {
                    if (randomValue <= 3) //10%�� Ȯ�� 1~ 3 -> 3%
                    {
                        Debug.Log("ȫ���� �̾Ҵ�!");
                    }
                    else if (randomValue <= 12)//20%�� Ȯ�� 3~12 -> 10%
                    {
                        Debug.Log("����� �̾Ҵ�!");
                    }
                    else if (randomValue <= 32)//20%�� Ȯ�� 12~32 -> 20%                     
                    {
                        Debug.Log("����� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("���ηո� �̾ƹ��ȴ�!");
                    }
                }
                break;
            default:
                Debug.Log("��� ���η�!");
                {
                    if (randomValue <= 3) //10%�� Ȯ�� 1~ 3 -> 3%
                    {
                        Debug.Log("���η�1�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 12)//20%�� Ȯ�� 3~12 -> 10%
                    {
                        Debug.Log("���η�2�� �̾Ҵ�!");
                    }
                    else if (randomValue <= 32)//20%�� Ȯ�� 12~32 -> 20%                     
                    {
                        Debug.Log("���η�3�� �̾Ҵ�!");
                    }
                    else
                    {
                        Debug.Log("���η�4�� �̾ƹ��ȴ�!");
                    }
                }
                break;
        }
    }

}


