
        int votosSim = 0;
        int votosNao = 0;
        int votosSim1 = 0;
        int votosNao2 = 0;
        string entradaUsuario = "";

        Console.WriteLine("--- Sistema de Votacao ( ps5 ou nitendo ou xbox ou pc)  ---");

        // Loop principal
        while (entradaUsuario != "fim")
        {
            Console.WriteLine("\n digite marca para votaçao ps5 ou nitendo ou xbox ou PC digite 'fim' para terminar a votacao:");
            // Lemos a entrada e convertemos para minúsculas imediatamente para simplificar o switch
            entradaUsuario = Console.ReadLine().ToLower();

            // Usamos a instrucao switch para decidir o que fazer com a entradaUsuario
            switch (entradaUsuario)
            {
                case "ps5":
                    votosSim++;
                    Console.WriteLine("Voto 'ps5' registrado.");
                    break; // Sai do bloco switch

                case "nitendo":
                    votosNao++;
                    Console.WriteLine("Voto 'nitendo' registrado.");
                    break; // Sai do bloco switch

                case "xbox":
                    votosSim1++;
                    Console.WriteLine("Voto 'xbox' registrado.");
                    break; // Sai do bloco switch
                case "pc":
                    votosNao2++;
                    Console.WriteLine("Voto 'pc' registrado.");
                    break; // Sai do bloco switch
                case "fim":
                    // A condição do while() pegará este caso, então apenas exibimos a mensagem
                    Console.WriteLine("Votacao encerrada.");
                    break; // Sai do bloco switch

                default:
                    // Este bloco é executado se nenhum dos 'case's acima corresponder
                    Console.WriteLine("Opcao invalida. Tente novamente.");
                    break; // Sai do bloco switch
            }
        }

        // Mostra os resultados finais (código igual ao exemplo anterior)
        Console.WriteLine("\n--- Resultados Finais ---");
        Console.WriteLine($"Total de votos ps5: {votosSim}");
        Console.WriteLine($"Total de votos nitendo: {votosNao}");
        Console.WriteLine($"Total de votos xbox: {votosSim1}");
        Console.WriteLine($"Total de votos pc: {votosNao2}");


