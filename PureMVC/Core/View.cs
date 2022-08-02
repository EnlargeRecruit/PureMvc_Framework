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
    //�����н�
    public virtual bool HasMediator(string mediatorName)
    {
        throw new System.NotImplementedException();
    }
    //֪ͨ�۲���
    public virtual void NotifyObservers(INotification note)
    {
        throw new System.NotImplementedException();
    }
    //��ӹ۲���
    public virtual void RegisterMediator(IMediator mdeiator)
    {
        throw new System.NotImplementedException();
    }
    //����н�
    public virtual void RegisterObserver(string notificationName, IObserver observer)
    {
        throw new System.NotImplementedException();
    }
    //ɾ���۲���
    public virtual IMediator RemoveMediator(string mediatorName)
    {
        throw new System.NotImplementedException();
    }
    //ɾ���н�
    public virtual void RemoveObserver(string notificationName, object notifyContext)
    {
        throw new System.NotImplementedException();
    }
    //���ҹ۲���
    public virtual IMediator RetrieveMediator(string mediatorName)
    {
        throw new System.NotImplementedException();
    }

}
