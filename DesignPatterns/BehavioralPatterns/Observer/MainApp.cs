namespace DesignPatterns.BehavioralPatterns.Observer
{
    public class MainApp
    {
        void DoWork()
        {
            IObserver observer = new Observer();
            ISubject subject = new Subject();

            subject.Attach(observer);
            subject.Notify();
        }
    }

    public class Subject : ISubject
    {

        public void Attach(IObserver observer)
        {
            throw new NotImplementedException();
        }

        public void Detach(IObserver observer)
        {
            throw new NotImplementedException();
        }

        public void Notify()
        {
            throw new NotImplementedException();
        }
    }

    public class Observer : IObserver
    {
        public void Update()
        {
            throw new NotImplementedException();
        }
    }

    public interface IObserver
    {
        void Update();
    }

    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);

        void Notify();
    }
}
