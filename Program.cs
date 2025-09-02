

using trilha_net_poo_desafio.Models;

// Criando instâncias
Nokia nokia = new Nokia("123123123", "Tijolão", "987654321", 22);
Iphone iphone = new Iphone("456456456", "iPhone 16 Pro Max", "123456789", 50);

// Testando Nokia
Console.WriteLine("=== Teste Nokia ===");
nokia.MostrarInfo();
nokia.Ligar();
nokia.InstalarAplicativo("Jogo da Cobrinha");
nokia.InstalarAplicativo("Opera Mini");
nokia.InstalarAplicativo("WhatsApp"); // testa memória
nokia.DesinstalarAplicativo("Jogo da Cobrinha");
nokia.InstalarAplicativo("WhatsApp"); // agora deve caber
Console.WriteLine();

// Testando iPhone
Console.WriteLine("=== Teste iPhone ===");
iphone.MostrarInfo();
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
iphone.InstalarAplicativo("GarageBand");
iphone.DesinstalarAplicativo("Instagram");
iphone.InstalarAplicativo("WhatsApp");
Console.WriteLine();

// Exibindo estado final
Console.WriteLine("=== Estado Final dos Smartphones ===");
nokia.MostrarInfo();
iphone.MostrarInfo();


