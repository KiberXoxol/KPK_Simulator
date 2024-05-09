using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.IO;
using Newtonsoft.Json;





public class WorkWithJSON : MonoBehaviour
{
    // ����� ��� �������� ����������
    public class InformationOfJson
    {
        public string partOfTheDay;
        public string text;
    }
    // ���� � JSON �����
    static private string path = Convert.ToString(String.Join("\\", Environment.CurrentDirectory.ToString().Split('\\').Take(
                    Environment.CurrentDirectory.ToString().Split('\\').Length - 2))) + "\\������\\KPK_Simulator\\Assets\\ActiveInformation.json";
    private string JSONarray = File.ReadAllText(path);

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void WriteDown_partOfTheDay(string partOfTheDay_info)
    {

        InformationOfJson jsonObj = JsonConvert.DeserializeObject<InformationOfJson>(JSONarray);
        jsonObj.partOfTheDay = partOfTheDay_info;
        string output = JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
        File.WriteAllText(path, output);
        
        
    }

    // ������� ����/����/�����/����
    public string Read_partOfTheDay()
    {
        InformationOfJson dayPart = JsonConvert.DeserializeObject<InformationOfJson>(JSONarray);
        return dayPart.partOfTheDay;
        
    }
}
