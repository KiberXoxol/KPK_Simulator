using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ����� ��� �������� ����� �������
public class InteractableObject : MonoBehaviour
{
    public string ObjectName;

    public string GetItemName()
    {
        return ObjectName;
    }
}
