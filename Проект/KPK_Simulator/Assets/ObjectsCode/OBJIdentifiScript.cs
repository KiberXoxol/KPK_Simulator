using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// ����� ��� ����������� ������� �� ������� ������� ���������
public class OBJIdentifiScript : MonoBehaviour
{
    // ���������� ��� ����������� ������� ��������
    public GameObject interactionInformationUI;

    // ���������� ��� ��������� ������
    private Text interactionText;



    // Start is called before the first frame update
    void Start()
    {
        interactionText = interactionInformationUI.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        // ������ ������ ��������� � ������ (��� �������� ������������)
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // ���� ������ ������� �� ������
        if (Physics.Raycast(ray, out hit))
        {
            var selectionTransform = hit.transform;
            // ���� � ������� ��������� ���� ���
            if (selectionTransform.GetComponent<InteractableObject>())
            {
                
                interactionText.text = selectionTransform.GetComponent<InteractableObject>().GetItemName();
                interactionInformationUI.SetActive(true);
            }
            // ���� � ������� ��������� ����������� ���
            else 
            {
                Debug.Log("00");
                interactionInformationUI.SetActive(false);
            }
        } 
        // ���� ������ ������� �� ����
        else
        {
            
            interactionInformationUI.SetActive(false);
        }

    }
}
