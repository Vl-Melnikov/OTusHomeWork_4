
var s = new Stack<string>();

s.Add("a");
s.Add("b");
s.Add("c");
// size = 3, Top = 'c'
Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");
var deleted = s.Pop();
// Извлек верхний элемент 'c' Size = 2
Console.WriteLine($"Извлек верхний элемент '{deleted}' Size = {s.Size}");
s.Add("d");
// size = 3, Top = 'd'
Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");
s.Pop();
s.Pop();
s.Pop();
// size = 0, Top = null
Console.WriteLine($"size = {s.Size}, Top = {(s.Top == null ? "null" : s.Top)}");
s.Pop();

public class Stack<T>
{
    private List<string> arr = new List<string>();

    public int Size // количество элементов стека
    {
        get { return arr.Count; }
    }
    public string? Top // значение верхнего элемента из стека. Если стек пустой - возвращать null
    {
        get { return arr.LastOrDefault(); }
    }
    public void Add(string item) // добавляет элемент в стэк
    {
        arr.Add(item);
    }
    public string Pop() // извлекает и удаляет верхний элемент из стэка
    {
        if (Size > 0)
        {
            var item = arr.LastOrDefault();
            arr.Remove(item);
            return item;
        }
        else
        {
            throw new NullReferenceException("Стек пустой");
        }
    }
}