namespace Lorem
{
    public class User{
        public string name {get; set}
        public string email  {get; set}
        public int number {get; set}

    }
    public class Database{
        public void addUserToDatabase(){
            var user=new User(){
                name=name,
                email=email

            };
            System.Console.WriteLine("added to database")
        }
    }




}