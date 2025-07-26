namespace DataStructsAndAlgos.DataStructures;

public class List<T>
{
    private T?[] Data;
    private int LastValueIdx;

    public T this[uint i]
    {
        get => Data[i]!;
        set => Data[i] = value;
    }

    public List()
    {
        Data = Array.Empty<T>();
        LastValueIdx = -1;
    }

    public List(T val) : this()
    {
        Data[0] = val;
        LastValueIdx = 0;
    }

    public void Add(T val)
    {
        int idx = LastValueIdx + 1;
        if (idx > Data.Length - 1)
        {
            ResizeData(true);
        }
        Data[idx] = val;
        LastValueIdx++;
    }

    private void ResizeData(bool bigger)
    {
        if (bigger)
        {
            T?[] DataTemp = Data;
            Data = new T?[Data.Length == 0 ? 1 : Data.Length * 2];
            Array.Copy(DataTemp, Data, DataTemp.Length);
        }
    }

    public void Print(bool withValues = true)
    {
        Console.WriteLine("\n---- List ----");
        Console.WriteLine("Length: {0}", Data.Length);
        Console.WriteLine("Last value index: {0}", LastValueIdx);

        if (withValues)
        {
            Console.WriteLine("Values");
            Console.WriteLine("--------------");
            for (int i = 0; i < LastValueIdx + 1; i++)
            {
                Console.WriteLine(Data[i]);
            }
        }

        Console.WriteLine("--------------\n");
    }
}
