using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace ObservableCollectionExcercise
{
    public class ObservableCollectionEvents
    {
        public static void Main()
        {
            // StudentNames list
            ObservableCollection<int> marks = new ObservableCollection<int>();
            marks.Add(100);

            // Adding and Removing elements from the list.
            marks.CollectionChanged += OnCollectionChanged;
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Press 1 to perform addition");
                Console.WriteLine("Press 2 to perform removal");
                Console.WriteLine("Enter 0 to exit");
                int inp = int.Parse(Console.ReadLine());
                switch (inp)
                {
                    case 1:
                        Console.Write("Enter the element to add: ");
                        int m = int.Parse(Console.ReadLine());
                        marks.Add(m);
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Write("Enter the element to remove: ");
                        int m1 = int.Parse(Console.ReadLine());
                        marks.Remove(m1);
                        Console.WriteLine();
                        break;

                    case 0:
                        flag = false;
                        break;
                    default:
                        if (marks.Count == 0) Console.WriteLine("List is empty");
                        flag = false;
                        break;
                }
            }

        }
        private static void OnCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {

            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("Item Added!!");
            }
            else if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Item Removed!!");
            }
        }
    }
}
