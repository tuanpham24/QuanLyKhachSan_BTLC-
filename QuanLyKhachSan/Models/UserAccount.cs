


namespace QuanLyKhachSan.Models
{
    public class UserAccount
    {
        private string _Id;
        private string _Username;
        private string _Password;


        public UserAccount() { }

        public UserAccount(string id, string username, string password)
        {
            _Id = id;
            _Username = username;
            _Password = password;
        }

        public string Id { get => _Id; set => _Id = value; }
        public string UserName { get => _Username; set => _Username = value; }
        public string Password { get => _Password; set => _Password = value; }
    }
}
