namespace Interface
{
    public interface IObserver
    {
        void AddObservable(IObservable observable);
        void ConcreteObserver();
    }
}
