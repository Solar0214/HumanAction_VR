using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTeleport2 : MonoBehaviour
{
    public PortalCont2 portalController2;


    private void OnTriggerEnter(Collider other)
    {
        //�浹�� �ڷ���Ʈ�� �ض�
        portalController2.Teleport();
    }
}
