using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{
    MeshRenderer mesh;
    Material mat;
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = GetComponent<Material>();
    }

    private void OnCollisionEnter(Collision collision) //물리적 충돌시 호출 , Collision - 충돌 정보 클래스
    {
        if(collision.gameObject.name == "My Balll")
        {
            mat.color = new Color(0, 0, 0);
        }
        
    }
    /*
    private void OnCollisionStay(Collision collision) // 충돌 중
    {
        
    }
    */
    private void OnCollisionExit(Collision collision) // 충돌 후 
    {
        if (collision.gameObject.name == "My Balll")
        {
            mat.color = new Color(1, 1, 1);
        }
    }
    
}
