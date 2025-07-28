using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;

    private void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        GenerateData();
    }

    void GenerateData()
    {
        talkData.Add(1000, new string[] { "�̴ϰ��� �÷��ǹ��忡 �����Ͻðڽ��ϱ�?" });
        talkData.Add(1500, new string[] { "�̴ϰ��� 2D ž�ٿ� ���� ���ӿ� �����Ͻðڽ��ϱ�?" });
    }

    public string GetTalk(int id, int talkIndex)
    {
        return talkData[id][talkIndex];
    }
}
