using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

// ����� �������� �������
public class CameraMovement : MonoBehaviour
{
    // ���������������� ������
    public float mouseSensitivity = 100f;
    public Transform playerBody;
    public Transform cam;

    // �������� �� � � �
    private float xRotation = 0f;


    // Start is called before the first frame update
    void Start()
    {
        // ���������� ������� ���� �� ������ ������ � ������� ���
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float XCameraMove = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        playerBody.Rotate(Vector3.up * XCameraMove);
        float YCameraMove = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        xRotation -= YCameraMove;
        // ����������� �������� ������ (����� �� ���� ��� � ����)
        xRotation = Mathf.Clamp(xRotation, -60f, 20f);
        cam.localRotation = Quaternion.Euler(xRotation, 0, 0);
    }
}
