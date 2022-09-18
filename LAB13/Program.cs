namespace LAB13
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var array = ConsoleInteract.InputTrain();
            ConsoleInteract.Sort(array);
            ConsoleInteract.Show(array);
            ConsoleInteract.Search(array);
            ConsoleInteract.Save(array);
        }
        
    }
}