using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ֪ͨ
/// </summary>
public interface INotification 
{
    //��д֪ͨ���ڵ������
    string Tostring();
    //֪ͨ�¼�
    object Body { get; set; }
    //֪ͨ����
    string Name { get; }
    //֪ͨ����
    string Type { get; set; }
}
