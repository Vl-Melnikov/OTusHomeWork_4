public class Stack
{
    private class StackItem
    {

    }
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
    public string? Top // значение верхнего элемента из стека. Если стек пустой - возвращать null
    {
        get { return _data.LastOrDefault(); }
    }
    public void Add(string item) // добавляет элемент в стэк
    {
        _data.Add(item);
    }
    public string Pop() // извлекает и удаляет верхний элемент из стэка
    {
        if (Size > 0)
        {
            var item = _data.LastOrDefault();
            _data.Remove(item);
            return item;
        }
        else
        {
            throw new NullReferenceException("Стек пустой");
        }
    }
    //public static Stack Concat(params object[] input)
    //{


    //    var str = input as string[];

    //    Stack myStack = null;
    //    myStack.Add(str);
    //    return myStack;
    //    //myStack = new Stack();
    //    //myStack.Merge(myStack);
    //    //return myStack;
    //}
}