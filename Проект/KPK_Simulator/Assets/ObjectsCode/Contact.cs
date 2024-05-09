using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using Debug = UnityEngine.Debug;

public class Contact : MonoBehaviour
{
    // �������� ��� ������������ ������������ � ������
    void OnTriggerEnter(Collider palyer)
    {
        // ���� ��� ������� - Door
        if (palyer.gameObject.tag == "Player")
        {
            // ��������
            Debug.Log("DoorOpen");
            SceneManager.LoadScene("SecondScene");
        }
    }
}
