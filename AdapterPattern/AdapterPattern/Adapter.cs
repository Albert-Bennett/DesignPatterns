namespace AdapterPattern
{
    public class Adapter : ITarget
    {
        private Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public int GetNumber()
        {
            string numberString = _adaptee.GetNumberAsString();

            if (int.TryParse(numberString, out int number))
                return number;

            return 0;
        }
    }
}
