namespace Facade.Services.Displays.Interfaces
{
    /// <summary>
    /// The display service improving display of the input values.
    /// </summary>
    public interface IDisplay
    {
        /// <summary>
        /// Enriches the specified value for display purposes.
        /// </summary>
        /// <param name="value">The original value.</param>
        /// <returns>The formatted value.</returns>
        string Enrich(object value);
    }
}
