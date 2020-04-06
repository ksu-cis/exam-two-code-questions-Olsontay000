using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ExamTwoCodeQuestions.Data
{
    public class Cobbler : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The event to handle INotifyPropertyChanged
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        // Private backing field for FruitFilling for getter/setter, default chosen as peach because who doesn't love peach cobbler
        private FruitFilling fruit = FruitFilling.Peach;

        /// <summary>
        /// The fruit used in the cobbler
        /// </summary>
        public FruitFilling Fruit
        {
            get
            {
                return this.fruit;
            }
            set
            {
                this.fruit = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fruit"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsBlueberry"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsCherry"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsPeach"));
            }
        }

        // Private backing field for WithIceCream getter/setter
        private bool withicecream = true;


        /// <summary>
        /// If the cobbler is served with ice cream
        /// </summary>
        public bool WithIceCream
        {
            get
            {
                return withicecream;
            }
            set
            {
                withicecream = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("WithIceCream"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price")); // Because price is changed depending on if there is icecream or not, update this property too
            }
        }

        /// <summary>
        /// Constructor if Blueberry is selected
        /// </summary>
        public bool IsBlueberry
        {
            get
            {
                return Fruit == FruitFilling.Blueberry;
            }
            set
            {
                Fruit = FruitFilling.Blueberry;
            }
        }

        /// <summary>
        /// Constructor if Cherry is selected
        /// </summary>
        public bool IsCherry
        {
            get
            {
                return Fruit == FruitFilling.Cherry;
            }
            set
            {
                Fruit = FruitFilling.Cherry;
            }
        }

        /// <summary>
        /// Constructor if Peach is selected (default)
        /// </summary>
        public bool IsPeach
        {
            get
            {
                return Fruit == FruitFilling.Peach;
            }
            set
            {
                Fruit = FruitFilling.Peach;
            }
        }



        /// <summary>
        /// Gets the price of the Cobbler
        /// </summary>
        public double Price
        {
            get
            {
                if (WithIceCream) return 5.32;
                else return 4.25;
            }
        }

        /// <summary>
        /// Gets any special instructions for preparing this dessert
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                if(WithIceCream) { return new List<string>(); }
                else { return new List<string>() { "Hold Ice Cream" }; }
            }
        }
    }
}
