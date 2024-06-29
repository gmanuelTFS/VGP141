namespace ChainOfResponsibility
{
    public abstract class EmailHandler
    {
        protected EmailHandler _nextHandler;

        protected EmailHandler (EmailHandler nextHandler = null)
        {
            _nextHandler = nextHandler;
        }

        public abstract void HandleEmail(Email pEmail);
    }
}
