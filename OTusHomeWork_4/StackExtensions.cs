public static class StackExtensions
{
    public static void Merge(this Stack stack1, Stack stack2)
    {
        int inputSize = stack2.Size;
        for (int i = 0; i < inputSize; i++)
        {
            stack1.Add(stack2.Pop());
        }
    }
}