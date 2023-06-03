namespace VGP141_22S.DesignPatterns
{
    public interface IObserver
    {
        void Notify(string pMessage);
        void Notify<T>(string pMessage, T pData);
    }   
}
