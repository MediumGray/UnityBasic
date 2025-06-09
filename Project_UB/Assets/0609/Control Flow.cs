using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    int count;

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
        // 확률이 10%면 로그에 '레드후드'을 뽑았다!
        //확률이 20%면 로그에 '모더니아'를 뽑았다!
        //나머지 70% 확률로 ''도로롱'을 뽑았다!


        int randomValue = Random.Range(1, 101); //1이상  100이하의 랜덤한 값을 받아 오겠다.(1 ~ 100)
        Debug.Log($"랜덤한 값은 : {randomValue} 입니다.");
        if (8 <= count)
        {
            Debug.Log("레드후드를 뽑았다!");
            count = 0;
            return;
        }

        if (randomValue <= 3) //10%의 확률 1~ 3 -> 3%
           {
                Debug.Log("레드후드를 뽑았다!");
            }
        else if(randomValue <= 12)//20%의 확률 3~12 -> 10%
        {
                Debug.Log("모더니아를 뽑았다!");
            }
        else if (randomValue <= 32)//20%의 확률 12~32 -> 20%                     
        {
                Debug.Log("홍북이를 뽑았다!");
        }
        else
        {
            Debug.Log("도로롱를 뽑아버렸다!");

        }
        count++;
    }
    public void Gacha10()
    {
        Debug.Log("----- 10연속 뽑기 START -----");
        for (int i = 0; i < 10; i++)
        {
            Debug.Log($"--- {i + 1}번째 결과 ---");
            Gacha();
        }
    }

    public void GachaW()
    {
        int number = 0;
        int randomValue = Random.Range(1, 101); //1이상  100이하의 랜덤한 값을 받아 오겠다.(1 ~ 100)
        Debug.Log($"랜덤한 값은 : {randomValue} 입니다.");
        

        while (number < 10)
        {
            Debug.Log($"--- {number + 1}번째 결과 ---");
            Gacha();
            number++;
        }
    }
    public int selectNumber;
    public void GachaSwitch()
    {

        // 스위치 문으로 바꾸기
        int randomValue = Random.Range(1, 101); //1이상  100이하의 랜덤한 값을 받아 오겠다.(1 ~ 100)
        Debug.Log($"랜덤한 값은 : {randomValue} 입니다.");
        
        
        switch (selectNumber)
        {
            case 0:
                Debug.Log("레드후드 픽업!");
                {
                    if (randomValue <= 3) //10%의 확률 1~ 3 -> 3%
                    {
                        Debug.Log("레드후드를 뽑았다!");
                    }
                    else if (randomValue <= 12)//20%의 확률 3~12 -> 10%
                    {
                        Debug.Log("모더니아를 뽑았다!");
                    }
                    else if (randomValue <= 32)//20%의 확률 12~32 -> 20%                     
                    {
                        Debug.Log("홍북이를 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("도로롱를 뽑아버렸다!");

                    }
                }
                break;
            case 1:
                Debug.Log("엘리스 픽업!");
                {
                    if (randomValue <= 3) //10%의 확률 1~ 3 -> 3%
                    {
                        Debug.Log("엘리스를 뽑았다!");
                    }
                    else if (randomValue <= 12)//20%의 확률 3~12 -> 10%
                    {
                        Debug.Log("누아르를 뽑았다!");
                    }
                    else if (randomValue <= 32)//20%의 확률 12~32 -> 20%                     
                    {
                        Debug.Log("아니스를 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("도로롱를 뽑아버렸다!");
                    }
                }
                break;
            case 2:
                Debug.Log("홍련 픽업!");
                {
                    if (randomValue <= 3) //10%의 확률 1~ 3 -> 3%
                    {
                        Debug.Log("홍련을 뽑았다!");
                    }
                    else if (randomValue <= 12)//20%의 확률 3~12 -> 10%
                    {
                        Debug.Log("블랑를 뽑았다!");
                    }
                    else if (randomValue <= 32)//20%의 확률 12~32 -> 20%                     
                    {
                        Debug.Log("흑련을 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("도로롱를 뽑아버렸다!");
                    }
                }
                break;
            default:
                Debug.Log("상시 도로롱!");
                {
                    if (randomValue <= 3) //10%의 확률 1~ 3 -> 3%
                    {
                        Debug.Log("도로롱1를 뽑았다!");
                    }
                    else if (randomValue <= 12)//20%의 확률 3~12 -> 10%
                    {
                        Debug.Log("도로롱2를 뽑았다!");
                    }
                    else if (randomValue <= 32)//20%의 확률 12~32 -> 20%                     
                    {
                        Debug.Log("도로롱3를 뽑았다!");
                    }
                    else
                    {
                        Debug.Log("도로롱4를 뽑아버렸다!");
                    }
                }
                break;
        }
    }

}


