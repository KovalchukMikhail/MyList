namespace Lesson
{
    class Program
    {
        public static void Main()
        {
            MyList list = new MyList();
            list.AddFirst("Первое значение");
            list.AddFirst("Второй значение");
            list.AddFirst("Третий значение");
            ShowList(list);
            Console.WriteLine(list.PopFirst());
            ShowList(list);
            Console.WriteLine(list.Contain("Второй значение"));
            Console.WriteLine(list.Contain("1"));
            list.AddLast("Цветочек");
            ShowList(list);
            list.PopLast();
            ShowList(list);
        }
        public static void ShowList(MyList list)
        {
            Node current = list.head;
            while (current != null)
            {
                Console.Write(current.Value + ", ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }

}






