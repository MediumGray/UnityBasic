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
        // 1 �̻� 100 �̸��� ������ ���� ����ڴ�.
    }

    int playerLevel = 10; // �÷��̾��� ������ �����ϴ� ����
    void Start()
    {
        Debug.Log("���� ������ " + playerLevel + "�Դϴ�.");
        Debug.Log($"���� ������ {playerLevel}�Դϴ�.");
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
