using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptEx1 : MonoBehaviour
{   // 전역변수 사용
    // Data Type
    int health = 100;
    int level = 5;
    float strength = 15.5f;
    bool isFullLevel = true; // or false;
    // Start is called before the first frame update
    void Start()
    {
        // b03 Log 찍기
        Debug.Log("hi");

        // b04 C# 기초
        
        float j = 1.0f;
        string k = "It is String";
        bool l = true; // or false;

        // Reference Type
        string[] monsters = { "슬라임", "사막뱀", "악마" };
        int[] monsterLevel = new int[3]; // 길이가 4인 배열 선언
        monsterLevel[0] = 1;
        monsterLevel[1] = 5;
        monsterLevel[2] = 20;

        Debug.Log("몬스터 레벨:"+ monsterLevel[0]); // 0번 인덱스의 데이터 값 참조
        Debug.Log("몬스터 이름:" + monsters[0]);

        List<string> items = new List<string>(); // 리스트 선언
        items.Add("생명 물약 30"); // 0번 인덱스
        items.Add("마나 물약 30");

        Debug.Log(items[0]);

        items.RemoveAt(0); // 0번 인덱스 값 삭제

        // 연산자 +, -, *, /, %

        int exp = 1500;
        exp += 500;
        exp -= 300;
        exp *= 2;

        string playerName = "KIM";
        string title = "전설의";
        Debug.Log("풀네임:"+ title + "" + playerName);

        // 비교 연산자
        // == , !=, >=, <=, <, >
        // 논리연산자
        // && == and , || == or , 삼항연산자 ? A : B - true A, false B
        bool isBadCondition = false;
        string condition = isBadCondition ? "bad" : "goot";

        // 조건 if - else, else if
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
            case "슬라임":
                Debug.Log("lvl 1");
                break;
            case "사막뱀":

                break;
            case "악마":

                break;
            default: // 모두 해당 x 일 때 실행
                
                break;
        }

        // 반복
        
        while(health > 0)
        {
            health--;
            if (health < 0)
            {
                Debug.Log("사망");
            }
            if(health == 10)
            {
                Debug.Log("포션 사용");
                break;
            }
        }

        for (int count = 0; count < 10; count++)
        {
            health++;
            Debug.Log("치료중" + health);

        }
        for (int idx = 0; idx < name.Length; idx++) // 배열-Length , List- Count
        {
            Debug.Log("이름:" + name[idx]);
        }

        // foreach - 파이썬의 for i in list 와 비슷
        foreach (string names in monsters) // monsters 배열의 인덱스 값을 하나씩 names 변수로 가져옴
        {

        }

        health = Heal(health);

        for (int idx = 0; idx < name.Length; idx++)
        {
            Debug.Log("이름:" + name[idx] + "레벨:");// + Battle(name[idx]);
        }

        // 클래스
        //Actor player = new Actor(); // 객체 생성
        Player player = new Player(); // Actor 상속
        // 접근자 public, private

        player.id = 0;
        player.name = "kim";
        player.Talk();

    }
    // 함수, 메소드
    int Heal(int health)
    {
        health += 10;
        Debug.Log("힐을 받습니다" + health); 
        return health;
    }
    void Heal()
    {
        health += 10;
        Debug.Log("힐을 받습니다" + health);
    }

    string Battle(int lvl)
    {
        string result;
        if (level >= lvl)
        {
            result = "이겼습니다";
        }
        else
        {
            result = " 졌습니다";
        }
        return result;
    }

}
