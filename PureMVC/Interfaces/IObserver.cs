using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObserver
{
    //�Ա�NotifyContext
    bool CompareNotifyContext(object obj);
    //֪ͨ�۲���
    void NotifyObserver(INotification notification);
    //��¼��Mediator��Command
    object NotifyContext { set; }
    //֪ͨ����
    string NotifyMethod { set; }
}
