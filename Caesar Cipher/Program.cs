// See https://aka.ms/new-console-template for more information

List<char> alphabet = new List<char> {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};

DecodeMessage();

void EncodeMessage()
{
    string encodedMsg = "";

    Console.WriteLine("Enter value to shift characters by.");
    var shiftValue = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter message you would like to be encoded.");
    var baseMsg = Console.ReadLine().ToLower();

    foreach(var j in baseMsg)
    {
        var position = alphabet.IndexOf(j);

        var newChar = alphabet[position + shiftValue];
        encodedMsg += newChar;
    }

    Console.WriteLine(encodedMsg);

    
}

void DecodeMessage()
{
    string encodedMsg;
    string baseMsg = "";

    Console.WriteLine("Enter shift value.");
    var shiftValue = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter message you would like to be decoded.");
    encodedMsg = Console.ReadLine().ToLower(); 

    foreach(var j in encodedMsg)
    {
        var position = alphabet.IndexOf(j);

        var newChar = alphabet[position - shiftValue];
        baseMsg += newChar;
    }

    Console.WriteLine(baseMsg);
}


