using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTeleport : MonoBehaviour
{
    public PortalCont portalController;


    private void OnTriggerEnter(Collider other)
    {
        //�浹�� �ڷ���Ʈ�� �ض�
        portalController.Teleport();
    }
}
