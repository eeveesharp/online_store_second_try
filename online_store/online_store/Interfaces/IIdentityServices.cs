namespace online_store.Interfaces
{
    interface IIdentityServices
    {
        public string GetLogin();

        public string GetPassword();

        public string GetName();

        public string GetLastName();
    }
}
