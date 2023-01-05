
    public static void Main()
    {                            
        Console.Write("string: ");
        string str = Console.ReadLine();
         
        char[] delim = {' ', ',', '.', ':', ';', '!', '?'};
        string[] tokens = str.Split(delim, StringSplitOptions.RemoveEmptyEntries);
        
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        foreach(string token in tokens)
        {            
            if(dictionary.ContainsKey(token))
                ++dictionary[token];
            else 
                dictionary[token] = 1;
        }
            
        foreach(KeyValuePair<string, int> pair in dictionary)
            Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
    }
Print(Main);