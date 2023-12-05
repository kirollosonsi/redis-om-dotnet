using Redis.OM.Modeling;

namespace Redis.OM.Contracts
{
    /// <summary>
    /// Converter of objects into vectors.
    /// </summary>
    /// <typeparam name="T">The type to be vectorized.</typeparam>
    public interface IVectorizer<T>
    {
        /// <summary>
        /// Gets the vector Type generated by the vectorizer.
        /// </summary>
        VectorType VectorType { get; }

        /// <summary>
        /// Gets the vector dimension of the vectors generated by the vectorizer.
        /// </summary>
        int Dim { get; }

        /// <summary>
        /// Converts the provided object to a vector.
        /// </summary>
        /// <param name="obj">the object to convert.</param>
        /// <returns>A byte array containing the vectorized data.</returns>
        byte[] Vectorize(T obj);
    }
}