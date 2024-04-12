using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Runtime.InteropServices;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Update()
    {

        // anyKeyDown 키보드 마우스 입력 받기 
        if (Input.anyKeyDown) // return type : bool
        {
            Debug.Log("아무 키를 눌렀습니다.");
        }
        /*
        // 키 입력 누르고 있는 것
        if (Input.anyKey)
        {
            Debug.Log("아무 키를 누르고 있습니다.");
        }
        */
        // key - 눌렀을 때, 누르고 있을 때, 떼었을 때 3가지 상태가 있음
        if (Input.GetKeyDown(KeyCode.Return)) // 키보드를 파라미터로 
        {
            Debug.Log("아이템을 구입했습니다.");
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("왼쪽 방향키로 이동.");
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            Debug.Log("이동을 멈추었습니다.");
        }

        // 마우스 입력

        if (Input.GetMouseButtonDown(0)) // 파라미터 0 - 좌클 1 - 우클
        {
            Debug.Log("미사일 발사!");
        }
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("모으는 중");
        }
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("슈퍼 미사일 발사!");

        }

        // inputmanager에서 버튼 api 사용 / project settings - input manager에 있는 버튼 사용

        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("점프!");
        }
        if (Input.GetButton("Jump"))
        {
            Debug.Log("점프 모으는 중");
        }
        if (Input.GetButtonUp("Jump"))
        {
            Debug.Log("슈퍼 점프!");
        }
        // 횡 이동

        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("횡 이동 중" + Input.GetAxis("Horizontal")); // 축 지정 retrun float);
            // GetAxisRaw -> 1, -1로 정수형으로 이동
        }
        if (Input.GetButton("Vertical"))
        {
            Debug.Log("종 이동 중" + Input.GetAxis("Vertical")); // 축 지정 retrun float);
            // GetAxisRaw -> 1, -1로 정수형으로 이동
        }

    }
}
