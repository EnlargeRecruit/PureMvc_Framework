using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View : IView
{
    protected static volatile IView m_instance;
    protected static readonly object m_staticSyncRoot = new object();
    public static IView Instance
    {
        get
        {
            if (m_instance == null)
            {
                lock (m_staticSyncRoot)
                {
                    if (m_instance == null)
                    {
                        m_instance = new View();
                    }
                }
            }
            return m_instance;
        }
    }
    protected View()
    {
        this.InitializeView();
    }
    protected virtual void InitializeView()
    {

    }
    //查找中介
    public virtual bool HasMediator(string mediatorName)
    {
        throw new System.NotImplementedException();
    }
    //通知观察者
    public virtual void NotifyObservers(INotification note)
    {
        throw new System.NotImplementedException();
    }
    //添加观察者
    public virtual void RegisterMediator(IMediator mdeiator)
    {
        throw new System.NotImplementedException();
    }
    //添加中介
    public virtual void RegisterObserver(string notificationName, IObserver observer)
    {
        throw new System.NotImplementedException();
    }
    //删除观察者
    public virtual IMediator RemoveMediator(string mediatorName)
    {
        throw new System.NotImplementedException();
    }
    //删除中介
    public virtual void RemoveObserver(string notificationName, object notifyContext)
    {
        throw new System.NotImplementedException();
    }
    //查找观察者
    public virtual IMediator RetrieveMediator(string mediatorName)
    {
        throw new System.NotImplementedException();
    }

}
