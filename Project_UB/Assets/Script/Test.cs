using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update

   

    void OnEnable()
    {
        Debug.Log(Random.Range(1, 100));
        // 1 이상 100 미만의 랜덤한 값을 만들겠다.
    }

    int playerLevel = 10; // 플레이어의 레벨을 저장하는 변수
    void Start()
    {
        Debug.Log("나의 레벨은 " + playerLevel + "입니다.");
        Debug.Log($"나의 레벨은 {playerLevel}입니다.");
    }

    // Update is called once per frame
    //void Update()
    //{

    //}
    int Sum(int  value1, int value2)
    {
        return value1 + value2;
    }
}
