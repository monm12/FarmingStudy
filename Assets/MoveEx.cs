using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEx : MonoBehaviour
{
    void Start()
    {

       
    }

    private void Update()
    {
        Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), // 키보드 입력으로 오브젝트 이동
            Input.GetAxis("Vertical"),
            0);

        transform.Translate(vec);
    }

}
