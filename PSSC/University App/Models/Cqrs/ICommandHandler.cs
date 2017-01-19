namespace University_App.Models.Cqrs
{
    /// <summary>
    /// Base interface for command handlers
    /// Interface for command handlers - has a type parameters for the command
    /// </summary>
    /// <typeparam name="TParameter"></typeparam>
    public interface ICommandHandler<in TParameter> where TParameter : ICommand
    {
        /// <summary>
        /// Executes a command handler
        /// </summary>
        /// <param name="command">The command to be used</param>
        void Execute(TParameter command);
    }

}
