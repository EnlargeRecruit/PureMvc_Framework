//view接口
public interface IView 
{
    //判断是否存在中介(以中介者的名字为参数)
    bool HasMediator(string mediatorName);
    //注册中介者
    void RegisterMediator(IMediator mdeiator);
    //移除中介者
    IMediator RemoveMediator(string mediatorName);
    //回复中介者
    IMediator RetrieveMediator(string mediatorName);
    //向观察者下发事件通知
    void NotifyObservers(INotification note);
    //注册观察者
    void RegisterObserver(string notificationName, IObserver observer);
    //移除观察者
    void RemoveObserver(string notificationName, object notifyContext);
}

