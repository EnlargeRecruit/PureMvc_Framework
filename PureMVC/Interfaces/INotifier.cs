using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface INotifier
{
    //发送消息和方法重载
    void SendNotification(string notificationName);
    void SendNotification(string notificationName, object body);
    void SendNotification(string notificationName, object body, string type);
}
