namespace Insert_Delete_GetRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RandomizedSet randomizedSet = new RandomizedSet();
            bool entered = randomizedSet.Insert(9);
            bool removed = randomizedSet.Remove(10);
            entered = randomizedSet.Insert(5);
            entered = randomizedSet.Insert(1);
            entered = randomizedSet.Insert(12);
            entered = randomizedSet.Insert(45);
            entered = randomizedSet.Insert(8);
            entered = randomizedSet.Insert(7);
            entered = randomizedSet.Insert(5);

            Console.WriteLine(entered);
            foreach(var item in randomizedSet._set)
            {
                Console.WriteLine(item);
            }

        }
    }

    public class RandomizedSet
    {
        public HashSet<int> _set { get; set; }

        public RandomizedSet()
        {
            this._set = new HashSet<int>();
        }

        public bool Insert(int val)
        {
            if (_set.Add(val))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Remove(int val)
        {
            if (_set.Remove(val))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetRandom()
        {
            Random random = new Random();
            int size = _set.Count();
            return _set.ElementAt(random.Next(0, size));
        }
    }
}
