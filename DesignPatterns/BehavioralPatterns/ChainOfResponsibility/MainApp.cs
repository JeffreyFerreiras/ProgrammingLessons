namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility
{
    /*
     * to its receiver by giving more than one object a chance to handle the request.
     * Also, it has the intent to chain the receiving objects and pass 
     * the request along the chain until an object handles it.
     */

    class MainApp
    {
        public static void DoWork()
        {
            Approver ron = new Director();
            Approver bob = new VicePresident();
            Approver ric = new President();

            ron.SetSuccessor(bob);
            bob.SetSuccessor(ric);

            Purchase p = new Purchase
            {
                Amount = 8888
            };

            ron.ProcessRequest(p);

            p = new Purchase
            {
                Amount = 25
            };

            ron.ProcessRequest(p);

            p = new Purchase
            {
                Amount = 77700
            };

            ron.ProcessRequest(p);

            Console.ReadLine();
        }
    }

    abstract class Approver
    {
        protected Approver successor;

        public void SetSuccessor(Approver successor)
        {
            this.successor = successor;
        }

        public abstract void ProcessRequest(Purchase purchase);

        public void Print(Purchase purchase)
        {
            Console.WriteLine($"Processed by: {this.GetType().Name} Amount: {purchase.Amount}");
        }
    }

    class Director : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if(purchase.Amount < 1000)
            {
                Print(purchase);
            }
            else if(this.successor!=null)
            {
                this.successor.ProcessRequest(purchase);
            }
        }
    }
    class VicePresident : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 25000)
            {
                Print(purchase);
            }
            else if (this.successor != null)
            {
                this.successor.ProcessRequest(purchase);
            }
        }
    }

    class President : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 125000)
            {
                Print(purchase);
            }
            else if (this.successor != null)
            {
                this.successor.ProcessRequest(purchase);
            }
        }
    }

    public class Purchase
    {
        public int Amount { get; set; }
    }
}
