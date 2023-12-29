public class HelloWorld
{
    public static void Main(string[] args)
    {
        string res = "Hello World!";
        GetCharactersCount(res);
        //Console.WriteLine(result);
    }
    
    public static void GetCharactersCount(string message){
        while(message.Length > 0){
            int c= 0;
            for(int i = 0; i < message.Length; i++){
                if(message[0] == message[i]){
                    c++;
                }
            }
            Console.WriteLine(message[0] + ": " + c);
            message = message.Replace(message[0].ToString(), "");
        }
    }
}