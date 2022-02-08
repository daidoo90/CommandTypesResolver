using CommandTypesResolver;

var runner = new CommandCentralRunner();

string sentence = "Hello dear friends!";

// friends! dear Hello
var output = runner.Run(CommandType.CommandType1, sentence);
Console.WriteLine(output);


string word = "Hello";

// olleH
output = runner.Run(CommandType.CommandType2, word);
Console.WriteLine(output);

