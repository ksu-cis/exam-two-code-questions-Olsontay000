using System;
using ExamTwoCodeQuestions.Data;
using Xunit;
using System.ComponentModel;

namespace ExamTwoCodeQuestions.DataTests
{
    public class CobblerUnitTests
    {
        [Theory]
        [InlineData(FruitFilling.Cherry)]
        [InlineData(FruitFilling.Blueberry)]
        [InlineData(FruitFilling.Peach)]
        public void ShouldBeAbleToSetFruit(FruitFilling fruit)
        {
            var cobbler = new Cobbler();
            cobbler.Fruit = fruit;
            Assert.Equal(fruit, cobbler.Fruit);
        }

        [Fact]
        public void ShouldBeServedWithIceCreamByDefault()
        {
            var cobbler = new Cobbler();
            Assert.True(cobbler.WithIceCream);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldBeAbleToSetWithIceCream(bool serveWithIceCream)
        {
            var cobbler = new Cobbler();
            cobbler.WithIceCream = serveWithIceCream;
            Assert.Equal(serveWithIceCream, cobbler.WithIceCream);
        }

        [Theory]
        [InlineData(true, 5.32)]
        [InlineData(false, 4.25)]
        public void PriceShouldReflectIceCream(bool serveWithIceCream, double price)
        {
            var cobbler = new Cobbler()
            {
                WithIceCream = serveWithIceCream
            };
            Assert.Equal(price, cobbler.Price);
        }

        [Fact]
        public void DefaultSpecialInstructionsShouldBeEmpty()
        {
            var cobbler = new Cobbler();
            Assert.Empty(cobbler.SpecialInstructions);
        }

        [Fact]
        public void SpecialIstructionsShouldSpecifyHoldIceCream()
        {
            var cobbler = new Cobbler()
            {
                WithIceCream = false
            };
            Assert.Collection<string>(cobbler.SpecialInstructions, instruction =>
            {
                Assert.Equal("Hold Ice Cream", instruction);
            });
        }

        [Fact]
        public void ShouldImplementIOrderItemInterface()
        {
            var cobbler = new Cobbler();
            Assert.IsAssignableFrom<IOrderItem>(cobbler);
        }

        // Cobbler should implement the INotifyPropertyChanged Interface
        [Fact]
        public void CobblerShouldImplementINotifyPropertyChanged()
        {
            var cobbler = new Cobbler();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cobbler);
        }

        // Changing the "WithIceCream" property should invoke PropertyChanged for "Price"
        [Fact]
        public void ChangingWithIceCreamShouldInvokePropertyChangeForPrice()
        {
            var cobbler = new Cobbler();
            Assert.PropertyChanged(cobbler, "Price", () =>
            {
                cobbler.WithIceCream = false;
            });
        }

        // Changing the "WithIceCream" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingWithIceCreamShouldInvokePropertyChangeForSpecialInstructions()
        {
            var cobbler = new Cobbler();
            Assert.PropertyChanged(cobbler, "SpecialInstructions", () =>
            {
                cobbler.WithIceCream = false;
            });
        }

        // Changing the "WithIceCream" property should invoke PropertyChanged for "WithIceCream"
        [Fact]
        public void ChangingWithIceCreamShouldInvokePropertyChangeForWithIceCream()
        {
            var cobbler = new Cobbler();
            Assert.PropertyChanged(cobbler, "WithIceCream", () =>
            {
                cobbler.WithIceCream = false;
            });
        }

        // Changing the "FruitFilling" property should invoke PropertyChanged for "Fruit"
        [Fact]
        public void ChangingFruitFillingShouldInvokePropertyChangeForFruit()
        {
            var cobbler = new Cobbler();
            Assert.PropertyChanged(cobbler, "Fruit", () =>
            {
                cobbler.Fruit = FruitFilling.Cherry;
            });
        }

        // Changing the "FruitFilling" property should invoke PropertyChanged for "IsBlueberry"
        [Fact]
        public void ChangingFruitFillingShouldInvokePropertyChangeForIsBlueberry()
        {
            var cobbler = new Cobbler();
            Assert.PropertyChanged(cobbler, "IsBlueberry", () =>
            {
                cobbler.Fruit = FruitFilling.Blueberry;
            });
        }
        // Changing the "FruitFilling" property should invoke PropertyChanged for "IsCherry"
        [Fact]
        public void ChangingFruitFillingShouldInvokePropertyChangeForIsCherry()
        {
            var cobbler = new Cobbler();
            Assert.PropertyChanged(cobbler, "IsCherry", () =>
            {
                cobbler.Fruit = FruitFilling.Cherry;
            });
        }
        // Changing the "FruitFilling" property should invoke PropertyChanged for "IsPeach"
        [Fact]
        public void ChangingFruitFillingShouldInvokePropertyChangeForIsPeach()
        {
            var cobbler = new Cobbler();
            Assert.PropertyChanged(cobbler, "IsPeach", () =>
            {
                cobbler.Fruit = FruitFilling.Peach;
            });
        }
    }
}
