using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    
    int count; // »Ì±â È½¼ö Ä«¿îÆ®

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
        // È®·üÀÌ 10%¸é ·Î±×¿¡ '·¹µåÈÄµå'À» »Ì¾Ò´Ù!
        //È®·üÀÌ 20%¸é ·Î±×¿¡ '¸ð´õ´Ï¾Æ'¸¦ »Ì¾Ò´Ù!
        //³ª¸ÓÁö 70% È®·ü·Î ''µµ·Î·Õ'À» »Ì¾Ò´Ù!


        int randomValue = Random.Range(1, 101); //1ÀÌ»ó  100ÀÌÇÏÀÇ ·£´ýÇÑ °ªÀ» ¹Þ¾Æ ¿À°Ú´Ù.(1 ~ 100)
        Debug.Log($"·£´ýÇÑ °ªÀº : {randomValue} ÀÔ´Ï´Ù.");
        if (8 <= count)
        {
            Debug.Log("·¹µåÈÄµå¸¦ »Ì¾Ò´Ù!");
            count = 0;
            return;
        }

        if (randomValue <= 3) //10%ÀÇ È®·ü 1~ 3 -> 3%
           {
                Debug.Log("·¹µåÈÄµå¸¦ »Ì¾Ò´Ù!");
            }
        else if(randomValue <= 12)//20%ÀÇ È®·ü 3~12 -> 10%
        {
                Debug.Log("¸ð´õ´Ï¾Æ¸¦ »Ì¾Ò´Ù!");
            }
        else if (randomValue <= 32)//20%ÀÇ È®·ü 12~32 -> 20%                     
        {
                Debug.Log("È«ºÏÀÌ¸¦ »Ì¾Ò´Ù!");
        }
        else
        {
            Debug.Log("µµ·Î·Õ¸¦ »Ì¾Æ¹ö·È´Ù!");

        }
        count++;
    }
    public void Gacha10()
    {
        Debug.Log("----- 10¿¬¼Ó »Ì±â START -----");
        for (int i = 0; i < 10; i++)
        {
            Debug.Log($"--- {i + 1}¹øÂ° °á°ú ---");
            Gacha();
        }
    }

    public void GachaW()
    {
        int number = 0;
        int randomValue = Random.Range(1, 101); //1ÀÌ»ó  100ÀÌÇÏÀÇ ·£´ýÇÑ °ªÀ» ¹Þ¾Æ ¿À°Ú´Ù.(1 ~ 100)
        Debug.Log($"·£´ýÇÑ °ªÀº : {randomValue} ÀÔ´Ï´Ù.");
        

        while (number < 10)
        {
            Debug.Log($"--- {number + 1}¹øÂ° °á°ú ---");
            Gacha();
            number++;
        }
    }
    public int selectNumber;
    public void GachaSwitch()
    {

        // ½ºÀ§Ä¡ ¹®À¸·Î ¹Ù²Ù±â
        int randomValue = Random.Range(1, 101); //1ÀÌ»ó  100ÀÌÇÏÀÇ ·£´ýÇÑ °ªÀ» ¹Þ¾Æ ¿À°Ú´Ù.(1 ~ 100)
        Debug.Log($"·£´ýÇÑ °ªÀº : {randomValue} ÀÔ´Ï´Ù.");
        
        
        switch (selectNumber)
        {
            case 0:
                Debug.Log("·¹µåÈÄµå ÇÈ¾÷!");
                {
                    if (randomValue <= 3) //10%ÀÇ È®·ü 1~ 3 -> 3%
                    {
                        Debug.Log("·¹µåÈÄµå¸¦ »Ì¾Ò´Ù!");
                    }
                    else if (randomValue <= 12)//20%ÀÇ È®·ü 3~12 -> 10%
                    {
                        Debug.Log("¸ð´õ´Ï¾Æ¸¦ »Ì¾Ò´Ù!");
                    }
                    else if (randomValue <= 32)//20%ÀÇ È®·ü 12~32 -> 20%                     
                    {
                        Debug.Log("È«ºÏÀÌ¸¦ »Ì¾Ò´Ù!");
                    }
                    else
                    {
                        Debug.Log("µµ·Î·Õ¸¦ »Ì¾Æ¹ö·È´Ù!");

                    }
                }
                break;
            case 1:
                Debug.Log("¿¤¸®½º ÇÈ¾÷!");
                {
                    if (randomValue <= 3) //10%ÀÇ È®·ü 1~ 3 -> 3%
                    {
                        Debug.Log("¿¤¸®½º¸¦ »Ì¾Ò´Ù!");
                    }
                    else if (randomValue <= 12)//20%ÀÇ È®·ü 3~12 -> 10%
                    {
                        Debug.Log("´©¾Æ¸£¸¦ »Ì¾Ò´Ù!");
                    }
                    else if (randomValue <= 32)//20%ÀÇ È®·ü 12~32 -> 20%                     
                    {
                        Debug.Log("¾Æ´Ï½º¸¦ »Ì¾Ò´Ù!");
                    }
                    else
                    {
                        Debug.Log("µµ·Î·Õ¸¦ »Ì¾Æ¹ö·È´Ù!");
                    }
                }
                break;
            case 2:
                Debug.Log("È«·Ã ÇÈ¾÷!");
                {
                    if (randomValue <= 3) //10%ÀÇ È®·ü 1~ 3 -> 3%
                    {
                        Debug.Log("È«·ÃÀ» »Ì¾Ò´Ù!");
                    }
                    else if (randomValue <= 12)//20%ÀÇ È®·ü 3~12 -> 10%
                    {
                        Debug.Log("ºí¶û¸¦ »Ì¾Ò´Ù!");
                    }
                    else if (randomValue <= 32)//20%ÀÇ È®·ü 12~32 -> 20%                     
                    {
                        Debug.Log("Èæ·ÃÀ» »Ì¾Ò´Ù!");
                    }
                    else
                    {
                        Debug.Log("µµ·Î·Õ¸¦ »Ì¾Æ¹ö·È´Ù!");
                    }
                }
                break;
            default:
                Debug.Log("»ó½Ã µµ·Î·Õ!");
                {
                    if (randomValue <= 3) //10%ÀÇ È®·ü 1~ 3 -> 3%
                    {
                        Debug.Log("µµ·Î·Õ1¸¦ »Ì¾Ò´Ù!");
                    }
                    else if (randomValue <= 12)//20%ÀÇ È®·ü 3~12 -> 10%
                    {
                        Debug.Log("µµ·Î·Õ2¸¦ »Ì¾Ò´Ù!");
                    }
                    else if (randomValue <= 32)//20%ÀÇ È®·ü 12~32 -> 20%                     
                    {
                        Debug.Log("µµ·Î·Õ3¸¦ »Ì¾Ò´Ù!");
                    }
                    else
                    {
                        Debug.Log("µµ·Î·Õ4¸¦ »Ì¾Æ¹ö·È´Ù!");
                    }
                }
                break;
        }
    }

}


