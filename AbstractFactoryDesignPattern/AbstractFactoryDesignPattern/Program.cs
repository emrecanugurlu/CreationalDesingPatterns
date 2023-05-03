ComputerCreator computerCreator = new ComputerCreator();
computerCreator.createComputer(new AsusComputerFactory());

    class Computer
    {
        public Computer(CPU cPU, RAM rAM, GraphicCard graphicCard)
        {
            CPU = cPU;
            RAM = rAM;
            GraphicCard = graphicCard;
        }

        public Computer()
        {
        }

        public CPU CPU { get; set; }
        public RAM RAM { get; set; }
        public GraphicCard GraphicCard { get; set; }
    }
    public class CPU
    {

    }
    class RAM
    {

    }
    class GraphicCard
    {

    }



    class ComputerCreator
    {
        CPU CPU;
        RAM RAM;
        GraphicCard GraphicCard;
        public Computer createComputer(IComputerFactory factory)
        {
            CPU = factory.createCPU();
            RAM = factory.createRAM();
            GraphicCard = factory.createGraphicCard();

            return new Computer(CPU, RAM, GraphicCard);
        }
    }

    interface IComputerFactory
    {
        public CPU createCPU();
        public RAM createRAM();
        public GraphicCard createGraphicCard();
        public void Run();
    }

    class AsusComputerFactory : IComputerFactory
    {
    public AsusComputerFactory()
    {
        Console.WriteLine($"{nameof(AsusComputerFactory)} nesnesi oluşturuldu");
    }

    public CPU createCPU()
        {
            return new CPU();
        }

        public GraphicCard createGraphicCard()
        {
            return new GraphicCard();
        }

        public RAM createRAM()
        {
            return new RAM();
        }

        public void Run()
        {
            
        }
    }
    //class LenovaComputerFactory : IComputerFactory
    //{
    //    public void Run()
    //    {
    //        Console.WriteLine($"{nameof(LenovaComputerCreator)} nesnesi oluşturuldu");
    //    }
    //}
    //class MSIComputerFactory : IComputerFactory
    //{
    //    public void Run()
    //    {
    //        Console.WriteLine($"{nameof(MSIComputerCreator)} nesnesi oluşturuldu");
    //    }
    //}
    //class ToshibaComputerFactory : IComputerFactory
    //{
    //    public void Run()
    //    {
    //        Console.WriteLine($"{nameof(ToshibaComputerCreator)} nesnesi oluşturuldu");
    //    }
    //}

