
        int porcentaje;
        Console.WriteLine("Ingrese el porcentaje que obtuvo de respuestas correctas: ");
        porcentaje = int.Parse(Console.ReadLine());

        switch(porcentaje)
        {
            case >=90:
                Console.WriteLine("Nivel Máximo");
                break;
            case >=75:
                    Console.WriteLine("Nivel medio");
                    break;
            case >= 50:
                Console.WriteLine("Nivel regular");
                break;
            case <50:
                Console.WriteLine("Fuera de nivel");
                break;
        }
        Console.ReadLine();
  
