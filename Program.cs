namespace LinkedList
{
    class Progam
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linkedlist program");
            LinkList<int> linkedList = new LinkList<int>();
            linkedList.Add(30);
            linkedList.Add(56);
            linkedList.Add(70);
            linkedList.Display();
        }
    }
}

