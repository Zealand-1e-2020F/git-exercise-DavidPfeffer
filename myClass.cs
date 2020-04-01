namespace GitExercise
{
    class myClass
    {
        string _name;
        string _addresse; 
        int _postnr;
        public string MyProperty { get; set; }

        public string By { get; set; }
        
        public myClass(string name, string addresse, int postnr)
        {
            _name = name;
            _addresse = addresse;
            _postnr = postnr;
        }

        public string name { get => _name;}
        public string addresse { get => _addresse;}
        public int postnr { get => _postnr;}
    }
}