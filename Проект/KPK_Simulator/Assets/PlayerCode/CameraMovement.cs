using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ����� �������� �������
public class CameraMovement : MonoBehaviour
{
    // ���������������� ������
    public float mouseSensitivity = 100f;

    // �������� �� � � �
    private float xRotation = 0f;
    private float yRotation = 0f;


    // Start is called before the first frame update
    void Start()
    {
        // ���������� ������� ���� �� ������ ������ � ������� ���
        Cursor.lockState = CursorLockMode.Locked;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        // ���������� �������� �� � � � ���� * �� ���������������� ������ � ����� ��������
        // S = V * t
        // S = ���������� ��������
        // V = ��������� �� ��� * ����������������
        // t = ����� ����������� �� �������� (Ti,e.deltaTime)
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // �������� �������� ������ X ��� (������ � �����)
        xRotation -= mouseY;

        // ����������� �������� ������ (����� �� ���� ��� � ����)
        xRotation = Mathf.Clamp(xRotation, -60f, 20f);

        // �������� ������� ������ (����� � ����)
        yRotation += mouseX;

        // ��������� ����������� ��������
        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);


    }
}
