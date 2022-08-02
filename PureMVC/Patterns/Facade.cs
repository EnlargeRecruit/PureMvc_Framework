using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Facade : IFacade
{
    protected IController m_controller;
    protected static volatile IFacade m_instance;
    protected static readonly object m_staticSyncRoot = new object();
    public static IFacade Instance
    {
        get
        {
            if (m_instance == null)
            {
                lock (m_staticSyncRoot)
                {
                    if (m_instance == null)
                    {
                        m_instance = new Facade();
                    }
                }
            }
            return m_instance;
        }
    }
    public bool HasCommand(string notificationName)
    {
        throw new NotImplementedException();
    }

    public bool HasMediator(string mediatorName)
    {
        throw new NotImplementedException();
    }

    public bool HasProxy(string proxyName)
    {
        throw new NotImplementedException();
    }

    public void NotifyObservers(INotification note)
    {
        throw new NotImplementedException();
    }

    public void RegisterCommand(string notificationName, Type commandType)
    {
        throw new NotImplementedException();
    }

    public void RegisterMediator(IMediator mediator)
    {
        throw new NotImplementedException();
    }

    public void RegisterProxy(IProxy proxy)
    {
        throw new NotImplementedException();
    }

    public void RemoveCommand(string notificationName)
    {
        throw new NotImplementedException();
    }

    public IMediator RemoveMediator(string mediatorName)
    {
        throw new NotImplementedException();
    }

    public IProxy RemoveProxy(string proxyName)
    {
        throw new NotImplementedException();
    }

    public IMediator RetrieveMediator(string mediatorName)
    {
        throw new NotImplementedException();
    }

    public IProxy RetrieveProxy(string proxyName)
    {
        throw new NotImplementedException();
    }

    public void SendNotification(string notificationName)
    {
        throw new NotImplementedException();
    }

    public void SendNotification(string notificationName, object body)
    {
        throw new NotImplementedException();
    }

    public void SendNotification(string notificationName, object body, string type)
    {
        throw new NotImplementedException();
    }
}
