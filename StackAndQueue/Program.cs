namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack And Queue !");
            LinkedListStack stack = new LinkedListStack();
            LinkedListQueue queue = new LinkedListQueue();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nSelect the operation to perform \n1.Create Stack \n2.Display Stack \n3.Peek \n4.Pop \n5.Create Queue " +
                    "\n6.Display Queue \n7.Dequeue \n8.Exit"); 
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
                    case 5:
                        queue.Enqueue(56);
                        queue.Enqueue(30);
                        queue.Enqueue(70);
                        break;
                    case 6:
                        queue.Display();
                        break;
                    case 7:
                        queue.Dequeue();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}