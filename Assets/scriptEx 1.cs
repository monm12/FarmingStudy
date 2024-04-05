using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptEx1 : MonoBehaviour
{   // �������� ���
    // Data Type
    int health = 100;
    int level = 5;
    float strength = 15.5f;
    bool isFullLevel = true; // or false;
    // Start is called before the first frame update
    void Start()
    {
        // b03 Log ���
        Debug.Log("hi");

        // b04 C# ����
        
        float j = 1.0f;
        string k = "It is String";
        bool l = true; // or false;

        // Reference Type
        string[] monsters = { "������", "�縷��", "�Ǹ�" };
        int[] monsterLevel = new int[3]; // ���̰� 4�� �迭 ����
        monsterLevel[0] = 1;
        monsterLevel[1] = 5;
        monsterLevel[2] = 20;

        Debug.Log("���� ����:"+ monsterLevel[0]); // 0�� �ε����� ������ �� ����
        Debug.Log("���� �̸�:" + monsters[0]);

        List<string> items = new List<string>(); // ����Ʈ ����
        items.Add("���� ���� 30"); // 0�� �ε���
        items.Add("���� ���� 30");

        Debug.Log(items[0]);

        items.RemoveAt(0); // 0�� �ε��� �� ����

        // ������ +, -, *, /, %

        int exp = 1500;
        exp += 500;
        exp -= 300;
        exp *= 2;

        string playerName = "KIM";
        string title = "������";
        Debug.Log("Ǯ����:"+ title + "" + playerName);

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

        switch (monsters[0])
        {
            case "������":
                Debug.Log("lvl 1");
                break;
            case "�縷��":

                break;
            case "�Ǹ�":

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
        foreach (string names in monsters) // monsters �迭�� �ε��� ���� �ϳ��� names ������ ������
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
