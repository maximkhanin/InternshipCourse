namespace HW1.PhoneBook
{
    class SubName
    {
        private readonly string _name;
        public SubName(string name)
        {
            _name = name;
        }
        public override string ToString()
        {
            return _name;
        }
    }
}
