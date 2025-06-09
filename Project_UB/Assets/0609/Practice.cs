using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GaChaScript : MonoBehaviour
{

 int count; // 뽑기 횟수 카운트
 public int selectNumber;
    private void Awake()
        {
        count = 0;
    }
    private List<string>[] Grade;
    private List<string> SSRCharacterList;
    private List<string> SRCharacterList;
    private List<string> RCharacterList;

    private void Start() // 리스트 초기화
    {
      SSRCharacterList = new List<string>();
        SSRCharacterList.Add("레드후드");
        SSRCharacterList.Add("홍련");
        SSRCharacterList.Add("모더니아");
        SSRCharacterList.Add("크라운");
        SSRCharacterList.Add("세이렌");

        SRCharacterList = new List<string>();
        SRCharacterList.Add("도로롱");
        SRCharacterList.Add("홍북이");
        SRCharacterList.Add("라피");
        SRCharacterList.Add("라플라스");
        SRCharacterList.Add("트레이크");

        RCharacterList = new List<string>();
        RCharacterList.Add("일레그");
        RCharacterList.Add("누아르");
        RCharacterList.Add("브레드");
        RCharacterList.Add("파스칼");
        RCharacterList.Add("이사벨");

        List<string>[] Grade= new List<string>[3];
        Grade[0] = SSRCharacterList;
        Grade[1] = SRCharacterList;
        Grade[2] = RCharacterList;
    }
    public void GachaSwitch() // 픽업 시스템 선택
    {
        switch (selectNumber)
        {
            case 0:
                Debug.Log("특수 픽업!");
                break;
            case 1:
                Debug.Log("일반 픽업!");
                break;
            default:
                Debug.Log("무료 픽업!");
                break;
        }
    }


public void Gacha1() // 뽑기 시스템 1(단차)
    {
        int randomValue = Random.Range(1, 101); //1이상  100이하의 랜덤한 값을 받아 오겠다.(1 ~ 100)
        Debug.Log($"랜덤한 값은 : {randomValue} 입니다.");

        if (11 <= count)
        {
           int ssrIndex = Random.Range(0, SSRCharacterList.Count);
            Debug.Log($"SSR {SSRCharacterList[ssrIndex]}를 뽑았다!(천장이다!)");

            count = 0;
            return;
        }
    
        if (randomValue <= 10) //10%의 확률 1~ 10 -> 10%
            {
            int ssrIndex = Random.Range(0, SSRCharacterList.Count);
            Debug.Log($"SSR {SSRCharacterList[ssrIndex]}를 뽑았다!");
            }
        else if (randomValue <= 50)//40%의 확률 11~50 -> 40%
            {
            int srIndex = Random.Range(0, SSRCharacterList.Count);
            Debug.Log($"SR {SRCharacterList[srIndex]}를 뽑았다!");
        }
        else  //50%의 확률 51~100 -> 50%                     
            {
            int rIndex = Random.Range(0, SSRCharacterList.Count);
            Debug.Log($"R {RCharacterList[rIndex]}를 뽑았다!");
        }
          
            
            count++;
    }
    public void Gacha10() // 0연속 뽑기 시스템
    {
        Debug.Log("----- 10연속 뽑기 START -----");
        for (int i = 0; i < 10; i++)
        {
            Debug.Log($"--- {i + 1}번째 결과 ---");
            Gacha1();
        }
    }

    public void Gacha2() // 뽑기 시스템 1(단차)
    {
        int randomValue = Random.Range(1, 101); //1이상  100이하의 랜덤한 값을 받아 오겠다.(1 ~ 100)
        Debug.Log($"랜덤한 값은 : {randomValue} 입니다.");

        if (11 <= count)
        {
            int ssrIndex = Random.Range(0, SSRCharacterList.Count);
            Debug.Log($"SSR {SSRCharacterList[ssrIndex]}를 뽑았다!(천장이다!)");

            count = 0;
            return;
        }

        if (randomValue <= 5) //10%의 확률 1~ 5 -> 5%
        {
            int ssrIndex = Random.Range(0, SSRCharacterList.Count);
            Debug.Log($"SSR {SSRCharacterList[ssrIndex]}를 뽑았다!");
        }
        else if (randomValue <= 50)//45%의 확률 6~50 -> 45%
        {
            int srIndex = Random.Range(0, SSRCharacterList.Count);
            Debug.Log($"SR {SRCharacterList[srIndex]}를 뽑았다!");
        }
        else  //50%의 확률 51~100 -> 50%                     
        {
            int rIndex = Random.Range(0, SSRCharacterList.Count);
            Debug.Log($"R {RCharacterList[rIndex]}를 뽑았다!");
        }


        count++;
    }
    public void Gacha10_2() // 0연속 뽑기 시스템
    {
        Debug.Log("----- 10연속 뽑기 START -----");
        for (int i = 0; i < 10; i++)
        {
            Debug.Log($"--- {i + 1}번째 결과 ---");
            Gacha2();
        }
    }

    public void Gacha3() // 뽑기 시스템 1(단차)
    {
        int randomValue = Random.Range(1, 101); //1이상  100이하의 랜덤한 값을 받아 오겠다.(1 ~ 100)
        Debug.Log($"랜덤한 값은 : {randomValue} 입니다.");

      
        
        if (randomValue <= 40)//45%의 확률 1~40 -> 40%
        {
            int srIndex = Random.Range(0, SSRCharacterList.Count);
            Debug.Log($"SR {SRCharacterList[srIndex]}를 뽑았다!");
        }
        else  //50%의 확률 41~100 -> 60%                     
        {
            int rIndex = Random.Range(0, SSRCharacterList.Count);
            Debug.Log($"R {RCharacterList[rIndex]}를 뽑았다!");
        }


        count++;
    }
    public void Gacha10_3() // 0연속 뽑기 시스템
    {
        Debug.Log("----- 10연속 뽑기 START -----");
        for (int i = 0; i < 10; i++)
        {
            Debug.Log($"--- {i + 1}번째 결과 ---");
            Gacha3();
        }
    }
}
