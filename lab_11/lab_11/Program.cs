namespace lab_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reflector.InFile("create");

            Reflector.GetName(typeof(int));
            Console.WriteLine();

            Reflector.GetName(typeof(Computer));
            Console.WriteLine();

            Reflector.WriteInormation("Eсть ли публичные конструкторы:");
            Console.WriteLine(Reflector.PublicCtor(typeof(Computer)) + "\n");

            Reflector.WriteInormation("Извлекает все общедоступные публичные методы:");
            var firstList = Reflector.PublicMethods(typeof(Computer));
            foreach(var el in firstList)
                Console.WriteLine(el.ToString());
            Console.WriteLine();

            Reflector.WriteInormation("Получает информацию о полях и свойствах класса: ");
            var secondList = Reflector.InfAboutFieldsAndProp(typeof(Computer));
            foreach (var el in secondList)
                Console.WriteLine(el.ToString());
            Console.WriteLine();

            Reflector.WriteInormation("Получает все реализованные классом интерфейсы: ");
            var thirdList = Reflector.AllInterfaces(typeof(Computer));
            foreach (var el in thirdList)
                Console.WriteLine(el.ToString());
            Console.WriteLine();

            Reflector.WriteInormation("Выводит по имени класса имена методов, которые содержат заданный (пользователем) тип параметра: ");
            var fourthList = Reflector.MethodsOfClass("lab_11.Computer", "String"); //String, Int32, Object
            foreach (var el in fourthList)
                Console.WriteLine(el.ToString());
            Console.WriteLine();

            Reflector.WriteInormation("Метод Invoke, который вызывает метод класса: ");
            try
            {
                string[] texts = File.ReadAllLines("..\\..\\..\\params.txt");
                string helptexts = string.Join("|", texts);
                object[] text = new object[1];
                text[0] = helptexts;

                Reflector.InvokeFile("lab_11.Computer", "SomeOperation", text);
                text[0] = Reflector.Generator(typeof(string));
                Reflector.InvokeFile("lab_11.Computer", "SomeOperation", text);
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Reflector.WriteInormation("Добавьте в  Reflector обобщенный метод Create: ");
            var computer = Reflector.Create<Computer>();
            computer.Show();
        }
    }
}