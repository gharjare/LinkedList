namespace LinkedList
{
    class Progam
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linkedlist program");
            LinkList<int> linkedList = new LinkList<int>();
            linkedList.Add(56);
            linkedList.Append(30);
            linkedList.Display();
            linkedList.Add(70);
            linkedList.Display();
            linkedList.AddingAtParticularPosition(2, 30);
            linkedList.Display();
            linkedList.RemoveFirstNode();
            linkedList.Display();
            linkedList.RemoveLastNode();
            linkedList.Display();
        }
    }
}

