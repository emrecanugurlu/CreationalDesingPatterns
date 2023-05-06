ComputerCreator computerCreator = new ComputerCreator();
computerCreator.createComputer(ComputerName.Toshiba);


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

enum ComputerName
{
    Asus,
    Lenova,
    MSI,
    Toshiba
}

class ComputerCreator
{
    CPU CPU;
    RAM RAM;
    GraphicCard GraphicCard;
    public Computer createComputer(ComputerName computerName)
    {
        IComputerFactory factory = computerName switch
        {
            ComputerName.Asus => new AsusComputerFactory(),
            ComputerName.MSI => new MSIComputerFactory(),
            ComputerName.Lenova => new LenovaComputerFactory(),
            ComputerName.Toshiba => new ToshibaComputerFactory(),

        };

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
class LenovaComputerFactory : IComputerFactory
{
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
        Console.WriteLine($"{nameof(LenovaComputerFactory)} nesnesi oluşturuldu");
    }
}
class MSIComputerFactory : IComputerFactory
{
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
        Console.WriteLine($"{nameof(MSIComputerFactory)} nesnesi oluşturuldu");
    }
}
class ToshibaComputerFactory : IComputerFactory
{
    public ToshibaComputerFactory()
    {
        Console.WriteLine($"{nameof(ToshibaComputerFactory)} oluşturuldu.");
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
        Console.WriteLine($"{nameof(ToshibaComputerFactory)} nesnesi oluşturuldu");
    }
}

