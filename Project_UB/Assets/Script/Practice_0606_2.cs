using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Practice_0605_2 : MonoBehaviour
{
    private string name = "이호범";
    private int age = 2;
    private string hobby = "게임";
    private int height = 186;
    private float weight = 123.4f;
    private string MBTI = "INFJ";
    private string favoriteFood = "햄버거";
    private string job = "콘텐츠 기획자";
    private string Education = "서강대학교";
    private string The_Big_3_record = "460";


    public TMP_Text infoText;

    // 내부 인덱스
    private int currentIndex = 0;

    // 출력할 한 줄씩의 정보
    private List<string> infoLines = new List<string>();

    void OnEnable()
    {
        InitInfoLines();
        infoText.text  = "";  
    }

    private void InitInfoLines()
    {
        infoLines.Clear();
        infoLines.Add("안녕하세요. 제 이름은 " + name + "입니다.");
        infoLines.Add("제 나이는 " + age + "세 입니다.");
        infoLines.Add("제 취미는 " + hobby + "입니다.");
        infoLines.Add("제 키는 " + height + "cm 입니다.");
        infoLines.Add("제 몸무게는 " + weight + "kg 입니다.");
        infoLines.Add("제 MBTI는 " + MBTI + "입니다.");
        infoLines.Add("제가 좋아하는 음식은 " + favoriteFood + "입니다.");
        infoLines.Add("제가 희망하는 직군은 " + job + "입니다.");
        infoLines.Add("제 졸업한 대학은 " + Education + "입니다.");
        infoLines.Add("제 3대 운동 기록은 " + The_Big_3_record + "입니다.");
    }

    // 버튼 클릭 시 호출
    public void PrintNextInfo()
    {
        if (currentIndex < infoLines.Count)
        {
            infoText.text = infoLines[currentIndex];
            currentIndex++;
        }
        else
        {
            infoText.text = "모든 정보를 출력했습니다!";
            currentIndex = 0;  // 다시 처음부터 반복할 수도 있고, 여기서 멈춰도 됩니다.
        }
    }
}
