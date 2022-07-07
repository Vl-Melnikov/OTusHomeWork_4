public class Stack
{
    //private class StackItem<T>
    //    //хранит текущее значение элемента стека
    //    //ссылку на предыдущий элемент в стеке
    //{
    //    public StackItem(T data)
    //    {
    //        Data = data;
    //    }
    //    public T Data { get; set; }
    //    public StackItem<T> Next { get; set; }

    //}

    private List<string> _data { get; }
    public int Size // количество элементов стека
    {
        get
        {
            return _data.Count;
        }
    }
    public Stack(params string[] inputData)
    {
        _data = new List<string>(inputData.Length);
        _data.AddRange(inputData);
    }
    public string? Top => _data.LastOrDefault();// значение верхнего элемента из стека. Если стек пустой - возвращать null
    public void Add(string item) // добавляет элемент в стэк
    {
        _data.Add(item);
    }
    public string Pop() // извлекает и удаляет верхний элемент из стэка
    {
        if (Size > 0)
        {
            var item = _data.Last();
            _data.Remove(item);
            return item;
        }
        else
        {
            throw new NullReferenceException("Стек пустой");
        }
    }
    public static Stack Concat(params Stack[] inputs)
    {
        Stack myStack = new Stack();
        foreach (Stack elem in inputs)
            myStack.Merge(elem);
        return myStack;
    }
}