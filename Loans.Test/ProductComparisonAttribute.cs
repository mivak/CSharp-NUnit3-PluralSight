using System;
using System.ComponentModel;

namespace Loans.Test
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = false)]
    public class ProductComparisonAttribute : CategoryAttribute
    {
    }
}
