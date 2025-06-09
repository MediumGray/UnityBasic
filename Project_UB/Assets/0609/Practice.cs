using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GaChaScript : MonoBehaviour
{

 int count; // �̱� Ƚ�� ī��Ʈ
 public int selectNumber;
    private void Awake()
        {
        count = 0;
    }
    private List<string>[] Grade;
    private List<string> SSRCharacterList;
    private List<string> SRCharacterList;
    private List<string> RCharacterList;

    private void Start() // ����Ʈ �ʱ�ȭ
    {
      SSRCharacterList = new List<string>();
        SSRCharacterList.Add("�����ĵ�");
        SSRCharacterList.Add("ȫ��");
        SSRCharacterList.Add("����Ͼ�");
        SSRCharacterList.Add("ũ���");
        SSRCharacterList.Add("���̷�");

        SRCharacterList = new List<string>();
        SRCharacterList.Add("���η�");
        SRCharacterList.Add("ȫ����");
        SRCharacterList.Add("����");
        SRCharacterList.Add("���ö�");
        SRCharacterList.Add("Ʈ����ũ");

        RCharacterList = new List<string>();
        RCharacterList.Add("�Ϸ���");
        RCharacterList.Add("���Ƹ�");
        RCharacterList.Add("�극��");
        RCharacterList.Add("�Ľ�Į");
        RCharacterList.Add("�̻级");

        List<string>[] Grade= new List<string>[3];
        Grade[0] = SSRCharacterList;
        Grade[1] = SRCharacterList;
        Grade[2] = RCharacterList;
    }
    public void GachaSwitch() // �Ⱦ� �ý��� ����
    {
        switch (selectNumber)
        {
            case 0:
                Debug.Log("Ư�� �Ⱦ�!");
                break;
            case 1:
                Debug.Log("�Ϲ� �Ⱦ�!");
                break;
            default:
                Debug.Log("���� �Ⱦ�!");
                break;
        }
    }


public void Gacha1() // �̱� �ý��� 1(����)
    {
        int randomValue = Random.Range(1, 101); //1�̻�  100������ ������ ���� �޾� ���ڴ�.(1 ~ 100)
        Debug.Log($"������ ���� : {randomValue} �Դϴ�.");

        if (11 <= count)
        {
           int ssrIndex = Random.Range(0, SSRCharacterList.Count);
            Debug.Log($"SSR {SSRCharacterList[ssrIndex]}�� �̾Ҵ�!(õ���̴�!)");

            count = 0;
            return;
        }
    
        if (randomValue <= 10) //10%�� Ȯ�� 1~ 10 -> 10%
            {
            int ssrIndex = Random.Range(0, SSRCharacterList.Count);
            Debug.Log($"SSR {SSRCharacterList[ssrIndex]}�� �̾Ҵ�!");
            }
        else if (randomValue <= 50)//40%�� Ȯ�� 11~50 -> 40%
            {
            int srIndex = Random.Range(0, SSRCharacterList.Count);
            Debug.Log($"SR {SRCharacterList[srIndex]}�� �̾Ҵ�!");
        }
        else  //50%�� Ȯ�� 51~100 -> 50%                     
            {
            int rIndex = Random.Range(0, SSRCharacterList.Count);
            Debug.Log($"R {RCharacterList[rIndex]}�� �̾Ҵ�!");
        }
          
            
            count++;
    }
    public void Gacha10() // 0���� �̱� �ý���
    {
        Debug.Log("----- 10���� �̱� START -----");
        for (int i = 0; i < 10; i++)
        {
            Debug.Log($"--- {i + 1}��° ��� ---");
            Gacha1();
        }
    }

    public void Gacha2() // �̱� �ý��� 1(����)
    {
        int randomValue = Random.Range(1, 101); //1�̻�  100������ ������ ���� �޾� ���ڴ�.(1 ~ 100)
        Debug.Log($"������ ���� : {randomValue} �Դϴ�.");

        if (11 <= count)
        {
            int ssrIndex = Random.Range(0, SSRCharacterList.Count);
            Debug.Log($"SSR {SSRCharacterList[ssrIndex]}�� �̾Ҵ�!(õ���̴�!)");

            count = 0;
            return;
        }

        if (randomValue <= 5) //10%�� Ȯ�� 1~ 5 -> 5%
        {
            int ssrIndex = Random.Range(0, SSRCharacterList.Count);
            Debug.Log($"SSR {SSRCharacterList[ssrIndex]}�� �̾Ҵ�!");
        }
        else if (randomValue <= 50)//45%�� Ȯ�� 6~50 -> 45%
        {
            int srIndex = Random.Range(0, SSRCharacterList.Count);
            Debug.Log($"SR {SRCharacterList[srIndex]}�� �̾Ҵ�!");
        }
        else  //50%�� Ȯ�� 51~100 -> 50%                     
        {
            int rIndex = Random.Range(0, SSRCharacterList.Count);
            Debug.Log($"R {RCharacterList[rIndex]}�� �̾Ҵ�!");
        }


        count++;
    }
    public void Gacha10_2() // 0���� �̱� �ý���
    {
        Debug.Log("----- 10���� �̱� START -----");
        for (int i = 0; i < 10; i++)
        {
            Debug.Log($"--- {i + 1}��° ��� ---");
            Gacha2();
        }
    }

    public void Gacha3() // �̱� �ý��� 1(����)
    {
        int randomValue = Random.Range(1, 101); //1�̻�  100������ ������ ���� �޾� ���ڴ�.(1 ~ 100)
        Debug.Log($"������ ���� : {randomValue} �Դϴ�.");

      
        
        if (randomValue <= 40)//45%�� Ȯ�� 1~40 -> 40%
        {
            int srIndex = Random.Range(0, SSRCharacterList.Count);
            Debug.Log($"SR {SRCharacterList[srIndex]}�� �̾Ҵ�!");
        }
        else  //50%�� Ȯ�� 41~100 -> 60%                     
        {
            int rIndex = Random.Range(0, SSRCharacterList.Count);
            Debug.Log($"R {RCharacterList[rIndex]}�� �̾Ҵ�!");
        }


        count++;
    }
    public void Gacha10_3() // 0���� �̱� �ý���
    {
        Debug.Log("----- 10���� �̱� START -----");
        for (int i = 0; i < 10; i++)
        {
            Debug.Log($"--- {i + 1}��° ��� ---");
            Gacha3();
        }
    }
}
