﻿namespace University_App.Models.Cqrs
{
    /// <summary>
    /// Passed around to all allow dispatching a command and to be mocked by unit tests
    /// Interface for the command dispatcher itself
    /// </summary>
    public interface ICommandDispatcher
    {
        /// <summary>
        /// Dispatches a command to its handler
        /// </summary>
        /// <typeparam name="TParameter">Command Type</typeparam>
        /// <param name="command">The command to be passed to the handler</param>
        void Dispatch<TParameter>(TParameter command) where TParameter : ICommand;
    }
}
