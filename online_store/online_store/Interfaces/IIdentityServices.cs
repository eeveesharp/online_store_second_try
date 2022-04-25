namespace online_store.Interfaces
{
    interface IIdentityServices
    {
        public string GetLoginFromSingUp();

        public string GetLoginFromSingIn();

        public string GetPassword();

        public string GetName();

        public string GetLastName();
    }
}
