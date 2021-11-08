using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCont : MonoBehaviour
{
    public Transform land1, land2;
    public Transform playerRoot, playerCam;
    public Transform portalCam;

    // Start is called before the first frame update
    void Start()
    {
      
        
    }

    // Update is called once per frame
    void Update()
    {
        //�÷��̾� ī�޶��� �����ǿ��� ����1�� �������� �� �������� ���Ѵ�.
        Vector3 playerOffset = playerCam.position - land1.position;

        //���� �������� ����2�� �����ǿ� ���Ͽ� ����ķ�� ������.
        portalCam.position = land2.position + playerOffset;

        //�÷��̾� ī�޶� ȸ���� ��Żī�޶��� ȸ���� �Բ� ���ư��� �Ѵ�.
        portalCam.rotation = playerCam.rotation;
    }

    //�ڷ���Ʈ ���� Ŭ����
    public void Teleport()
    {
        // land1�� land2�� �ٲ��ش�.
        var playerLand = land1;
        land1 = land2;
        land2 = playerLand;

        //�÷��̾��� ��ġ�� ���� ī�޶��� ��ġ�� �־��ش�.
        playerRoot.position = portalCam.position;
    }

}
