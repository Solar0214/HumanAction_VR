using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //�÷��̾��� ������ ���ǵ�, ����, ���� ����
    public float speed;
    float hAxis;
    float vAxis;
    bool wDown;
    //�÷��̾��� ������ ���Ͱ� ���� ����
    Vector3 moveVec;

    //�÷��̾��� ������ �ִϸ��̼� ���� ����
    Animator anim;

    void Awake()
    {
        anim = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Vertical");
        //����ƮŰ�� �� ������ �����̸� �޸��� ����
        wDown = Input.GetButton("Walk");

        //�÷��̾��� ������ ���Ͱ� ����
        moveVec = new Vector3(hAxis, 0, vAxis).normalized;

        //�÷��̾��� �޸��� �ӵ� 0.3���� ����(���׿����� ����� ���)
        transform.position += moveVec * speed * (wDown ? 0.3f : 1f) * Time.deltaTime;

        //�÷��̾��� �޸��� �ӵ� 0.3���� ����(if���� ����� ���)
        //if(wDown)
        //    transform.position += moveVec * speed * 0.3f * Time.deltaTime;
        //else
        //    transform.position += moveVec * speed * Time.deltaTime;



        //�÷��̾��� �޸��� ���Ͱ� ����
        anim.SetBool("isRun", moveVec != Vector3.zero);
        anim.SetBool("isWalk", wDown);


        //�÷��̾��� ȸ���� ����(�����ϰ� ������)
        //transform.LookAt(transform.position + moveVec);
        
        //�÷��̾��� ȸ���� ����(�ε巴�� ������)
        if (moveVec != Vector3.zero)
        {
            Vector3 relativePos = (transform.position + moveVec) - transform.position;
            Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * 10);
        }
    }
}
