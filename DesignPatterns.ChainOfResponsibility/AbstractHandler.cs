namespace DesignPatterns.ChainOfResponsibility
{
    public abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;

        public virtual void Handle(object request)
        {
            
            if (this._nextHandler != null)
            {
                this._nextHandler.Handle(request);
            }
        }

        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;
            return handler;
        }

    }
}
