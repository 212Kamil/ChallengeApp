namespace ChallengeApp
{
    public class Employee
    {
        public List<int> score = new List<int>();
        public Employee(string login, string password, string age)
        {
            this.Login = login;
            this.Password = password;
            this.Age = age;

        }

        public string Login { get; private set; }
        public string Password { get; private set; }
        public string Age { get; private set; }
        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }

        public void AddScore(int number)
        {
            this.score.Add(number);
        }
    }
}
