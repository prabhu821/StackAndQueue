namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack And Queue !");
            LinkedListStack stack = new LinkedListStack();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nSelect the operation to perform \n1.Create Stack \n2.Displat Stack \n3.Peek \n4.Pop \n5.Exit"); 
                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        stack.Push(70);
                        stack.Push(30);
                        stack.Push(56);
                        break;
                    case 2:
                        stack.Display();
                        break;
                    case 3:
                        stack.Peek();
                        break;
                    case 4:
                        stack.Pop();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}