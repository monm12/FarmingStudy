using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptEx1 : MonoBehaviour
{
    int health = 100;
    int level = 5;
    // Start is called before the first frame update
    void Start()
    {
        // b03 Log ���
        Debug.Log("hi");

        // b04 C# ����
        // Data Type
        int i = 10;
        float j = 1.0f;
        string k = "It is String";
        bool l = true; // or false;

        // Reference Type
        string[] name = { "Kim", "Lee", "Park" };
        Debug.Log(name[0]); // 0�� �ε����� ������ �� ����
        Debug.Log(name[2]);

        int[] level = new int[3]; // ���̰� 4�� �迭 ����
        level[0] = 10;
        level[1] = 20;
        level[2] = 30;
        level[3] = 40;
        Debug.Log(level[0]); // 10
        Debug.Log(level[1]); // 20

        List<string> items = new List<string>(); // ����Ʈ ����
        items.Add("new String 1"); // 0�� �ε���
        items.RemoveAt(0); // 0�� �ε��� �� ����

        // ������ +, -, *, /, %

        int exp = 1500;
        exp += 500;
        exp -= 300;
        exp *= 2;

        string playerName = "KIM";
        string title = "������";
        Debug.Log(title + "" + playerName);

        // �� ������
        // == , !=, >=, <=, <, >
        // ��������
        // && == and , || == or , ���׿����� ? A : B - true A, false B
        bool isBadCondition = false;
        string condition = isBadCondition ? "bad" : "goot";

        // ���� if - else, else if
        if (exp == 40)
        {
            Debug.Log("it is 40");
        }
        else if (exp == 50){
            Debug.Log("exp is 50");
        }
        else
        {
            Debug.Log("it is false");
        }

        switch (level[0])
        {
            case 0:
                Debug.Log("lvl 1");
                break;
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            default: // ��� �ش� x �� �� ����
                break;
        }

        // �ݺ�
        
        while(health > 0)
        {
            health--;
            if (health < 0)
            {
                Debug.Log("���");
            }
            if(health == 10)
            {
                Debug.Log("���� ���");
                break;
            }
        }

        for (int count = 0; count < 10; count++)
        {
            health++;
            Debug.Log("ġ����" + health);

        }
        for (int idx = 0; idx < name.Length; idx++) // �迭-Length , List- Count
        {
            Debug.Log("�̸�:" + name[idx]);
        }

        // foreach - ���̽��� for i in list �� ���
        foreach (string names in name) // name �迭�� �ε����� �ϳ��� names ������ ������
        {

        }

        health = Heal(health);

        for (int idx = 0; idx < name.Length; idx++)
        {
            Debug.Log("�̸�:" + name[idx] + "����:");// + Battle(name[idx]);
        }

        // Ŭ����
        //Actor player = new Actor(); // ��ü ����
        Player player = new Player(); // Actor ���
        // ������ public, private

        player.id = 0;
        player.name = "kim";
        player.Talk();

    }
    // �Լ�, �޼ҵ�
    int Heal(int health)
    {
        health += 10;
        Debug.Log("���� �޽��ϴ�" + health); 
        return health;
    }
    void Heal()
    {
        health += 10;
        Debug.Log("���� �޽��ϴ�" + health);
    }

    string Battle(int lvl)
    {
        string result;
        if (level >= lvl)
        {
            result = "�̰���ϴ�";
        }
        else
        {
            result = " �����ϴ�";
        }
        return result;
    }

}
