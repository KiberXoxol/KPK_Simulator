using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class Contact : MonoBehaviour
{
    // �������� ��� ������������ ������������ � ������
    void contact(Collider palyer)
    {
        // ���� ��� ������� - Door
        if (palyer.gameObject.tag == "Door")
        {
            // ��������
            Debug.Log("DoorOpen");
        }
    }
}
