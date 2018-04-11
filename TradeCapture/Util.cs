using System;
using System.ComponentModel;
using System.Reflection;
using System.Linq;
using EnumsNET;

namespace TradeCapture
{
    public static class Util
    {
        private const BindingFlags NonPublicInstance = BindingFlags.NonPublic | BindingFlags.Instance;

        /// <summary>
        /// Returns true if the given type is equal to or a parent class of the maybeSameOrDerived type.
        /// Returns false otherwise.
        /// </summary>
        /// <remarks>
        /// Adapted from https://stackoverflow.com/a/2742288/7711045
        /// </remarks>
        public static bool IsSameOrDerivedType(this Type type, Type maybeSameOrDerived)
        {
            return (type == maybeSameOrDerived) || maybeSameOrDerived.IsSubclassOf(type);
        } 

        /// <summary>
        /// If the given condition is false, an exception given as the type argument is thrown with the given message.
        /// If the given condition is true, this method does nothing.
        /// </summary>
        /// <remarks>
        /// Inspired by the now-defunct CodeContracts from Microsoft Research.
        /// Adapted from https://github.com/Microsoft/CodeContracts/issues/409#issuecomment-268913908
        /// with guidance from https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/using-standard-exception-types
        /// on using standard exceptions.
        /// </remarks>
        public static void ThrowIf<E>(bool condition, string format, params object[] args) where E: Exception
        {
            if (!condition) {
                Type type = typeof(E);
                E exception = (E)Activator.CreateInstance(type);
                type.GetField("_message", NonPublicInstance).SetValue(exception, string.Format(format, args));
                throw exception;
            }
        }

        /// <summary>
        /// If the given condition is false, an ArgumentException is thrown with a message that indicates that the given argument name was invalid.
        /// If the given condition is true, this method does nothing.
        /// </summary>
        /// <remarks>
        /// Inspired by Guava preconditions https://github.com/google/guava/wiki/PreconditionsExplained
        /// </remarks>
        public static void CheckArgument(bool condition, string argumentName) {
            ThrowIf<ArgumentException>(condition, "Argument invalid: {0}", argumentName);
        }

        /// <summary>
        /// If the given value is null, an ArgumentNullException is thrown with a message that indicates that the given argument name was null.
        /// If the given value is not null, this method does nothing.
        /// </summary>
        /// <remarks>
        /// Inspired by Guava preconditions https://github.com/google/guava/wiki/PreconditionsExplained
        /// </remarks>
        public static void ArgumentNotNull(object value, string argumentName) {
            ThrowIf<ArgumentNullException>(value != null, "Argument {0} was null", argumentName);
        }

        /// <summary>
        /// If the given condition is false, an InvalidOperationException is thrown with the given message.
        /// If the given condition is true, this method does nothing.
        /// </summary>
        /// <remarks>
        /// Inspired by Guava preconditions https://github.com/google/guava/wiki/PreconditionsExplained
        /// </remarks>
        public static void CheckState(bool condition, string format, params object[] args) {
            ThrowIf<InvalidOperationException>(condition, format, args);
        }
    }
}