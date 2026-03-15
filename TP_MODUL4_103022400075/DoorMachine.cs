using System;

public class DoorMachine
{
    private IDoorState state;

    private interface IDoorState
    {
        void BukaPintu(DoorMachine machine);
        void KunciPintu(DoorMachine machine);
        void Enter();
    }

    public DoorMachine()
    {
        state = new TerkunciState();
        state.Enter();
    }

    public void BukaPintu() => state.BukaPintu(this);

    public void KunciPintu() => state.KunciPintu(this);

    private void SetState(IDoorState newState)
    {
        state = newState;
        state.Enter();
    }

    private class TerkunciState : IDoorState
    {
        public void Enter()
        {
            Console.WriteLine("Pintu terkunci");
        }

        public void BukaPintu(DoorMachine machine)
        {
            machine.SetState(new TerbukaState());
        }

        public void KunciPintu(DoorMachine machine)
        {
            Console.WriteLine("Pintu sudah terkunci");
        }
    }

    private class TerbukaState : IDoorState
    {
        public void Enter()
        {
            Console.WriteLine("Pintu tidak terkunci");
        }

        public void BukaPintu(DoorMachine machine)
        {
            Console.WriteLine("Pintu sudah terbuka");
        }

        public void KunciPintu(DoorMachine machine)
        {
            machine.SetState(new TerkunciState());
        }
    }
}
