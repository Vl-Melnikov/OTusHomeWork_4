using System.Collections.Generic;

try
{
    var s = new Stack("a", "b", "c");
    //s.Arr();
    // size = 3, Top = 'c'
    Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");

    //s.Merge(new Stack("1", "2", "3"));

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
}
catch (NullReferenceException ex)
{
    Console.WriteLine(ex.ToString());
}


public class Stack
{
    // public List<string> arr = new List<string>();   
    public List<string> arr
    {
        get
        {
            return new List<string>();
        }
        set => arr = value;
    }

    public Stack(params string[] arr)
    {

    }
    //public void Arr()
    //{
    //    foreach (var i in arr)
    //    {
    //        arr.Add(i);
    //    }
    //}

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
    public static void Concat()
    {
        var arr = new List<string>();

    }
}

static class StackExtensions
{
    public static void Merge(this Stack s1, string q)
    {
        s1.Add(q);
    }
}
