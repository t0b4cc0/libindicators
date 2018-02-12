// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Ao.cs" company="Mariusz Gumowski">
//   Copyright (c) 2003-2015 Mariusz Gumowski. All rights reserved.
// </copyright>
// <summary>
//   Awesome Oscillator Indicator.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MgFx.Indicators
{
//    using CuttingEdge.Conditions;

    /// <summary>
    /// Awesome Oscillator Indicator.
    /// </summary>
    public class AO : Indicator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AO"/> class. 
        /// </summary>
        public AO()
        {
            this.Name = "Bill Williams' Awesome Oscillator";
            this.ShortName = "AO";
        }

        /// <summary>
        /// Calculates indicator.
        /// </summary>
        /// <param name="price">Price series.</param>
        /// <returns>Calculated indicator series.</returns>
        public static double[] Calculate(double[] price)
        {
            //Condition.Requires(price, "price")
            //    .IsNotEmpty();

            var fastSma = SMA.Calculate(price, 5);
            var slowSma = SMA.Calculate(price, 34);
            var ao = new double[price.Length];

            for (int i = 0; i < price.Length; i++)
            {
                ao[i] = fastSma[i] - slowSma[i];
            }

            return ao;
        }
    }
}
