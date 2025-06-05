using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice_0605 : MonoBehaviour
{
    private string name = "이호범";
    private int age = 28;
    private string hobby = "게임";
    private int height = 186;
    private float weight = 123.4f;
    private string MBTI = "INFJ";
    private string favoriteFood = "햄버거";
    private string job = "콘텐츠 기획자";
    private string Education = "서강대학교";
    private string The_Big_3_record = "460";


    void Start()
    {
        SelfIntroductuion();
        
    }

    public void SelfIntroductuion()
    {
        Debug.Log("안녕하세요. 제 이름은 " + name + "입니다.");
        Debug.Log("제 나이는 " + age + "세 입니다.");
        Debug.Log("제 취미는 " + hobby + "입니다.");
        Debug.Log("제 키는 " + height + "cm 입니다.");
        Debug.Log("제 몸무게는 " + weight + "kg 입니다.");
        Debug.Log("제 MBTI는 " + MBTI + "입니다.");
        Debug.Log("제가 좋아하는 음식은 " + favoriteFood + "입니다.");
        Debug.Log("제가 희망하는 직군은 " + job + "입니다.");
        Debug.Log("제 졸업한 대학은 " + Education + "입니다.");
        Debug.Log("제 3대 운동 기록은 " + The_Big_3_record + "입니다.");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
