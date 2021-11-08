using System;

namespace VisualStudioIntellisenseErrors.FxCopRules.CA1062
{
    /// <summary>
    /// 
    /// </summary>
    public class Violation
    {
        /// <summary>
        ///     This method violates the rule.
        /// </summary>
        /// <param name="input"></param>
        public void DoNotValidate(string input)
        {
            if (input.Length != 0) Console.WriteLine(input);
        }

        /// <summary>
        /// This method satisfies the rule.
        /// </summary>
        /// <param name="input"></param>
        public void Validate(string input) 
        {
            if (input == null) throw new ArgumentNullException(nameof(input));
            if (input.Length != 0) Console.WriteLine(input);
        }
    }
}