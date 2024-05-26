using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("123", "nokia1500", "54678", 123456);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");
Console.WriteLine(nokia.Numero);

Iphone iphone = new Iphone("567", "IphoneX", "123456", 56789);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Spotify");