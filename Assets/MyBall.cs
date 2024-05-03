using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>(); // 변수에 컴포넌트 저장
        //rigid.velocity = Vector3.right;
        // rigid.velocity = new Vector3(2, 4, 3);
        rigid.AddForce(Vector3.up * 5, ForceMode.Impulse); // AddForce 2개 인자값, mass에 영향 받음
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //rigid.velocity = new Vector3(2, 4, -1); // RigidBody는 FixedUpdate에 작성
        // 키 입력으로 이동
        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 25, ForceMode.Impulse); // 누를 수록 커짐
            Debug.Log(rigid.velocity);
        }
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        rigid.AddForce(vec, ForceMode.Impulse);

        // 회전력
        rigid.AddTorque(Vector3.up); // back, up, down
    }

    private void OnTriggerStay(Collider other) // Collider의 Trigger 체크 시, 콜라이더 충돌 시 이벤트 발생
    {
        if(other.name == "Cube")
        {
            rigid.AddForce(Vector3.up *2, ForceMode.Impulse); // 큐브에 닿으면 위로 올라감
        }
    }
}
