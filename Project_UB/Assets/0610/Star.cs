using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarWalkin : MonoBehaviour
{
    // 1. string.Empty
    // string ������ ���� �ʱ�ȭ �մϴ�.
    //string star;
    //star = string.Empty;

    // 2. ��, ��ĭ, �ٹٲ� �߰��ϱ�
    // Debug.Log�� ����Ͽ� �ܼ�â�� ����մϴ�
    //star += "��"; // ��
    //star += "��"; // ��ĭ
    //star += "\n"; // �ٹٲ�

    // 3. Debug.Log("");
    // Debug.Log�� ����Ͽ� �ܼ�â�� ����մϴ�
    //Debug.Log(star);


    string star;
    

    void Start()
    {
        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();
    }

    public void Phase1()
    {
        star = string.Empty;
       
        // ������ 1
       for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < i + 1; j++)
            {
                star += "��"; // ��
            }
             star += "\n"; // �ٹٲ�
        }

        Debug.Log(star);
    }

    public void Phase2()
    {
        star = string.Empty;
        // ������ 2

        for (int i = 0; i < 5; i++)
        {
            for (int k = 5; k > i + 1; k--)
            {
                star += "��"; // ��ĭ
            }
            for (int j = 0; j < i + 1; j++)
            {
                star += "��"; // ��
            }
           
            star += "\n"; // �ٹٲ�
        }


        Debug.Log(star);
    }

    public void Phase3()
    {
        star = string.Empty;

        // ������ 3
        for (int i = 0; i < 9; i++)
        {
            if (i < 5)
            {

                for (int j = 0; j < i + 1; j++)
                { 
                    star += "��"; // ��
                }   
            }
            else
            {
                for (int j = 9-i; j > 0; j--)
            {
                star += "��"; // ��
            }
            }
            star += "\n"; // �ٹٲ�
        }

        Debug.Log(star);
    }

    public void Phase4()
    {
        star = string.Empty;

        // ������ 4
        for (int i = 0; i < 9; i++)
        {

            if (i < 5)
            {
                for (int k = 5; k > i + 1; k--)
                {
                    star += "��"; // ��ĭ
                }

                for (int j = 0; j < i + 1; j++)
                {
                    star += "��"; // ��
                }

            }
            else
            {
                for (int k = 5; k < i+1; k++)
                {
                    star += "��"; // ��ĭ
                }
                for (int j = 9 - i; j > 0; j--)
                {
                    star += "��"; // ��
                }
            }
            star += "\n"; // �ٹٲ�
        }


        Debug.Log(star);
    }

    public void Phase5()
    {
        star = string.Empty;

        // ������ 5
        for (int i = 0; i < 9; i++)
        {

            if (i < 5)
            {
                for (int k = 5; k > i + 1; k--)
                {
                    star += "��"; // ��ĭ
                }

                for (int j = 0; j < 2 * i + 1; j++)
                {
                    star += "��"; // ��
                }

            }
            else
            {
                for (int k = 5; k < i + 1; k++)
                {
                    star += "��"; // ��ĭ
                }
                for (int j = 0; j < 2*(8-i)+1; j++)
                {
                    star += "��"; // ��
                }
            }
            star += "\n"; // �ٹٲ�
        }


        Debug.Log(star);
    }


}
