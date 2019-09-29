
        var names = new List<string> { "Megan", "Ana", "Felipe" };
        foreach (var name in names)
        {
            Console.WriteLine($"Hello {name.ToUpper()}!");
        }

        Console.WriteLine();
        names.Add("Maria");
        names.Add("Bill");
        names.Remove("Ana");
        foreach (var name in names)
        {
            Console.WriteLine($"Hello {name.ToUpper()}!");
        }

        Console.WriteLine($"My name is {names[0]}.");
        Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");

        Console.WriteLine($"The list has {names.Count} people in it");

        var index = names.IndexOf("Felipe"); //searches for item and returns index
        if (index != -1){//if the index is -1 then the item is not in the list
             Console.WriteLine($"The name {names[index]} is at index {index}");
        }

        var notFound = names.IndexOf("Not Found");
        Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");

         names.Sort();//alphabetical sort
        foreach (var name in names)
        {
            Console.WriteLine($"Hello {name.ToUpper()}!");
        }


