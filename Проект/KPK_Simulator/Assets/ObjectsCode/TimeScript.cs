using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // ��� ��������� �����
using System;
using System.IO;
using Debug = UnityEngine.Debug;


public class TimeScript : MonoBehaviour
{
    // ��������� ���� �����
    [SerializeField] TextMeshProUGUI timerText;

    // ���� �� ������� ��������
    private int hours = Convert.ToInt32(DateTime.Now.ToString("HH"));
    // ������ �� ������� ��������
    private int minutes = Convert.ToInt32(DateTime.Now.ToString("mm"));
    // ������� �� ������� ��������
    private int seconds = Convert.ToInt32(DateTime.Now.ToString("ss"));
    private string partOfTheDay;
    private float elapsedTomeInt = 0;
    


    // Start is called before the first frame update
    void Start()
    {
        // ��� ������ ������ ��������� - ��������� ���������� �������
        timerText.text = DateTime.Now.ToString("HH:mm:ss");
    }

    // Update is called once per frame
    void Update()
    {
        // ������ ������� � ������ ������ ����
        elapsedTomeInt += 2.9f;
        // ������� ��� ��� ���
        int visualSec = Mathf.FloorToInt((elapsedTomeInt + seconds) % 60);        
        int visualMin = Mathf.FloorToInt((elapsedTomeInt + seconds) / 60 + minutes);
        int visualHour = Mathf.FloorToInt((visualMin) / 60 + hours) % 24;

        timerText.text = $"{SetPartOfTheDay(visualHour)}\n" +
            $"{visualHour:00}:" +
            $"{visualMin % 60:00}\n" +
            $"{visualSec:00}";
    }

    // ��������� ����� �����
    private string SetPartOfTheDay(int hour)
    {
        
        if (hour < 12)
        {
            new WorkWithJSON().WriteDown_partOfTheDay("����");
            return "����";
        }
        if (hour < 15)
        {
            new WorkWithJSON().WriteDown_partOfTheDay("����");
            return "����";
        }
        if (hour < 21)
        {
            new WorkWithJSON().WriteDown_partOfTheDay("�����");
            return "�����";
        }
        new WorkWithJSON().WriteDown_partOfTheDay("����");
        return "����";

    }

}
