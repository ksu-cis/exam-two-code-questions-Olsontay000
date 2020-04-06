using System;
using System.Collections.Generic;
using System.Text;

namespace ExamTwoCodeQuestions.Data
{
    public interface IOrderItem
    {
        /// <summary>
        /// Gets/sets the fruit filling for the cobbler
        /// </summary>
        FruitFilling Fruit { get; set; }

        /// <summary>
        /// Gets the price of the item
        /// </summary>
        double Price { get; }
        
        /// <summary>
        /// Gets the list of special instructions for the current item
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
