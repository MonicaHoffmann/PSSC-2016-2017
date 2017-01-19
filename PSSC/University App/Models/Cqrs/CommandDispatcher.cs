using System;
using Ninject;
using System.Threading.Tasks;

namespace University_App.Models.Cqrs
{
    // Implementation of the command dispatcher - selects and executes the appropriate command
    public class CommandDispatcher : ICommandDispatcher
    {
        private readonly IKernel _kernel;

        public CommandDispatcher(IKernel kernel)
        {
            if (kernel == null)
            {
                throw new ArgumentNullException("kernel");
            }
            _kernel = kernel;
        }

        public void Dispatch<TParameter>(TParameter command) where TParameter : ICommand
        {
            // Find the appropriate handler to call from those registered with Ninject based on the type parameters  
            var handler = _kernel.Get<ICommandHandler<TParameter>>();
            handler.Execute(command);
        }

    }
}