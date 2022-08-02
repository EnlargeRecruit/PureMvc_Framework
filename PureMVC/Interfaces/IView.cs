//view�ӿ�
public interface IView 
{
    //�ж��Ƿ�����н�(���н��ߵ�����Ϊ����)
    bool HasMediator(string mediatorName);
    //ע���н���
    void RegisterMediator(IMediator mdeiator);
    //�Ƴ��н���
    IMediator RemoveMediator(string mediatorName);
    //�ظ��н���
    IMediator RetrieveMediator(string mediatorName);
    //��۲����·��¼�֪ͨ
    void NotifyObservers(INotification note);
    //ע��۲���
    void RegisterObserver(string notificationName, IObserver observer);
    //�Ƴ��۲���
    void RemoveObserver(string notificationName, object notifyContext);
}

