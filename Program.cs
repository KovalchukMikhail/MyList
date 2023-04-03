namespace Lesson
{
    class Program
    {
        public static void Main()
        {
            MyList list = new MyList();
            list.AddFirst("Первое значение");
            list.AddFirst("Второе значение");
            list.AddFirst("Третье значение");
            ShowList(list);
            Console.WriteLine(list.PopFirst());
            ShowList(list);
            Console.WriteLine(list.Contain("Второе значение"));
            Console.WriteLine(list.Contain("1"));
            list.AddLast("Цветочек");
            ShowList(list);
            list.PopLast();
            ShowList(list);
            list.AddLast("Новый001");
            list.AddLast("Новый002");
            list.AddLast("Новый003");
            ShowList(list);
            list.reverse();
            ShowList(list);
            list.reverse();
            ShowList(list);
            list.PopLast();
            list.PopLast();
            list.PopLast();
            list.PopLast();
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






